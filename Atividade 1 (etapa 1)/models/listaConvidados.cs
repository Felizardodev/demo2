using System;
using System.Collections.Generic;
using Models;

namespace Models {
    public class ListaConvidados {
        public List<Convidado> convidados;
        public ListaConvidados() {
            this.convidados = new List<Convidado>();
        }
        public bool addConvidado (Convidado convidado)
        {
          foreach (Convidado item in this.convidados)   
          {
            if (item.nome == convidado.nome) 
            return false; 
        }
        this.convidados.Add(convidado);
        return true;

        }
        public void mostraConvidados()
        {
            foreach (Convidado convidado in this.convidados)
            {
                Console.WriteLine("Nome> {0}" , convidado.nome);
                Console.WriteLine("Telefone: {0}", convidado.telefone);
                Console.WriteLine("===============\n");
            }
        }
    }
}