import 'package:app_portal_academico/telas/login/app_tela_login_controller.dart';
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
    return Scaffold(
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
    );
  }

  Widget bodyLogin() {
    return SingleChildScrollView(
      child: Column(
        children: [
          Form(key: _formKey, child: campos()),
          buttonAcess(),
        ],
      ),
    );
  }

  Widget campos() {
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
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: TextButton(
        style: TextButton.styleFrom(
            primary: Colors.white,
            backgroundColor: Colors.orange,
            fixedSize: Size.fromWidth(250.0),
            padding: EdgeInsets.all(10.0)),
        child: Text(
          'Acessar',
          style: TextStyle(fontSize: 18.0),
        ),
        onPressed: () {},
      ),
    );
  }

  Widget textFormField(
      {TextEditingController? controller,
      String? labelText,
      String? hintText,
      IconData? icone}) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: TextFormField(
        decoration: InputDecoration(
            labelText: labelText,
            hintText: hintText,
            prefixIcon: Icon(
              icone,
              color: Colors.orange[700],
            ),
            border: OutlineInputBorder()),
        controller: controller,
      ),
    );
  }
}
