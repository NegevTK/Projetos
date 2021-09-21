import 'package:firebase_core/firebase_core.dart';
import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await Firebase.initializeApp();
  runApp(AppWidget());
}

class AppWidget extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: "CrossVita",
      initialRoute: '/',
      navigatorKey: Modular.navigatorKey,
      onGenerateRoute: Modular.generateRoute,
    );
  }
}
