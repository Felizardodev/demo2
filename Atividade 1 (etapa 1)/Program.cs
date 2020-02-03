using System;
using Models;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaConvidados convidados = new ListaConvidados();
            string resposta = "S";

            Console.WriteLine ("Este é o programa para a confirmação de prensença da minha festa");

            do{
                string nome;
                int idade;
                string telefone;

                Console.WriteLine ("Insira seu nome: ");
                nome = Console.ReadLine ();
                Console.WriteLine ("Insira sua idade: ");
                idade = int.Parse (Console.ReadLine ());
                Console.WriteLine ("Insira seu telefone: ");
                telefone = Console.ReadLine ();

                Convidado convidado = new Convidado (nome, idade, telefone);

                if(convidados.addConvidado(convidado))
                   Console.WriteLine("Convidado incluido.");
                else
                   Console.WriteLine("Convidado recusado.");

                Console.WriteLine("Inserir outro convidado? (S/N) ");
                resposta = Console.ReadLine();

                Console.Clear();   
            }while(resposta.ToUpper () == "S");

            convidados.mostraConvidados();
            

        }
    }
}
