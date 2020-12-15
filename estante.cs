using System;
using System.Collections.Generic;

class Estante {
  string _nome;
  string _descricao;
  List<Livro> _livros = new List<Livro>();

  //Construtores
  public Estante (string nome, string descricao, Livro livro) {
    _nome = nome;
    _descricao = descricao;
    _livros.Add(livro);
  }
  public Estante (string nome, string descricao) {
    _nome = nome;
    _descricao = descricao;
  }
  public Estante (string nome) {
    _nome = nome;
  }


  //Getters e Setters
  public string nome {
    get { return _nome; }
    set { _nome = value; }
  }
  public string descricao {
    get { return _descricao; }
    set { _descricao = value; }
  }
  public List<Livro> livros {
    get { return _livros; }
    set { _livros = value; }
  }

}