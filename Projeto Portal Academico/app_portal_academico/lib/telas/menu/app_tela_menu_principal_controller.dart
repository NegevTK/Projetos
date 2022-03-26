import 'package:app_portal_academico/model/categorias_model.dart';
import 'package:flutter/material.dart';

class AppTelaMenuController {
  List<Categoria> ltCategoria = [];

  Future<List<Categoria>> carregaCategoria() async {
    ltCategoria = [];
    try {
      Categoria eventos = Categoria(
          icone: Icons.lightbulb,
          rota: '',
          nome: 'Eventos\nSemanas Acadêmicas');
      ltCategoria.add(eventos);

      Categoria atividades = Categoria(
          icone: Icons.check, rota: '', nome: 'Atividades\nComplementares');
      ltCategoria.add(atividades);

      Categoria aplicativos = Categoria(
          icone: Icons.window_sharp, rota: '', nome: 'Aplicativos\nMicrosoft');
      ltCategoria.add(aplicativos);
    } catch (e) {
      print('AppTelaMenuController - carregaCategoria: $e');
    }
    return ltCategoria;
  }
}
