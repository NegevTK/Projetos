import 'package:crossvita/app/Login/controller/app_login_controller.dart';
import 'package:crossvita/app_rotas_navegacao.dart';
import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';

class AppLoginView extends StatefulWidget {
  @override
  _AppLoginViewState createState() => _AppLoginViewState();
}

class _AppLoginViewState extends State<AppLoginView> {
  final AppLoginController _appLoginController =
      Modular.get<AppLoginController>();
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  final GlobalKey<ScaffoldState> _scaffoldKey = GlobalKey<ScaffoldState>();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      key: _scaffoldKey,
      appBar: AppBar(
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
          'Entrar',
          style: TextStyle(color: Colors.white),
        ),
      ),
      body: _formLogin(),
    );
  }

  Widget _formLogin() {
    return Container(
      color: Colors.grey[100],
      padding: EdgeInsets.all(40),
      child: Form(
        key: _formKey,
        child: ListView(
          children: [
            Container(
              height: 200,
              child: Image.asset(
                'images/academia_logo.png',
                fit: BoxFit.cover,
              ),
            ),
            Padding(
              padding: const EdgeInsets.only(top: 20),
              child: TextFormField(
                controller: _appLoginController.loginController,
                keyboardType: TextInputType.emailAddress,
                decoration: InputDecoration(
                  prefixIcon: Icon(
                    Icons.person,
                  ),
                  labelText: 'LOGIN',
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
                onFieldSubmitted: (_) {
                  _appLoginController.escondeSenha = true;
                  setState(() {});
                },
                controller: _appLoginController.senhaController,
                obscureText: _appLoginController.escondeSenha,
                decoration: InputDecoration(
                  prefixIcon: Icon(Icons.vpn_key),
                  suffixIcon: IconButton(
                    icon: Icon(Icons.remove_red_eye),
                    onPressed: () {
                      _appLoginController.escondeSenha != false
                          ? _appLoginController.escondeSenha = false
                          : _appLoginController.escondeSenha = true;
                      setState(() {});
                    },
                  ),
                  labelText: 'SENHA',
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
              padding: const EdgeInsets.symmetric(vertical: 50),
              child: Container(
                height: 50,
                child: RaisedButton(
                  color: Colors.orange,
                  child: Text(
                    'ENTRAR',
                    style: TextStyle(color: Colors.white),
                  ),
                  onPressed: () {
                    _entrarComEmailSenha();
                  },
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  void _entrarComEmailSenha() async {
    String errorMessage = await _appLoginController.entrarComEmailSenha();
    if (errorMessage != null) {
      _scaffoldKey.currentState.showSnackBar(SnackBar(
        content: Text("$errorMessage"),
      ));
    } else {
      Navigator.pushNamed(context, APP_TELA_HOME);
    }
  }
}
