import 'package:app_portal_academico/model/categorias_model.dart';
import 'package:app_portal_academico/telas/menu/app_tela_menu_principal_controller.dart';
import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';

// ignore: use_key_in_widget_constructors
class AppTelaMenuPrincipal extends StatefulWidget {
  @override
  State<AppTelaMenuPrincipal> createState() => _AppTelaMenuPrincipalState();
}

class _AppTelaMenuPrincipalState extends State<AppTelaMenuPrincipal> {
  final AppTelaMenuController _menuController =
      Modular.get<AppTelaMenuController>();

  @override
  Widget build(BuildContext context) {
    return Container(
      constraints: BoxConstraints.expand(),
      decoration: const BoxDecoration(
        image: DecorationImage(
          image: AssetImage('images/fundo.jpg'),
          repeat: ImageRepeat.repeat,
        ),
      ),
      child: Scaffold(
        backgroundColor: Colors.transparent,
        appBar: AppBar(
          title: Text('Area do Aluno'),
          centerTitle: true,
          flexibleSpace: Container(
            decoration: const BoxDecoration(
              gradient: LinearGradient(
                  begin: Alignment.bottomLeft,
                  end: Alignment.bottomCenter,
                  colors: <Color>[
                    Colors.orangeAccent,
                    Colors.orange,
                  ]),
            ),
          ),
          actions: [
            IconButton(onPressed: () {}, icon: Icon(Icons.notifications))
          ],
        ),
        body: SingleChildScrollView(
          child: corpoMenuPrincipal(),
        ),
      ),
    );
  }

  Widget corpoMenuPrincipal() {
    return FutureBuilder(
      future: _menuController.carregaCategoria(),
      builder: (context, snapshot) {
        if (snapshot.hasData) {
          return GridView.builder(
            physics: NeverScrollableScrollPhysics(),
            shrinkWrap: true,
            gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
              crossAxisCount: 2,
            ),
            itemCount: _menuController.ltCategoria.length,
            itemBuilder: (context, index) {
              return categoria(_menuController.ltCategoria[index]);
            },
          );
        } else {
          return Text('erro');
        }
      },
    );
  }

  Widget categoria(Categoria item) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: Card(
        elevation: 5.0,
        shadowColor: Color.fromARGB(255, 3, 36, 63),
        color: Color.fromARGB(255, 1, 59, 88),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          // ignore: prefer_const_literals_to_create_immutables
          children: [
            Icon(
              item.icone,
              color: Colors.white,
              size: 60.0,
            ),
            Text(
              item.nome,
              textAlign: TextAlign.center,
              style: TextStyle(color: Colors.white, fontSize: 18.0),
            ),
          ],
        ),
      ),
    );
  }
}
