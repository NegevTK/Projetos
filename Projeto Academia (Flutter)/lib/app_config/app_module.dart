import 'package:crossvita/app/Login/controller/app_login_controller.dart';
import 'package:crossvita/app/Login/view/app_login_view.dart';
import 'package:crossvita/app/categoria/controller/app_categoria_controller.dart';
import 'package:crossvita/app/categoria/view/app_categoria_view.dart';
import 'package:crossvita/app/home/controller/app_home_controller.dart';
import 'package:crossvita/app/home/view/app_home_view.dart';
import 'package:crossvita/app/midia/controller/app_midia_video_controller.dart';
import 'package:crossvita/app/midia/view/app_midia_video_view.dart';
import 'package:crossvita/app_rotas_navegacao.dart';
import 'package:crossvita/widget/app_widget.dart';
import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';

class AppModule extends MainModule {
  @override
  List<Bind> get binds => [
        Bind((i) => AppLoginController()),
        Bind((i) => AppHomeController()),
        Bind((i) => AppMidiaVideoController()),
        Bind((i) => AppCategoriaController()),
      ];
  @override
  List<ModularRouter> get routers => [
        ModularRouter(APP_TELA_LOGIN, child: (_, args) => AppLoginView()),
        ModularRouter(APP_TELA_HOME, child: (_, args) => AppHomeView()),
        ModularRouter(APP_TELA_CATEGORIA,
            child: (_, args) => AppCategoriaView()),
        ModularRouter(APP_TELA_VIDEO, child: (_, args) => AppVideoTreinoView()),
      ];
  @override
  Widget get bootstrap => AppWidget();
}
