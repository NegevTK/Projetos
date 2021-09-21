import 'package:firebase_storage/firebase_storage.dart';
import 'package:mobx/mobx.dart';
part 'app_categoria_controller.g.dart';

class AppCategoriaController = _AppCategoriaControllerBase
    with _$AppCategoriaController;

abstract class _AppCategoriaControllerBase with Store {
  FirebaseStorage firebaseStorage = FirebaseStorage.instance;

  Future<String> converteURLVideo(String categoria, String nome) async {
    String urlVideo = '';
    Reference url = firebaseStorage.refFromURL(
        "gs://crossvita-academia.appspot.com/Videos/$categoria/$nome.mp4");
    urlVideo = await url.getDownloadURL();
    return urlVideo;
  }
}
