# Tupla

Oferece uma sintaxe para agrupar vários elementos de dados em uma estrutura de dados leve. Pode ter dentro de si uma coleção de diferentes tipos. 
Uma alternativa para quando não se quer usar uma classe.

````c#
(tipos) nome = (valores);

(int, string, string) tupla = (1, "Pedro", "Drumond");
````

É possível utilizar tuplas dentro de classes também. Isso porque métodos só podem retornar void ou uma única informação. Havendo necessidade de retornar mais, usa-se tuplas.
Assim, em alguns casos é válido retornar a tupla em um método.

````c#
namespace Exemplo
{
  public class LeituraArquivo
  {
    public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
    {
      try
      {
      string[] linhas = File.ReadAllLines(caminho);
      return(true, linhas, linhas.Count());
      } catch (Exception)
      {
        return(false, new string[0], 0;
      }
    }
  }
}

// Criar 3 variáveis com os dados da tupla do método.
var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("caminho do arquivo");
````
