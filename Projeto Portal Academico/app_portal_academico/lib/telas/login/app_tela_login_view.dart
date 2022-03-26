import 'package:app_portal_academico/telas/login/app_tela_login_controller.dart';
import 'package:app_portal_academico/util/app_telas_navegacao.dart';
import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';

// ignore: use_key_in_widget_constructors
class AppTelaLogin extends StatefulWidget {
  @override
  State<AppTelaLogin> createState() => _AppTelaLoginState();
}

class _AppTelaLoginState extends State<AppTelaLogin> {
  final AppTelaLoginController _loginController =
      Modular.get<AppTelaLoginController>();

  final _formKey = GlobalKey<FormState>();

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
          title: Text('Portal Acadêmico'),
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
        ),
        body: bodyLogin(),
      ),
    );
  }

  Widget bodyLogin() {
    return SingleChildScrollView(
      child: Column(
        children: [
          logo(),
          Form(
              key: _formKey,
              child: Column(
                children: [
                  camposText(),
                  buttonAcess(),
                ],
              )),
        ],
      ),
    );
  }

  Widget logo() {
    return Padding(
      padding: const EdgeInsets.only(
          left: 18.0, right: 18.0, top: 50.0, bottom: 30.0),
      child: Container(
        height: 100,
        width: double.infinity,
        decoration: BoxDecoration(
          image: DecorationImage(
            image: AssetImage("images/logo.png"),
            fit: BoxFit.fitWidth,
          ),
        ),
      ),
    );
  }

  Widget camposText() {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: Column(
        children: [
          textFormField(
            controller: _loginController.txtRAController,
            labelText: 'RA',
            hintText: 'RA:',
            icone: Icons.perm_identity,
          ),
          textFormField(
            controller: _loginController.txtSenhaController,
            labelText: 'Senha',
            hintText: 'Senha:',
            icone: Icons.key,
          )
        ],
      ),
    );
  }

  Widget buttonAcess() {
    return TextButton(
      style: TextButton.styleFrom(
          primary: Colors.white,
          backgroundColor: Colors.orange,
          fixedSize: Size.fromWidth(330),
          padding: EdgeInsets.all(10.0)),
      child: Text(
        'Acessar'.toUpperCase(),
        style: TextStyle(fontSize: 18.0, fontWeight: FontWeight.bold),
      ),
      onPressed: () async {
        if (_formKey.currentState!.validate()) {
          if (await _loginController.validaLogin()) {
            Navigator.pushNamed(context, TELA_MENU_PRINCIPAL);
          } else {
            ScaffoldMessenger.of(context).showSnackBar(
              const SnackBar(content: Text('Dados inválidos!')),
            );
            _loginController.limpaCampos();
            _formKey.currentState!.validate();
          }
        }
      },
    );
  }

  Widget textFormField(
      {TextEditingController? controller,
      String? labelText,
      String? hintText,
      IconData? icone}) {
    return Padding(
      padding: const EdgeInsets.only(left: 8.0, right: 8.0, bottom: 30.0),
      child: TextFormField(
        obscureText: labelText == 'Senha' ? true : false,
        decoration: InputDecoration(
            fillColor: Colors.white,
            filled: true,
            labelText: labelText,
            hintText: hintText,
            prefixIcon: Icon(
              icone,
              color: Colors.orange[700],
            ),
            border: OutlineInputBorder()),
        controller: controller,
        onFieldSubmitted: (value) {
          _formKey.currentState!.validate();
        },
        validator: (value) {
          if (value == null || value == '') {
            return '*Campo obrigatório!';
          } else {
            return null;
          }
        },
      ),
    );
  }
}
