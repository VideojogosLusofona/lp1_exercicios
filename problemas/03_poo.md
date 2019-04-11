# Programação Orientada a Objetos

1 - Escreve um programa em C# que aceite dois inteiros na linha de comandos e
imprima no ecrã cinco números aleatórios cujo valor se situe no intervalo
entre os dois inteiros dados. Usa para o efeito um objeto da classe
[Random](https://docs.microsoft.com/dotnet/api/system.random).

> [Soluções](../solucoes/03_poo/01.md)

## Soluções

### Solução 1

```
int n1, n2;

Random random = new Random();
n1 = Convert.ToInt32(args[0]);
n2 = Convert.ToInt32(args[1]);

for (int i = 0; i < 5; i++)
{
	Console.WriteLine(random.Next(n1, n2));
}
```

*Por [Sara Gama](https://github.com/serapinta).*