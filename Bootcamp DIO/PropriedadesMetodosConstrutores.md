# Propriedades

Propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.

````c#
public class Pessoa
{
  public string Nome { get; set; };
  public int Idade { get; set; };
}
````

# Métodos

Um bloco de código que executa uma ação.

````c#
public class Pessoa
{
  public string Nome { get; set; };
  public int Idade { get; set; };

  public void Apresentar()
    {
      Console.WriteLine($"Nome: {Nome} - Idade: {Idade}");
    }
}
````

# Validações de GET e SET

- GET permite obter o valor
- SET permite atribuir o valor
