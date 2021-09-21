import 'dart:async';

import 'package:crossvita/app/categoria/controller/app_categoria_controller.dart';
import 'package:crossvita/app/home/controller/app_home_controller.dart';
import 'package:crossvita/app/midia/view/app_midia_video_view.dart';
import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';
import 'package:giffy_dialog/giffy_dialog.dart';
import 'package:progress_dialog/progress_dialog.dart';

// ignore: must_be_immutable
class AppCategoriaView extends StatefulWidget {
  String categoria;
  AppCategoriaView({this.categoria});
  @override
  _AppCategoriaViewState createState() => _AppCategoriaViewState();
}

ProgressDialog progressDialog;

class _AppCategoriaViewState extends State<AppCategoriaView> {
  final AppCategoriaController _appCategoriaController =
      Modular.get<AppCategoriaController>();

  final AppHomeController _homeController = Modular.get<AppHomeController>();

  @override
  Widget build(BuildContext context) {
    progressDialog = ProgressDialog(context, type: ProgressDialogType.Normal);
    return WillPopScope(
      child: Scaffold(
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
            "Treino de ${widget.categoria}",
            style: TextStyle(color: Colors.white),
          ),
          elevation: 0,
          backgroundColor: Colors.white,
        ),
        body: telaTreinoVideos(),
      ),
      onWillPop: () {
        Navigator.pop(context);
        return null;
      },
    );
  }

  Widget telaTreinoVideos() {
    return Container(
      color: Colors.grey[200],
      child: Padding(
        padding: EdgeInsets.all(8),
        child: Container(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Expanded(
                  child: ListView.builder(
                itemCount: _homeController.thumbnailList.length,
                shrinkWrap: true,
                itemBuilder: (BuildContext context, int index) {
                  return _cardThumbnailVideo(
                    _homeController.thumbnailList[index].urlThumbnail,
                    _homeController.thumbnailList[index].nomeVideo,
                  );
                },
              )),
            ],
          ),
        ),
      ),
    );
  }

  Widget _cardThumbnailVideo(String urlThumbnail, String nomeVideo) => Padding(
        padding: const EdgeInsets.only(top: 10.0),
        child: Card(
          color: Colors.black,
          clipBehavior: Clip.antiAlias,
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(24),
          ),
          child: Column(
            children: [
              Stack(
                alignment: Alignment.center,
                children: [
                  Ink.image(
                    image: NetworkImage(
                      '$urlThumbnail',
                    ),
                    // colorFilter: ColorFilters.greyscale,
                    child: InkWell(
                      onTap: () async {
                        final urlVideo =
                            await _appCategoriaController.converteURLVideo(
                                widget.categoria.toUpperCase(),
                                nomeVideo.split('.')[0]);
                        progressDialog.show();
                        progressDialog.style(
                          message: 'Disponibilizando vídeo...',
                          backgroundColor: Colors.white,
                          messageTextStyle: TextStyle(
                            color: Colors.black,
                          ),
                        );

                        Future.delayed(Duration(seconds: 3)).then(
                          (value) {
                            progressDialog.hide();
                            if (urlVideo != null) {
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                  builder: (context) => AppVideoTreinoView(
                                    url: urlVideo,
                                    nome: nomeVideo,
                                    thumbnail: urlThumbnail,
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
                                  image: Image.network(
                                    '$urlThumbnail',
                                    fit: BoxFit.cover,
                                  ),
                                  title: Text(
                                    '$nomeVideo'.split('.')[0],
                                    textAlign: TextAlign.center,
                                    style: TextStyle(
                                        fontSize: 22.0,
                                        fontWeight: FontWeight.w600),
                                  ),
                                  entryAnimation: EntryAnimation.TOP,
                                  description: Text(
                                    'O correu um erro ao iniciar o vídeo :(',
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
                ],
              ),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Text(
                  '$nomeVideo'.split('.')[0].toUpperCase(),
                  textAlign: TextAlign.center,
                  style: TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                    color: Colors.white,
                  ),
                ),
              ),
            ],
          ),
        ),
      );
}
