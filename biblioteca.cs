using System;
using System.Collections.Generic;

class Biblioteca {

  string _nome;
  string _descricao;
  List<Estante> _estante = new List<Estante>();

  //Construtores
  public Biblioteca (string nome, string descricao, Estante estante) {
    _nome = nome;
    _descricao = descricao;
    _estante.Add(estante);
  }
  public Biblioteca (string nome, string descricao) {
    _nome = nome;
    _descricao = descricao;
  }
  public Biblioteca (string nome) {
    _nome = nome;
  }

  //Getters e Setters
  public string nome {
    get { return _nome; }
    set { _nome = value; }
  }
  public List<Estante> estante {
    get { return _estante; }
    set { _estante = value; }
  }

/*
  public void addEstante() {
    string n, d;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("<---------- Dados da estante ---------->");
    Console.Write("Nome: ");
    n = Console.ReadLine();
    Console.Write("Descrição: ");
    d = Console.ReadLine();
    Estante novaEstante = new Estante(n, d);
    _estante.Add(novaEstante);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\nEstante Adicionada com sucesso!");
  }
*/
}