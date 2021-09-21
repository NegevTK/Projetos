import 'package:crossvita/app/model/midia/model_midia.dart';
import 'package:firebase_auth/firebase_auth.dart';
import 'package:firebase_storage/firebase_storage.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:mobx/mobx.dart';
part 'app_home_controller.g.dart';

class AppHomeController = _AppHomeControllerBase with _$AppHomeController;

abstract class _AppHomeControllerBase with Store {
  final TextEditingController emailController = TextEditingController();
  final TextEditingController nomeController = TextEditingController();
  FirebaseStorage firebaseStorage = FirebaseStorage.instance;
  FirebaseAuth auth = FirebaseAuth.instance;

  List<Midia> thumbnailList = [];
  bool possui = false;
  bool testeAltera = false;
  dynamic fotoPerfil;

  String tituloAppBar(int index) {
    switch (index) {
      case 0:
        return 'Perfil';
        break;
      case 1:
        return 'Treinos';
        break;
      case 2:
        return 'Sobre';
        break;
      default:
        return 'Início';
    }
  }

  void preencheValores() {
    emailController.text = auth.currentUser.email.toString();
    nomeController.text = auth.currentUser.displayName.toString() == 'null'
        ? nomeController.text = ''
        : auth.currentUser.displayName.toString();
    fotoPerfil = auth.currentUser.photoURL;
  }

  Future getThumbnailInFireBase(String categoria) async {
    thumbnailList = [];
    possui = false;
    var storageRef =
        FirebaseStorage.instance.ref().child('Thumbnail').child('$categoria');
    storageRef.listAll().then((result) {
      result.items.forEach((imageRef) {
        converteURL(imageRef, imageRef.name);
      });
    }).catchError((onError) {
      print('AppHomeController - getThumbnailInFireBase: $onError');
    });
  }

  converteURL(dynamic imageRef, String nome) {
    imageRef.getDownloadURL().then((url) {
      Midia midia = new Midia(
        urlThumbnail: url,
        nomeVideo: nome,
      );
      thumbnailList.add(midia);
    }).catchError((error) {
      print('AppHomeController - converteURL');
    });
  }
}
