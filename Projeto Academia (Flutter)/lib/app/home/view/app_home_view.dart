import 'dart:async';
import 'package:crossvita/app/categoria/view/app_categoria_view.dart';
import 'package:crossvita/app/home/controller/app_home_controller.dart';
import 'package:crossvita/app_rotas_navegacao.dart';
import 'package:curved_navigation_bar/curved_navigation_bar.dart';
import 'package:firebase_auth/firebase_auth.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_modular/flutter_modular.dart';
import 'package:get_version/get_version.dart';
import 'package:giffy_dialog/giffy_dialog.dart';
import 'package:image_picker/image_picker.dart';
import 'package:progress_dialog/progress_dialog.dart';

class AppHomeView extends StatefulWidget {
  @override
  _AppHomeViewState createState() => _AppHomeViewState();
}

class _AppHomeViewState extends State<AppHomeView> {
  String _platformVersion = 'Unknown';
  String _projectVersion = '';
  String _projectCode = '';
  String _projectAppID = '';
  String _projectName = '';

  int paginaIndice = 1;
  final AppHomeController _homeController = Modular.get<AppHomeController>();
  final FirebaseAuth _firebaseAuth = FirebaseAuth.instance;
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  @override
  initState() {
    super.initState();
    initPlatformState();
  }

