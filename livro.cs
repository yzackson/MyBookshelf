using System;

class Livro {
  string _titulo;
  string _autor;
  int _ano;
  string _estante;
  DateTime _dataAdd = new DateTime();

  //Construtores
  public Livro (string titulo, string autor, int ano) {
    _titulo = titulo;
    _autor = autor;
    _ano = ano;
    _dataAdd = DateTime.Now;
  }
  public Livro (string titulo) {
    _titulo = titulo;
    _autor = "Desconhecido(a)";
    _ano = 9999;
    _estante = "Limbo";
    _dataAdd = DateTime.Now;
  }

  //Getters e Setters
  public string titulo {
    get {return _titulo;}
    set {_titulo = value;}
  }
  public string autor {
    get {return _autor;}
    set {_autor = value;}
  }
  public int ano {
    get {return _ano;}
    set {_ano = value;}
  }
  public string estante {
    get {return _estante;}
    set {_estante = value;}
  }
  public DateTime dataAdd {
    get {return _dataAdd;}
  }
}