# Programação Orientada a Objeto

POO é um paradigma de programação, uma metodologia de programação focada em classes e objetos que possui os 4 pilares:

- Abstração
- Encapsulamento
- Herança
- Polimorfismo

Uma classe é uma representação, um molde abstrado de um objeto real.
Um objeto é a concretização de uma classe.

### Tipos de Paradigma de Programação

- Programação Orientada a Objetos
- Programação Estruturada
- Programação Imperativa
- Programação Procedural
- Programação Orientada a Eventos
- Programação Lógica

### Abstração

Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.

```` c#
public class Pessoa
{
  public string Nome {get; set; }
  public int Idade { get; set; }

  public void Apresentar ()
  {
    Console.WriteLine($"Olá, meu nome é {nome}, e tenho {idade} anos!");
  }
}
````

### Encapsulamento

Serve para proteger uma classe e definir limites para alteração de suas propriedades. Serve para ocultar seu comportamento e expor somente o necessário.

- Tudo public pode ser acessado
- Tudo private só pode ser acessado pela própria classe

```` c#
public class ContaCorrente
{
  public ContaCorrente(int numeroConta, decimal saldoInicial)
  {
    NumeroConta = numeroConta;
    saldo = saldoInicial;
  }

  public int NumeroConta {get; set; }

  private decimal saldo; // Só quem consegue alterar o saldo é a própria classe

  public void Sacar (decimal valor)
  {
    if (saldo >= valor)
    {
      saldo -= valor;
    }
    else
    {
      Console.WriteLine("Valor desejado é maior que o saldo disponível");
    }
  }

  public void ExibirSaldo()
  {
    Console.WriteLine($"Seu saldo disponível é: {saldo}"); 
  }
}
````


### Herança

A herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes. Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes.

```` c#
public class Aluno : Pessoa
{
  // Bloco de Código
}
````

### Polimorfismo

Podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.

- Para que um método possa ser sobrescrito, é necessário declarar como virtual.
- O método subscritor precisa utilizar o parâmetro override.

```` c#
public class Pessoa
{
  public string Nome {get; set}
  public string Idade {get; set;}
  public string Email {get; set;}

  public virtual void Apresentar()
  {
    Console.WriteLine($"Olá, meu nome é {nome}, e tenho {idade} anos!");
  }
}

public class Aluno : Pessoa
{
  public double Nota {get; set;}

  public override void Apresentar()
  {
    Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade}, e sou um aluno nota {Nota}!");
  }
}
````