  initPlatformState() async {
    String platformVersion;
    try {
      platformVersion = await GetVersion.platformVersion;
    } on PlatformException {
      platformVersion = 'Failed to get platform version.';
    }

    String projectVersion;
    try {
      projectVersion = await GetVersion.projectVersion;
    } on PlatformException {
      projectVersion = 'Failed to get project version.';
    }

    String projectCode;
    try {
      projectCode = await GetVersion.projectCode;
    } on PlatformException {
      projectCode = 'Failed to get build number.';
    }

    String projectAppID;
    try {
      projectAppID = await GetVersion.appID;
    } on PlatformException {
      projectAppID = 'Failed to get app ID.';
    }

    String projectName;
    try {
      projectName = await GetVersion.appName;
    } on PlatformException {
      projectName = 'Failed to get app name.';
    }

    if (!mounted) return;
    setState(
      () {
        _platformVersion = platformVersion;
        _projectVersion = projectVersion;
        _projectCode = projectCode;
        _projectAppID = projectAppID;
        _projectName = projectName;
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    progressDialog = ProgressDialog(context, type: ProgressDialogType.Normal);

    return WillPopScope(
      child: Scaffold(
        appBar: AppBar(
          actions: [
            IconButton(
              icon: Icon(
                Icons.logout,
                color: Colors.white,
              ),
              onPressed: () {
                _desconectar();
              },
            )
          ],
          flexibleSpace: Container(
            decoration: const BoxDecoration(
              gradient: LinearGradient(
                begin: Alignment.topCenter,
                end: Alignment(0.5, 0.5),
                colors: <Color>[
                  Color(0xffff6f00),
                  Color(0xffff8f00),
                ],
              ),
            ),
          ),
          title: Text(
            '${_homeController.tituloAppBar(paginaIndice)}',
            style: TextStyle(color: Colors.white),
          ),
        ),
        bottomNavigationBar: Container(
          decoration: const BoxDecoration(
            gradient: LinearGradient(
              begin: Alignment.topCenter,
              end: Alignment(0.5, 0.5),
              colors: <Color>[
                Color(0xffff6f00),
                Color(0xffff8f00),
              ],
            ),
          ),
          child: CurvedNavigationBar(
            index: paginaIndice,
            animationDuration: Duration(milliseconds: 250),
            animationCurve: Curves.ease,
            height: 60,
            color: Color(0xffff6f00),
            backgroundColor: Colors.grey[200],
            buttonBackgroundColor: Color(0xffff6f00),
            items: <Widget>[
              Icon(Icons.person, size: 20, color: Colors.white),
              Icon(Icons.fitness_center_outlined,
                  size: 20, color: Colors.white),
              Icon(Icons.info, size: 20, color: Colors.white),
            ],
            onTap: (index) {
              setState(
                () {
                  paginaIndice = index;
                  controllerPage.animateToPage(
                    index,
                    duration: Duration(milliseconds: 250),
                    curve: Curves.ease,
                  );
                },
              );
            },
          ),
        ),
        body: telaSecionada(),
      ),
      onWillPop: () {
        if (paginaIndice != 1) {
          setState(
            () {
              controllerPage.animateToPage(
                1,
                duration: Duration(milliseconds: 250),
                curve: Curves.ease,
              );
            },
          );
        }
        return null;
      },
    );
  }

  Widget telaSecionada() {
    return PageView(
      onPageChanged: (value) {
        setState(
          () {
            if (value == 0) {
              _homeController.preencheValores();
            }
            paginaIndice = value;
          },
        );
      },
      controller: controllerPage,
      children: [
        telaPerfil(),
        telaTreinos(),
        telaSobre(),
      ],
    );
  }

  //Tela Perfil
  Widget telaPerfil() {
    return Container(
      color: Colors.grey[200],
      child: Padding(
        padding: EdgeInsets.all(20),
        child: Container(
          child: Form(
            key: _formKey,
            child: ListView(
              children: [
                Padding(
                  padding: const EdgeInsets.only(bottom: 20.0, top: 20.0),
                  child: GestureDetector(
                    child: CircleAvatar(
                      radius: 80.0,
                      backgroundColor: Colors.white,
                      child: Icon(
                        Icons.photo_camera_sharp,
                        size: 80.0,
                        color: Colors.grey[600],
                      ),
                    ),
                    onTap: () async {
                      dynamic image = await ImagePicker()
                          .getImage(source: ImageSource.gallery);
                      _homeController.fotoPerfil = image;
                      print(image);
                    },
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 20),
                  child: TextFormField(
                    onChanged: (_) {
                      if (_firebaseAuth.currentUser.displayName !=
                          _homeController.nomeController.text) {
                        setState(() {
                          _homeController.testeAltera = true;
                        });
                      } else {
                        setState(() {
                          _homeController.testeAltera = false;
                        });
                      }
                    },
                    controller: _homeController.nomeController,
                    keyboardType: TextInputType.text,
                    decoration: InputDecoration(
                      prefixIcon: Icon(
                        Icons.person,
                      ),
                      labelText: 'Usuário:',
                    ),
                    validator: (String value) {
                      if (value.isEmpty) {
                        return "*Campo obrigatório";
                      }
                      return null;
                    },
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 20),
                  child: TextFormField(
                    keyboardType: TextInputType.emailAddress,
                    onChanged: (_) {
                      if (_firebaseAuth.currentUser.email !=
                          _homeController.emailController.text) {
                        setState(() {
                          _homeController.testeAltera = true;
                        });
                      } else {
                        setState(() {
                          _homeController.testeAltera = false;
                        });
                      }
                    },
                    controller: _homeController.emailController,
                    decoration: InputDecoration(
                      prefixIcon: Icon(Icons.email),
                      labelText: 'Email:',
                    ),
                    validator: (String value) {
                      if (value.isEmpty) {
                        return "*Campo obrigatório";
                      }
                      return null;
                    },
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 28.0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.end,
                    children: [
                      Padding(
                        padding: const EdgeInsets.only(right: 20),
                        child: Container(
                          height: 40,
                          child: RaisedButton(
                            color: Colors.green,
                            child: Text(
                              'SALVAR',
                              style: TextStyle(color: Colors.white),
                            ),
                            onPressed: _homeController.testeAltera == true
                                ? () {
                                    setState(() {
                                      _firebaseAuth.currentUser.updateEmail(
                                          _homeController.emailController.text);
                                      _firebaseAuth.currentUser.updateProfile(
                                          displayName: _homeController
                                              .nomeController.text);
                                      _homeController.testeAltera = false;
                                    });
                                  }
                                : null,
                          ),
                        ),
                      ),
                      Padding(
                        padding: const EdgeInsets.symmetric(vertical: 50),
                        child: Container(
                          height: 40,
                          child: RaisedButton(
                            color: Colors.red,
                            child: Text(
                              'CANCELAR',
                              style: TextStyle(color: Colors.white),
                            ),
                            onPressed: _homeController.testeAltera == true
                                ? () {
                                    _homeController.preencheValores();
                                    setState(() {
                                      _homeController.testeAltera = false;
                                    });
                                  }
                                : null,
                          ),
                        ),
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  //Tela Treinos
  Widget telaTreinos() {
    return Container(
      color: Colors.grey[200],
      child: Padding(
        padding: EdgeInsets.all(20),
        child: Container(
          child: Column(
            children: [
              Expanded(
                child: ListView(
                  children: [
                    buildImageCard('images/img_card_abdominal.png', 'Abdomem'),
                    buildImageCard('images/img_card_biceps.jpg', 'Biceps'),
                    buildImageCard('images/img_card_costas.jpg', 'Costas'),
                    buildImageCard('images/img_card_peito.jpg', 'Peitoral'),
                    buildImageCard('images/img_card_pernas.png', 'Perna'),
                    buildImageCard('images/img_card_gluteo.jpg', 'Gluteo'),
                    buildImageCard('images/img_card_trapezio.jpg', 'Trapezio'),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  Widget telaSobre() {
    return Container(
      color: Colors.grey[200],
      child: Padding(
        padding: EdgeInsets.all(10),
        child: Container(
          child: Column(
            children: [
              Expanded(
                child: ListView(
                  children: [
                    new ListTile(
                      leading: new Icon(Icons.info),
                      title: const Text('Nome'),
                      subtitle: new Text(_projectName),
                    ),
                    new Divider(
                      height: 20.0,
                      color: Colors.black26,
                    ),
                    new ListTile(
                      leading: new Icon(Icons.info),
                      title: const Text('Android Version'),
                      subtitle: new Text(_platformVersion),
                    ),
                    new Divider(
                      height: 20.0,
                      color: Colors.black26,
                    ),
                    new ListTile(
                      leading: new Icon(Icons.info),
                      title: const Text('Versão'),
                      subtitle: new Text(_projectVersion),
                    ),
                    new Divider(
                      height: 20.0,
                      color: Colors.black26,
                    ),
                    new ListTile(
                      leading: new Icon(Icons.info),
                      title: const Text('Codificação'),
                      subtitle: new Text(_projectCode),
                    ),
                    new Divider(
                      height: 20.0,
                      color: Colors.black26,
                    ),
                    new ListTile(
                      leading: new Icon(Icons.info),
                      title: const Text('ID Aplicação'),
                      subtitle: new Text(_projectAppID),
                    ),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  PageController controllerPage = PageController(
    initialPage: 1,
  );

  Widget buildImageCard(String imgUrl, String categoria) => Padding(
        padding: const EdgeInsets.only(top: 10.0),
        child: Card(
          clipBehavior: Clip.antiAlias,
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(24),
          ),
          child: Stack(
            alignment: Alignment.center,
            children: [
              Ink.image(
                image: AssetImage(
                  '$imgUrl',
                ),
                // colorFilter: ColorFilters.greyscale,
                child: InkWell(
                  onTap: () async {
                    await _homeController
                        .getThumbnailInFireBase(categoria.toUpperCase());
                    progressDialog.show();
                    progressDialog.style(
                      message: 'Carregando categoria...',
                      backgroundColor: Colors.white,
                      messageTextStyle: TextStyle(
                        color: Colors.black,
                      ),
                    );
                    Future.delayed(Duration(seconds: 3)).then(
                      (value) {
                        progressDialog.hide();
                        if (_homeController.thumbnailList.length > 0) {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                              builder: (context) => AppCategoriaView(
                                categoria: categoria,
                              ),
                            ),
                          );
                        } else {
                          showDialog(
                            context: context,
                            builder: (_) => AssetGiffyDialog(
                              onlyCancelButton: true,
                              buttonCancelText: Text(
                                'OK',
                                style: TextStyle(color: Colors.white),
                              ),
                              buttonCancelColor: Colors.orange,
                              image: Image.asset(
                                '$imgUrl',
                                fit: BoxFit.cover,
                              ),
                              title: Text(
                                '$categoria',
                                textAlign: TextAlign.center,
                                style: TextStyle(
                                    fontSize: 22.0,
                                    fontWeight: FontWeight.w600),
                              ),
                              entryAnimation: EntryAnimation.TOP,
                              description: Text(
                                'A categoria selecionada não possuí vídeos no momento, volte mais tarde :( ',
                                textAlign: TextAlign.center,
                                style: TextStyle(),
                              ),
                            ),
                          );
                        }
                      },
                    );
                  },
                ),
                height: 250,
                fit: BoxFit.cover,
              ),
              Positioned(
                bottom: 16,
                left: 16,
                right: 16,
                child: Text(
                  '$categoria',
                  style: TextStyle(
                    fontWeight: FontWeight.bold,
                    color: Colors.white,
                    fontSize: 24,
                  ),
                ),
              ),
            ],
          ),
        ),
      );

  Future<void> _desconectar() async {
    print('${_firebaseAuth.currentUser.displayName}');
    await _firebaseAuth.signOut();
    return Navigator.pop(context, APP_TELA_LOGIN);
  }
}
