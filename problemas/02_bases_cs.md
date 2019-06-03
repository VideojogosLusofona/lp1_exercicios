# Bases de C#

1 - Qual o valor hexadecimal da variável `a` após a execução do seguinte código
C#? E o valor em decimal? Justifica a tua resposta.

```cs
uint a = 0xFEDE;
a &= 0x0F0F;
```

> [Soluções](../solucoes/02_bases_cs/01.md)

---

2 - Qual o valor hexadecimal da variável `a` após a execução do seguinte código
C#? E o valor em binário? Justifica a tua resposta.

```cs
ulong a = 0xFEDE;
a |= 0x0F0F;
```

> [Soluções](../solucoes/02_bases_cs/02.md)

---

3 - Qual o valor hexadecimal da variável `a` após a execução do seguinte código
C#? E o valor em decimal? Justifica a tua resposta.

```cs
byte a = 0b1011_1100;
a ^= 0x0F;
```

> [Soluções](../solucoes/02_bases_cs/03.md)

---

4 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
uint n = uint.MaxValue;
Console.WriteLine(n + 1);
```

> [Soluções](../solucoes/02_bases_cs/04.md)

---

5 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
int n = -1;
Console.WriteLine(~n);
```

> [Soluções](../solucoes/02_bases_cs/05.md)

---

6 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
ulong a = 0xABCD;
Console.WriteLine($"{a & 0x000F}");
```

> [Soluções](../solucoes/02_bases_cs/06.md)

---

7 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
short s = 5 / 2;
Console.WriteLine($"*\t{s}\t*");
```

> [Soluções](../solucoes/02_bases_cs/07.md)

---

8 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
double x = 3.1223;
Console.WriteLine(@"\\{x}\\:" + x);
```

> [Soluções](../solucoes/02_bases_cs/08.md)

---

9 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
char c = '\u00AE';
Console.WriteLine($@"\n{c}\n");
```

> [Soluções](../solucoes/02_bases_cs/09.md)

---

10 - Escreve um programa que solicite ao utilizador uma _string_ e a volte a
mostrar no ecrã.

> [Soluções](../solucoes/02_bases_cs/10.md)

---

11 - Escreve um programa que solicite ao utilizador uma _string_ e a volte a
mostrar no ecrã de forma invertida (isto é, de trás para a frente).

> [Soluções](../solucoes/02_bases_cs/11.md)

---

12 - Escreve um programa que solicite ao utilizador dois números inteiros e
apresente a sua soma.

> [Soluções](../solucoes/02_bases_cs/12.md)

---

