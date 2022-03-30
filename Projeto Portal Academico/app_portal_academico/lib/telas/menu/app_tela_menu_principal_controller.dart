// ignore_for_file: avoid_print

import 'package:app_portal_academico/model/categorias_model.dart';
import 'package:app_portal_academico/util/app_telas_navegacao.dart';
import 'package:flutter/material.dart';

class AppTelaMenuController {
  List<Categoria> items = [];
  List<Categoria> ltCategoria = [];

  Future<List<Categoria>> carregaCategoria() async {
    items = [];
    ltCategoria = [];
    try {
      Categoria eventos = Categoria(
          icone: Icons.lightbulb, rota: '', nome: 'Semanas Acadêmicas');
      ltCategoria.add(eventos);

      Categoria atividades = Categoria(
          icone: Icons.check, rota: '', nome: 'Atividades Complementares');
      ltCategoria.add(atividades);

      Categoria aplicativos = Categoria(
          icone: Icons.window_sharp, rota: '', nome: 'Aplicativos Microsoft');
      ltCategoria.add(aplicativos);

      Categoria campanha = Categoria(
          icone: Icons.adf_scanner_outlined,
          rota: '',
          nome: 'Impressões e Xerox');
      ltCategoria.add(campanha);

      Categoria boleto = Categoria(
          icone: Icons.attach_money_outlined, rota: '', nome: 'Boleto 2ª via');
      ltCategoria.add(boleto);

      Categoria horariosAulas = Categoria(
          icone: Icons.timer_outlined, rota: '', nome: 'Horário das Aulas');
      ltCategoria.add(horariosAulas);

      Categoria notasFaltas = Categoria(
          icone: Icons.note_alt_outlined,
          nome: 'Notas e Faltas',
          rota: TELA_NOTAS_FALTAS);
      ltCategoria.add(notasFaltas);

      items.addAll(ltCategoria);
    } catch (e) {
      print('AppTelaMenuController - carregaCategoria: $e');
    }
    return ltCategoria;
  }
}
