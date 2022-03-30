import 'package:app_portal_academico/model/categorias_model.dart';
import 'package:app_portal_academico/telas/menu/app_tela_menu_principal_controller.dart';
import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';

// ignore: use_key_in_widget_constructors
class AppTelaMenuPrincipal extends StatefulWidget {
  @override
  State<AppTelaMenuPrincipal> createState() => _AppTelaMenuPrincipalState();
}

class _AppTelaMenuPrincipalState extends State<AppTelaMenuPrincipal> {
  final AppTelaMenuController _menuController =
      Modular.get<AppTelaMenuController>();

  @override
  void initState() {
    super.initState();
    _menuController.carregaCategoria();
  }

  @override
  Widget build(BuildContext context) {
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
          title: Text('Área do Aluno'),
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
            children: [
              textFormField(icone: Icons.search, hintText: 'Pesquisar'),
              corpoMenuPrincipal()
            ],
          ),
        ),
      ),
    );
  }

  void pesquisaCategoria(String query) {
    List<Categoria> pesquisaLista = [];
    pesquisaLista.addAll(_menuController.ltCategoria);
    if (query.isNotEmpty) {
      List<Categoria> pesquisaListaData = [];
      for (var item in pesquisaLista) {
        if (item.nome.toUpperCase().contains(query)) {
          pesquisaListaData.add(item);
        }
      }
      setState(() {
        _menuController.items.clear();
        _menuController.items.addAll(pesquisaListaData);
      });
      return;
    } else {
      setState(() {
        _menuController.items.clear();
        _menuController.items.addAll(_menuController.ltCategoria);
      });
    }
  }

  Widget corpoMenuPrincipal() {
    return GridView.builder(
      physics: NeverScrollableScrollPhysics(),
      shrinkWrap: true,
      gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
        crossAxisCount: 2,
      ),
      itemCount: _menuController.items.length,
      itemBuilder: (context, index) {
        return categoria(_menuController.items[index]);
      },
    );
  }

  Widget textFormField(
      {TextEditingController? controller,
      String? labelText,
      String? hintText,
      IconData? icone}) {
    return Padding(
      padding: const EdgeInsets.all(12.0),
      child: TextFormField(
        obscureText: labelText == 'Senha' ? true : false,
        decoration: InputDecoration(
          border: OutlineInputBorder(borderRadius: BorderRadius.circular(20.0)),
          labelText: labelText,
          hintText: hintText,
          suffixIcon: Icon(
            icone,
          ),
        ),
        controller: controller,
        onChanged: (value) {
          pesquisaCategoria(value.toUpperCase());
        },
        validator: (value) {
          if (value == null || value == '') {
            return '*Campo obrigatório!';
          } else {
            return null;
          }
        },
      ),
    );
  }

  Widget categoria(Categoria item) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: GestureDetector(
        child: Card(
          shape: RoundedRectangleBorder(
            side: BorderSide(color: Colors.white70, width: 2),
            borderRadius: BorderRadius.circular(10),
          ),
          elevation: 5.0,
          shadowColor: Color.fromARGB(255, 3, 36, 63),
          color: Color.fromARGB(255, 1, 59, 88),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            // ignore: prefer_const_literals_to_create_immutables
            children: [
              Icon(
                item.icone,
                color: Colors.white,
                size: 60.0,
              ),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Text(
                  item.nome,
                  textAlign: TextAlign.center,
                  style: TextStyle(color: Colors.white, fontSize: 18.0),
                ),
              ),
            ],
          ),
        ),
        onTap: () {
          Navigator.pushNamed(
            context,
            item.rota,
            arguments: {'nome_curso': item.nome.toString()},
          );
        },
      ),
    );
  }
}