13 - Escreve um programa que solicite ao utilizador dois números reais de 64
bits e apresente o resultado do primeiro (base) elevado ao segundo (expoente).
Sugestão: o método
[`Math.Pow(x, y)`](https://docs.microsoft.com/dotnet/api/system.math.pow#System_Math_Pow_System_Double_System_Double)
realiza a operação de potenciação _x<sup>y</sup>_.

> [Soluções](../solucoes/02_bases_cs/13.md)

---

14 - Escreve um programa que solicite ao utilizador o comprimento, altura e
largura de um paralelepípedo retângulo, e apresente de seguida o seu volume.

> [Soluções](../solucoes/02_bases_cs/14.md)

---

15 - Escreve um programa que mostre no ecrã todos os argumentos passados na
linha de comandos.

> [Soluções](../solucoes/02_bases_cs/15.md)

---

16 - Escreve um programa que solicite ao utilizador três números inteiros e
apresente no ecrã a frase `É possível :)` se for possível adicionar dois dos
números para obter o terceiro, ou a frase `Impossível :(` em caso contrário.
Por exemplo, se o utilizador inserir os números 5, 2 e 3 o programa deve
mostrar a frase `É possível :)` pois é possível somar 2 + 3 para obter 5.

> [Soluções](../solucoes/02_bases_cs/16.md)

---

17 - Escreve um programa que solicite ao utilizador um número inteiro e imprima
o número seguido de um ponto de exclamação. Por exemplo, ao ler o número sete,
vai mostrar no ecrã `7!` . No entanto, se o número for divisível por 3 vai
mostrar "Fizz!", se for divisível por 5 vai mostrar `Buzz!`, e se for
divisível por 3 e por 5 mostra `FizzBuzz!` Sugestão: o operador `%` permite
obter o resto da divisão para calcular se dado número é divisível.

> [Soluções](../solucoes/02_bases_cs/17.md)

---

18 - Escreve um programa que solicite ao utilizador uma frase. Se a respetiva
_string_ tiver mais de 20 caracteres, o programa deve mostrar no ecrã `Too long
to read`. Se a _string_ tiver entre 5 a 20 caracteres, deve mostrar no ecrã
`Ok, if you say so.`. Se a _string_ tiver menos de 5 caracteres, o programa
deve mostrar no ecrã `That's not very meaningful, is it?`.

> [Soluções](../solucoes/02_bases_cs/18.md)

---

19 - Escreve um programa que solicite ao utilizador dois números reais: o
primeiro deve representar o _high score_ atual num jogo, e o segundo deve
representar o _score_ que o jogador acabou de conseguir. Se o _score_ do
jogador for superior ao _high score_, o programa deve mostrar a mensagem
`New high score!`, caso contrário deve mostrar `Keep trying`. Usa o operador
ternário para implementar o programa.

> [Soluções](../solucoes/02_bases_cs/19.md)

---

20 -  Indica exatamente o que é mostrado no ecrã pelo seguinte código C#,
incluindo espaços. Justifica a tua resposta.

```cs
double d = 0.3513;
float f = 12.645f;

Console.WriteLine("d -> {0,5:f2}", d);
Console.WriteLine("f -> {0,5:f2}", f);
```

> [Soluções](../solucoes/02_bases_cs/20.md)

---

21 - Indica exatamente o que é mostrado no ecrã pelo seguinte código C#,
incluindo espaços. Justifica a tua resposta.

```cs
double x = 0.1592;
double y = 1.1231;

Console.WriteLine($"x igual a {x,6:p1}");
Console.WriteLine($"y igual a {y,6:p1}");
```

> [Soluções](../solucoes/02_bases_cs/21.md)

---

22 - Indica exatamente o que é mostrado no ecrã pelo seguinte código C#,
incluindo espaços. Justifica a tua resposta.

```cs
int a = 10;
int b = 100;
int c = 1000;

string s1 = String.Format("{0,4}", a);
string s2 = String.Format("{0,4}", b);
string s3 = String.Format("{0,4}", c);

Console.WriteLine(s1 + "\n" + s2 + "\n" + s3);
```

> [Soluções](../solucoes/02_bases_cs/22.md)

---

23 - Escreve um programa que sirva como calculadora de linha de comandos,
aceitando três argumentos: 1) a operação a realizar; 2) o primeiro operando; e,
3) o segundo operando. A calculadora deve reconhecer as seguintes operações
indicadas no primeiro argumento: `+`, `-`, `/`, `x` e `p` (sendo que última
representa a operação de potenciação). A calculadora deve realizar a operação
entre os dois operandos (que se podem assumir como `doubles`), mostrar o
resultado e terminar a execução. Se não forem indicados três argumentos, ou se
a operação não for conhecida, o programa deve terminar com uma mensagem de erro
apropriada.

Exemplo de execução: `dotnet run + 3.2 5`, que deverá mostrar `8.2`.

> [Soluções](../solucoes/02_bases_cs/23.md)

---

24 - Implementa o programa anterior de forma interativa e em ciclo. O programa
deve solicitar a operação e os dois argumentos ao utilizador, apresentar a
o resultado e voltar a fazer novo pedido de operação. O programa deve terminar
apenas quando o utilizador escrever `END` em qualquer uma das solicitações.
Se o programa não reconhecer a operação, deve voltar a pedir a mesma ao
utilizador. Ao terminar, o programa deve indicar ainda quantas operações
realizou.

**Pontos extra:** Como detetar e recuperar de um valor que não seja possível
converter para `double`?

> [Soluções](../solucoes/02_bases_cs/24.md)

---

25 - Reescreve o seguinte código sem usar `breaks` e `continues`.

