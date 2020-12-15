using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string nome, descricao, titulo, autor, editora;
    int ano, numBiblioteca=0, numEstante=0, numLivro=0, escolha = 1;
    List<Biblioteca> bibliotecas = new List<Biblioteca>();


    while(escolha != 0) {
      //menu de seleção
      Console.Clear();
      Console.WriteLine("Bem-vindo ao MyBookShelf\n\nDeseja...\n1 - adicionar uma biblioteca, estante ou livro\n2 - navegar no que já existe ou\n0 - sair");
      escolha = int.Parse(Console.ReadLine());

      if (escolha == 1) {
        Console.Clear();
        Console.WriteLine("Quer cadastrar um(a)\n1 - Biblioteca\n2 - Estante\n3 - Livro");
        escolha = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (escolha) {
          case 1:
            //criar biblioteca
            Console.WriteLine("Bem-vindo ao MyBookShelf\n\nVamos começar criando sua primeira Biblioteca...");
            Console.Write("🔸 Dê um nome a ela...\n>>>");
            nome = Console.ReadLine();
            Console.Write("🔹 Que tal uma descrição?\n>>>");
            descricao = Console.ReadLine();
            Biblioteca novaBiblioteca = new Biblioteca(nome, descricao);
          break;
          case 2:
            //criar estante
            Console.WriteLine("---------- Criar Estante ----------\n\n");
            Console.Write("Nome da estante: ");
            nome = Console.ReadLine();
            Console.Write("Descrição: ");
            descricao = Console.ReadLine();
            Estante novaEstante = new Estante(nome, descricao);
          break;
          case 3:
            //criar livro
            Console.WriteLine("---------- Cadastrar Livro ----------\n\n");
            Console.Write("Título: ");
            titulo = Console.ReadLine();
            Console.Write("Autor: ");
            autor = Console.ReadLine();
            Console.Write("Ano: ");
            ano = int.Parse(Console.ReadLine());
            Livro novoLivro = new Livro(titulo, autor, ano);
          break;
          default:
            Console.WriteLine("errado!");
          break;
        }
      } 
      else if (escolha == 2) 
      {
        Console.Clear();
        Console.WriteLine("Quer ver um(a)\n1 - Biblioteca\n2 - Estante\n3 - Livro");
        escolha = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (escolha) {
          case 1:
            //selecionar biblioteca
            Console.WriteLine("Bem-vindo ao MyBookShelf\n\n");
            Console.WriteLine("Selecione a Biblioteca desejada");
            for (int i = 0; i < bibliotecas.Count; i++) {
              Console.WriteLine("{0} - {1}", i, bibliotecas[i].nome);
            }
            numBiblioteca = int.Parse(Console.ReadLine());
          break;
          case 2:
            //selecionar estante 
            Console.WriteLine("Selecione a estante desejada");
            for (int i = 0; i < bibliotecas[numBiblioteca].estante.Count; i++) {
              Console.WriteLine("{0} - {1}", i, bibliotecas[numBiblioteca].estante[i].nome);
            }
            numEstante = int.Parse(Console.ReadLine());
          break;
          case 3:
            //selecionar livro
            Console.WriteLine("Selecione o livro desejada");
            for (int i = 0; i < bibliotecas[numBiblioteca].estante[numEstante].livros.Count; i++) {
              Console.WriteLine("{0} - {1}", i, bibliotecas[numBiblioteca].estante[numEstante].livros[i].titulo);
            }
          break;
          default:
            Console.WriteLine("errado");
          break;
        }
      } else {
        Console.WriteLine("Saindo...");
      }
    }
  }
}