// ignore_for_file: prefer_const_constructors_in_immutables, use_key_in_widget_constructors

import 'package:app_portal_academico/model/categorias_model.dart';
import 'package:flutter/material.dart';

class AppTelaNotasFaltasView extends StatefulWidget {
  @override
  State<AppTelaNotasFaltasView> createState() => _AppTelaNotasFaltasViewState();
}

class _AppTelaNotasFaltasViewState extends State<AppTelaNotasFaltasView> {
  @override
  Widget build(BuildContext context) {
    final arguments =
        (ModalRoute.of(context)?.settings.arguments ?? <Categoria>{}) as Map;
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
          title: Text(arguments['nome_curso']),
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
          actions: [
            IconButton(onPressed: () {}, icon: Icon(Icons.notifications))
          ],
        ),
        body: SingleChildScrollView(
          child: Column(
            children: [Text('teste')],
          ),
        ),
      ),
    );
  }
}
