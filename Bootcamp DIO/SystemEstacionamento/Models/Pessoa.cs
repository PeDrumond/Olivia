// Namespaces 


namespace SystemEstacionamento.Models
{
    // Classes são abstrações, utilizadas em Programação Orientada a Objetos
    // Abstração é pegar um objeto do mundo real e transformar em objetos da programação
    // Classes possuem atributos, que vem primeior
    // Classes possuem métodos, que são as ações que a classe irão realizar
    public class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        // Métodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.")
        }
    }
}