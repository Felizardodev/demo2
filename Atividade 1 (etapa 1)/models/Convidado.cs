namespace Models {

    public class Convidado 
    {
       public string nome;
       public int idade;
       public string telefone;
       public bool confirmaPresenca; 

       public Convidado (string nome, int idade, string telefone) {
           this.nome = nome;
           this.idade = idade;
           this.telefone = telefone;
       }
    }
    
}