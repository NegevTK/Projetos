import 'package:flutter/material.dart';
import 'package:videos_player/model/control.model.dart';
import 'package:videos_player/model/video.model.dart';
import 'package:videos_player/videos_player.dart';

class AppVideoTreinoView extends StatefulWidget {
  AppVideoTreinoView({this.url, this.nome, this.thumbnail});
  final nome;
  final url;
  final thumbnail;
  @override
  _AppVideoTreinoViewState createState() => _AppVideoTreinoViewState();
}

class _AppVideoTreinoViewState extends State<AppVideoTreinoView> {
  @override
  Widget build(BuildContext context) {
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
            'Vídeo',
            style: TextStyle(color: Colors.white),
          ),
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
      child: Container(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Expanded(
              child: VideosPlayer(
                networkVideos: [
                  new NetworkVideo(
                    thumbnailUrl: widget.thumbnail.toString(),
                    id: '1',
                    name: widget.nome.toString(),
                    videoUrl: widget.url,
                    videoControl: new NetworkVideoControl(
                      fullScreenByDefault: false,
                      looping: false,
                      autoPlay: false,
                    ),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
