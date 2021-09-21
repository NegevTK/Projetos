import 'package:firebase_auth/firebase_auth.dart';
import 'package:flutter/material.dart';
import 'package:mobx/mobx.dart';
part 'app_login_controller.g.dart';

class AppLoginController = _AppLoginControllerBase with _$AppLoginController;

abstract class _AppLoginControllerBase with Store {
  final TextEditingController loginController = TextEditingController();
  final TextEditingController senhaController = TextEditingController();
  FirebaseAuth auth = FirebaseAuth.instance;
  bool escondeSenha = true;

  Future<String> entrarComEmailSenha() async {
    String errorMessage = '';
    try {
      await auth.signInWithEmailAndPassword(
          email: loginController.text, password: senhaController.text);
    } on FirebaseAuthException catch (error) {
      print('AppLoginView - _entrarComEmailSenha: ${error.code}');
      switch (error.code) {
        case "invalid-email":
          errorMessage = "Seu endereço de e-mail parece estar incorreto.";
          break;
        case "wrong-password":
          errorMessage = "Sua senha esta errada.";
          break;
        case "user-not-found":
          errorMessage = "Usuário não encontrado.";
          break;
        case "user-disabled":
          errorMessage = "O usuário com este e-mail foi desativado.";
          break;
        case "too-many-requests":
          errorMessage = "Muitos pedidos. Tente mais tarde.";
          break;
        case "operation-not-allowed":
          errorMessage = "O login com e-mail e senha não está ativado.";
          break;
        default:
          errorMessage = "Erro desconhecido...";
      }
      return errorMessage;
    }
    return null;
  }
}
