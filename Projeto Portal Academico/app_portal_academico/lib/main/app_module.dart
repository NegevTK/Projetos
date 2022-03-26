import 'package:app_portal_academico/telas/login/app_tela_login_controller.dart';
import 'package:app_portal_academico/telas/login/app_tela_login_view.dart';
import 'package:app_portal_academico/util/app_telas_navegacao.dart';
import 'package:flutter_modular/flutter_modular.dart';

class AppModule extends Module {
  @override
  List<Bind> get binds => [
        Bind((i) => AppTelaLoginController()),
      ];
  @override
  List<ModularRoute> get routes => [
        ChildRoute(TELA_LOGIN, child: ((context, args) => AppTelaLogin())),
      ];
}
