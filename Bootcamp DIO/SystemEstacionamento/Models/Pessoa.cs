// Namespaces 


namespace SystemEstacionamento.Models
{
    // Classes s�o abstra��es, utilizadas em Programa��o Orientada a Objetos
    // Abstra��o � pegar um objeto do mundo real e transformar em objetos da programa��o
    // Classes possuem atributos, que vem primeior
    // Classes possuem m�todos, que s�o as a��es que a classe ir�o realizar
    public class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        // M�todos
        public void Apresentar()
        {
            Console.WriteLine($"Ol�, meu nome � {Nome} e tenho {Idade} anos.")
        }
    }
}