import 'package:app_portal_academico/telas/categorias/notas_faltas/app_tela_notas_faltas_view.dart';
import 'package:app_portal_academico/telas/login/app_tela_login_controller.dart';
import 'package:app_portal_academico/telas/login/app_tela_login_view.dart';
import 'package:app_portal_academico/telas/menu/app_tela_menu_principal_controller.dart';
import 'package:app_portal_academico/telas/menu/app_tela_menu_principal_view.dart';
import 'package:app_portal_academico/util/app_telas_navegacao.dart';
import 'package:flutter_modular/flutter_modular.dart';

class AppModule extends Module {
  @override
  List<Bind> get binds => [
        Bind((i) => AppTelaLoginController()),
        Bind((i) => AppTelaMenuController()),
      ];
  @override
  List<ModularRoute> get routes => [
        ChildRoute(TELA_LOGIN, child: ((context, args) => AppTelaLogin())),
        ChildRoute(TELA_MENU_PRINCIPAL,
            child: ((context, args) => AppTelaMenuPrincipal())),
        ChildRoute(TELA_NOTAS_FALTAS,
            child: ((context, args) => AppTelaNotasFaltasView())),
      ];
}