```cs
const int maxTurns = 20;
int turn = 0;
while (true)
{
    turn++;

    if (turn >= maxTurns)
    {
        break;
    }

    if (turn % 3 == 0)
    {
        continue;
    }

    Console.WriteLine($"Turn number {turn}");
}

Console.WriteLine($"Last turn was {turn}");
```

> [Soluções](../solucoes/02_bases_cs/25.md)

---

26 - Implementa um jogo _turn-based_, com o número máximo de _turns_ dado como
argumento na linha de comando. O jogo deve decorrer enquanto o jogador estiver
vivo e enquanto o número máximo de _turns_ não tiver sido atingido. Em cada
_turn_ o jogador tem uma probabilidade de morrer de 2%. Se o jogador não morrer
numa dada _turn_, deve ser apresentada a mensagem `Player has survived turn #3`
(substituir 3 pela pela _turn_ atual). Caso contrário, deve ser apresentada a
mensagem `Player died after 10 turns` (substituir 10 pela _turn_ em que o
jogador efetivamente morreu).

_Nota 1_: O "jogo" não é interativo, simplesmente apresenta uma mensagem por
_turn_.

_Nota 2_: Podem ser obtidos números aleatórios entre 0 e 1 usando o método
[NextDouble](https://docs.microsoft.com/dotnet/api/system.random.nextdouble)
da classe [Random](https://docs.microsoft.com/dotnet/api/system.random)
(_namespace_ [System](https://docs.microsoft.com/dotnet/api/system)) da
seguinte forma:

```cs
// Criar objeto do tipo Random
Random rng = new Random();
// Obter double entre 0 e 1
double probability = rng.NextDouble();
```

> [Soluções](../solucoes/02_bases_cs/26.md)

---

27 - Escreve um programa que solicite um número de linhas ao utilizador e
imprima um losango com números indicando o número da linha do losango. Por
exemplo, se o utilizador inserir o número 4, deve ser impresso o seguinte
losango:

```text
   1
  222
 33333
4444444
 33333
  222
   1
```

Se o utilizador inserir um valor superior a 9 o programa deve terminar com uma
mensagem de erro.

> [Soluções](../solucoes/02_bases_cs/27.md)

---

28 - Escreve um programa que aceite dois ou mais números inteiros como
parâmetros na linha de comandos, coloque esses números num _array_ de `ints` e
apresente ao utilizador um menu com as seguintes opções:

1. Obter média dos valores no _array_
2. Obter mediana dos valores no _array_
3. Obter moda dos valores no _array_
4. Obter máximo dos valores no _array_
5. Obter mínimo dos valores _no_array_
6. Sair

O programa deve funcionar em ciclo, realizando os pedidos efetuados, terminando
apenas quando o utilizador selecionar a opção 6.

> [Soluções](../solucoes/02_bases_cs/28.md)

---

<a name="ex29"></a>
29 - Escreve um programa que solicite ao utilizador um número de frases, e
depois peça ao utilizador para inserir cada uma das frases individualmente.
Cada frase deve ser dividida nas palavras que a compõem (removendo espaços e
pontuação), sendo as respetivas palavras guardadas num _array_ de _strings_.
Por sua vez, cada _array_ de _strings_ deve ser guardado num _array_ de
_arrays_. Depois, o programa deve percorrer o _array_ de _arrays_, e para cada
_array_ de _strings_ indicar quantas palavras existem na respetiva frase, e
qual a maior palavra.

_Nota 1_: O método
[Split()](https://docs.microsoft.com/dotnet/api/system.string.split#System_String_Split_System_Char___)
dos objectos do tipo `string` devolve _substrings_ da _string_ original
separadas pelos caracteres passados ao método sob a forma de _array_ de
`chars`. Por exemplo:

```cs
string s = "A string with several words";
char[] separators = new char[] { ' ', ',', '.', ':', '\t' };
string[] arrayOfStrings = s.Split(separators);
```

_Nota 2_: Deve ser usada a _keyword_ `foreach` sempre que possível.

_Exemplo de execução:_

```text
Numero de frases: 3
Frase 1: Ola Mundo
Frase 2: Uma frase mais comprida.
Frase 3: Esta e a ultima frase

Frase 1:
    Numero de palavras: 2
    Maior palavra: "Mundo"
Frase 2:
    Numero de palavras: 4
    Maior palavra: "comprida"
Frase 3:
    Numero de palavras: 5
    Maior palavra: "ultima"
```

**Nota**: o primeiro aluno a resolver este exercício receberá uma chave Steam
para o [Deponia](https://store.steampowered.com/app/214340/Deponia/).

> [Soluções](../solucoes/02_bases_cs/29.md)

---

30 - Cria um jogo _tile-based_ e _turn-based_  no qual o jogador se move numa
grelha 2D (não-toroidal, ou seja, com paredes nos limites do mundo). O jogador
apenas se move para cima, para baixo e para os lados, usando as teclas WSAD. A
tecla Q indica que o jogo terminou. A grelha deve ser representada como um
_array_ bidimensional, e após cada _turn_ o mundo de jogo deve ser mostrado no
ecrã, com o jogador representado por uma arroba (`@`) e os espaços vazios
representados por um ponto (`.`).

> [Soluções](../solucoes/02_bases_cs/30.md)

---

31 - Escreve um programa que realize a multiplicação entre uma matriz _n x m_
e um vetor _m x 1_. O programa deve começar por solicitar as dimensões _n_ e
_m_, pedindo depois ao utilizador que preencha os valores da matriz e do vetor
a multiplicar, e finalmente mostrando o resultado final na forma de um vetor
_n x 1_.

_Nota 1:_ Este exercício deve ser resolvido com recurso a _arrays_
multidimensionais.

_Nota 2:_ A resolução deste exercício depende da matéria de
[multiplicação de matrizes](https://mathinsight.org/matrix_vector_multiplication)
(disciplina de Introdução à Matemática e Física para Jogos I).

_Nota 3:_ Podes experimentar multiplicar uma matriz por um vetor _online_ em
http://matrix.reshish.com/multiplication.php.

> [Soluções](../solucoes/02_bases_cs/31.md)

---

32 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
byte b = byte.MaxValue - 1;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Iteração {i}: {(byte) (++b - 1)}");
}
```

> [Soluções](../solucoes/02_bases_cs/32.md)

---

33 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
int[] someInts = { 11, 8, 6, 3, 9, 104 };

foreach (int v in someInts)
{
    if (v % 2 == 0)
    {
        Console.WriteLine("{0,3}", v);
    }
}
```

> [Soluções](../solucoes/02_bases_cs/33.md)

---

34 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
int n = 0;

string[] frases = {
    "Curta",
    "Uma frase longa",
    "Small",
    "Very large sentence",
    "Petit",
    "How many words do I have?"
};

foreach (string s in frases)
{
    if (s.Length > 6)
    {
        n++;
    }
}

Console.WriteLine(n);
```

> [Soluções](../solucoes/02_bases_cs/34.md)

---

35 - Escreve um programa em C# que solicite ao utilizador dois números inteiros
sem sinal, e apresente, em hexadecimal, o resultado da operação AND bit a bit
do primeiro pela negação bit a bit do segundo.

> [Soluções](../solucoes/02_bases_cs/35.md)

---

36 - Escreve um programa que: 1) liste todas as classes num jogo RPG; 2)
solicite ao utilizador uma das classes (através do valor numérico do respetivo
membro da enumeração); e, 3) mostre uma descrição textual sobre essa classe. As
classes existentes neste jogo, e as respetivas descrições, são:

* **Warrior**: Melee hack-and-slash class.
* **Knight**: Heavy armor class.
* **Barbarian**: Big guy with an equally big weapon.
* **Monk**: Melee class that forgoes weapons for their powerful fists.
* **Archer**: Ranged class with bows or guns.
* **Thief**: Sneaky bandit with itchy fingers and a nose for treasure.
* **Priest**: Class who makes sure the party survives an encounter.
* **Mage**: Class with spells to burn, freeze or electrify.
* **Druid**: Class capable of summoning minions.

_Referência:_ https://www.giantbomb.com/classes/3015-405/

_Nota:_ Usar `switch` para selecionar a descrição a mostrar.

> [Soluções](../solucoes/02_bases_cs/36.md)

---

37 - Escreve um programa que crie aleatoriamente um mundo de jogo _tile-based_
2D e o mostre no ecrã. O tamanho do mundo, `x` e `y`, deve ser indicado sob a
forma de argumentos na linha de comandos. Cada célula (quadrado ou posição) do
mundo de jogo pode ter, cumulativamente e com a probabilidade indicada, os
seguintes items:

* Comida - 1,0%
* Armas - 0,5%
* Inimigo - 0,5%
* Armadilha - 0,3%

Os items devem ser representados com _enumerable flags_ (opções enumeráveis),
assim como as suas combinações. Espaços vazios devem ser representados com um
espaço, e as várias combinações de items devem ser representados com o caracter
ASCII obtido pela soma do valor ASCII do espaço (0x20) com o valor numérico do
item ou combinação de items enumerados. Por exemplo, a comida é representada
com o carácter `!` (ASCII 0x21), e a combinação de inimigo e armadilha é
representada com o carácter `,` (ASCII 0x2C).

_Nota 1_: A tabela ASCII pode ser consultada [aqui](https://www.asciitable.com/).

_Nota 2_: Pode facilitar a resolução do problema fazer _debugging_ imprimindo
no ecrã os conteúdos detalhados de cada posição do mundo de jogo, por exemplo
para a posição (5,3) pode ser impresso `(5,3) contem 'Comida, Inimigo',
caráter %`.

_Nota 3_: Podem ser obtidos números aleatórios entre 0 e 1 usando o método
[NextDouble](https://docs.microsoft.com/dotnet/api/system.random.nextdouble)
da classe [Random](https://docs.microsoft.com/dotnet/api/system.random)
(_namespace_ [System](https://docs.microsoft.com/dotnet/api/system)) da
seguinte forma:

```cs
// Criar objecto do tipo Random
Random rng = new Random();
// Obter double entre 0 e 1
double probability = rng.NextDouble();
```

> [Soluções](../solucoes/02_bases_cs/37.md)

---

38 - Considera o seguinte método `Main()`:

```cs
static void Main(string[] args)
{
    // Declaração de variáveis
    int n;
    int[] numbers;

    // Pedir ao utilizador o tamanho do array de inteiros
    Console.Write("Qual o tamanho do array?");
    n = Convert.ToInt32(Console.ReadLine());

    // Gerar números de 1 até n
    numbers = CreateNumbersToN(n);

    // Inverter os conteúdos do array
    Reverse(numbers);

    // Imprimir os conteúdos do array
    PrintNumbers(numbers);
}
```

Implementa, dentro da classe `Program`, os métodos `CreateNumbersToN()`,
`Reverse()` e `PrintNumbers()` de modo a que façam o que está indicado nos
respetivos comentários no método `Main()`.

> [Soluções](../solucoes/02_bases_cs/38.md)

---

39 - Considera a seguinte declaração do método
[Next](https://docs.microsoft.com/dotnet/api/system.random.next#System_Random_Next_System_Int32_System_Int32_)
(classe [Random](https://docs.microsoft.com/dotnet/api/system.random),
_namespace_ [System](https://docs.microsoft.com/dotnet/api/system)):

```cs
public virtual int Next(int minValue, int maxValue);
```

Indica:

1. O nome do método.
2. O tipo devolvido pelo método.
3. Os argumentos aceites pelo método.
4. A assinatura do método.
5. Outras características indicadas na declaração.
6. Se existe algum _overloading_ deste método na classe
[Random](https://docs.microsoft.com/dotnet/api/system.random), e em caso
afirmativo, mostrar as respetivas declarações.

> [Soluções](../solucoes/02_bases_cs/39.md)

---

40 - Escreve documentação em formato XML para o método `RockPaperScissors`
apresentado em baixo, seguindo as melhores práticas para o efeito. Os valores
`ROCK`, `PAPER` e `SCISSORS` devem ser considerados como constantes inteiras.

```cs
static int RockPaperScissors(int player1, int player2)
{
    if (player1 == player2)
    {
        return 0; // Draw
    }
    if (((player1 == ROCK) && (player2 == SCISSORS)) ||
        ((player1 == SCISSORS) && (player2 == PAPER)) ||
        ((player1 == PAPER) && (player2 == ROCK)))
    {
        return 1; // Player 1 wins
    }
    else
    {
        return 2; // Player 2 wins
    }
}
```

> [Soluções](../solucoes/02_bases_cs/40.md)

---

41 - 1) Reescreve o método `RockPaperScissors` de modo a que siga as melhores
práticas de legibilidade de código, nomeadamente que tenha apenas um único
`return` no fim. 2) Escreve um método `Main` para testar o método
`RockPaperScissors`, nomeadamente pedindo ao jogador um para selecionar uma
opção (`ROCK`, `PAPER` ou `SCISSORS`), ao jogador dois para fazer o mesmo, e
apresentando depois o resultado do jogo. 3) Integra os métodos `Main` e
`RockPaperScissors` numa classe chamada `RPSGame`, _namespace_ `LP1Exercises`.

> [Soluções](../solucoes/02_bases_cs/41.md)

---

42 - Melhora a legibilidade do código do exercício anterior criando duas
enumerações, uma para indicar o resultado do jogo, outra para definir as
possíveis jogadas. Mostra o código completo das enumerações criadas e da classe
`RPSGame`, todas dentro do _namespace_ `LP1Exercises`.

> [Soluções](../solucoes/02_bases_cs/42.md)

---

43 - Considera as seguintes enumerações:

```cs
enum Terrain
{
    Rock = 0,
    Plains,
    Forest,
    Jungle
}
enum BonusTerrain
{
    Water = 1,
    Food
}
```

Escreve dois métodos _overloaded_ chamados `Eat()`, um que aceite um `Terrain`
e devolva o valor numérico do respetivo membro da enumeração `Terrain`, e outro
que aceite um `BonusTerrain` e devolva o valor numérico do respetivo membro da
enumeração `BonusTerrain` multiplicado por 10. Coloca os 2 métodos como
`static` numa classe chamada `Grazer` (_namespace_ `LP1Exercises`), e escreve
um método `Main` para testar os métodos que criaste.

> [Soluções](../solucoes/02_bases_cs/43.md)

---

44 - Considera o método `Recursao()`:

```cs
static int Recursao(int n1) {
    int n2;
    if (Math.Abs(n1) > 1000) {
        n2 = n1;
    } else {
        n2 = Recursao(-n1 * 10);
    }
    return n2;
}
```

Considera a seguinte invocação do método `Recursao()`:

```cs
int n0 = Recursao(5);
```

Qual é o valor da variável `n0` após a linha de código anterior? Explica o teu
raciocínio.

_Nota 1_: O método
[Abs](https://docs.microsoft.com/dotnet/api/system.math.abs#System_Math_Abs_System_Int32_)
da classe [Math](https://docs.microsoft.com/dotnet/api/system.math)
(_namespace_ [System](https://docs.microsoft.com/dotnet/api/system))
devolve o valor absoluto (módulo) do valor passado como argumento.

> [Soluções](../solucoes/02_bases_cs/44.md)

---

45 - Temos um triângulo feito de blocos. A primeira linha do triângulo tem 1
bloco, a segunda linha tem 2 blocos, a terceira linha tem 3 blocos, e por ai
fora. Completa o método `Triang`, que, dado o número de linhas, determina
recursivamente (sem ciclos ou multiplicações) o número total de blocos num
triângulo deste tipo. Por exemplo, ao receber o valor 4, o método retorna o
valor 10 correspondente ao número de blocos, como indicado em baixo:

* `*   ` - 1 bloco
* `**  ` - 2 blocos
* `*** ` - 3 blocos
* `****` - 4 blocos

Método devolve 10, pois existem 10 blocos (asteriscos) ao todo.

De modo a testares o método, cria posteriormente um programa que solicite um
número inteiro ao utilizador, invoque o método `Triang` e imprima no ecrã o
número devolvido.

```cs
static int Triang(int linhas)
{
    // Completar este método
}
```

*Sugerido por [João Duarte](https://github.com/JoaoAlexandreDuarte), adaptado
de <http://codingbat.com/prob/p194781>.*

> [Soluções](../solucoes/02_bases_cs/45.md)

---

46 - Indica o que é impresso no ecrã pelo seguinte código. Justifica a tua
resposta.

```cs
static void Main(string[] args)
{
    Console.WriteLine(MetodoRecursivo(5));
}

static int MetodoRecursivo(int n)
{
    if (n == 0)
        return 0;
    else if (n % 2 == 0)
        return 3 + MetodoRecursivo(n - 1);
    else
        return 2 + MetodoRecursivo(n - 1);
}
```

> [Soluções](../solucoes/02_bases_cs/46.md)

---

47 - Indica o que é impresso no ecrã pelo seguinte código. Justifica a tua
resposta, explicando detalhadamente em que consiste a operação efetuada pelo
método `Fact()`.

```cs
static void Main(string[] args)
{
    uint n = 5;
    Console.WriteLine($"{n}! = {Fact(n)}");
}

static uint Fact(uint i) => i > 1 ? i * Fact(i - 1) : 1;
```

> [Soluções](../solucoes/02_bases_cs/47.md)

---

48 - Indica o que é impresso no ecrã pelo seguinte código. Justifica a tua
resposta, explicando em que consiste a operação efetuada pelo método `GCD()`.

```cs
static void Main(string[] args)
{
    ulong a = Convert.ToUInt64(args[0]);
    ulong b = Convert.ToUInt64(args[1]);
    Console.WriteLine($"GCD between {a} and {b} is {GCD(a, b)}");
}

static ulong GCD(ulong a, ulong b) => b == 0 ? a : GCD(b, a % b);
```

> [Soluções](../solucoes/02_bases_cs/48.md)

---

49 - A _stack_ é composta por _frames_. Cada _frame_ está associada a que
unidade de código? Que informação é contida em cada _frame_?

> [Soluções](../solucoes/02_bases_cs/49.md)

---

50 - Que tipos de dados podem ser guardados na _heap_? E que tipos de dados só
podem ser guardados na _heap_?

> [Soluções](../solucoes/02_bases_cs/50.md)

---

51 - Indica duas responsabilidades do _garbage collector_.

> [Soluções](../solucoes/02_bases_cs/51.md)

---

52 - É possível, com o C#, aceder à _heap_ sem gestão automática da memória
(isto é, sem intervenção do _garbage collector_)? Se sim, como?

> [Soluções](../solucoes/02_bases_cs/52.md)

---

53 - Quais as duas grandes famílias de tipos no C#, e quais as principais
diferenças entre elas? Existe ainda uma terceira família, muito menos usada.
Indica qual é.

> [Soluções](../solucoes/02_bases_cs/53.md)

---

54 - Qual é o valor da variável `x` após as seguintes instruções.

```cs
double x = 11.09;
AddOne(x);
```

> [Soluções](../solucoes/02_bases_cs/54.md)

---

55 - Indica os conteúdos do  _array_ devolvido pelo método `Process()`.

```cs
bool[] Process()
{
    bool[] a;
    a = new bool[] { true, true, false, true };
    MisteryOp(a);
    return a;
}

void MisteryOp(bool[] zz)
{
    for (int i = 0; i < zz.Length; i++)
    {
        zz[i] = !zz[i];
    }
}
```

> [Soluções](../solucoes/02_bases_cs/55.md)

---

56 - Indica os conteúdos do  _array_ devolvido pelo método `Process()`.

```cs
char[] Process()
{
    char[] a;
    a = new char[] { 'a', 'b', 'c' };
    MisteryOp(a);
    return a;
}

void MisteryOp(char[] a)
{
    a = new char[] { a[2], a[1], a[0] };
}
```

> [Soluções](../solucoes/02_bases_cs/56.md)

---

57 - Indica os conteúdos do  _array_ devolvido pelo método `Process()`.

```cs
char[] Process()
{
    char[] a;
    a = new char[] { 'a', 'b', 'c' };
    MisteryOp(ref a);
    return a;
}

void MisteryOp(ref char[] a)
{
    a = new char[] { a[2], a[1], a[0] };
}
```

> [Soluções](../solucoes/02_bases_cs/57.md)

---
