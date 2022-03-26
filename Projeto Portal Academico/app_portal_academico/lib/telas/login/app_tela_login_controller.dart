import 'package:flutter/cupertino.dart';

class AppTelaLoginController {
  TextEditingController txtRAController = TextEditingController();
  TextEditingController txtSenhaController = TextEditingController();

  Future<bool> validaLogin() async {
    bool valida = false;
    try {
      if (txtRAController.text == '1911420267' ||
          txtSenhaController.text == '123456') {
        valida = true;
      }
    } catch (e) {
      // ignore: avoid_print
      print('AppTelaLoginController - validaLogin: $e');
    }
    return valida;
  }

  void limpaCampos() {
    txtRAController.text = "";
    txtSenhaController.text = "";
  }
}
