import 'package:app_portal_academico/model/usuario_model.dart';
import 'package:dio/dio.dart';
import 'package:flutter/material.dart';

class AppTelaLoginController {
  TextEditingController txtRAController = TextEditingController();
  TextEditingController txtSenhaController = TextEditingController();

  Future<bool> validaLogin() async {
    bool valida = false;
    int ra = int.parse(txtRAController.text.toString().trim());
    String senha = txtSenhaController.text.toString().trim();
    try {
      var response = await Dio()
          .get('http://192.168.0.102:8080/usuario/getByRa/$ra/senha/$senha');
      Aluno aluno = Aluno.fromJson(response.data);
      if (aluno.ra != null) {
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
