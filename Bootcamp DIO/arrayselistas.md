# Array

É uma estrutura de dados que armazena valores do mesmo tipo, com tamanho fixo.

int[] array = new int[4]
int[] array = new int[] {42, 75,74, 61}
string[] nomes = {"Janeiro" , "Fevereiro"}

### Adicionar valores

int[] arrayInteiros = new int[4]
arrayInteiros[0] = 72
arrayInteiros[1] = 64
arrayInteiros[2] = 50
arrayInteiros[3] = 80

### Redimensionando um Array

Existe uma classe chamada Array que contém diversos métodos para trabalhar com arrays. O resize faz uma cópia do array anterior,e deleta a primeira.

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

# Listas

