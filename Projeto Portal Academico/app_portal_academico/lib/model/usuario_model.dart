class Aluno {
  final dynamic ra;
  final dynamic senha;
  final dynamic nome;
  final dynamic curso;
  final dynamic serie;
  Aluno(this.nome, this.curso, this.serie, this.ra, this.senha);

  Aluno.fromJson(Map<String, dynamic> json)
      : ra = json['usuarioRa'],
        senha = json['senhaUsuario'],
        nome = json['nomeUsuario'],
        curso = json['nomeCurso'],
        serie = json['serieCurso'];

  Map<String, dynamic> toJson() => {
        'ra': ra,
        'senha': senha,
        'nome': nome,
        'curso': curso,
        'serie': serie,
      };
}
