# Programação Orientada a Objetos

1 - Escreve um programa em C# que aceite dois inteiros na linha de comandos e
imprima no ecrã cinco números aleatórios cujo valor se situe no intervalo
entre os dois inteiros dados. Usa para o efeito um objeto da classe
[Random](https://docs.microsoft.com/dotnet/api/system.random).

> [Soluções](../solucoes/03_poo/01.md)

---

2 - A classe
[`Stack`](https://docs.microsoft.com/dotnet/api/system.collections.stack)
(_namespace_
[`System.Collections`](https://docs.microsoft.com/dotnet/api/system.collections))
implementa a estrutura de dados
[_stack_/pilha](https://en.wikipedia.org/wiki/Stack_(abstract_data_type)),
na qual a última coisa a ser inserida é a primeira a ser retirada. Objetos do
tipo `Stack` podem ser instanciados com o construtor simples
[`Stack()`](https://docs.microsoft.com/dotnet/api/system.collections.stack.-ctor#System_Collections_Stack__ctor).
O método
[`Push()`](https://docs.microsoft.com/dotnet/api/system.collections.stack.push)
coloca um objeto na pilha, enquanto o método
[`Pop()`](https://docs.microsoft.com/dotnet/api/system.collections.stack.pop)
retira o último objeto lá colocado. O método
[`Contains()`](https://docs.microsoft.com/dotnet/api/system.collections.stack.contains)
verifica se dado objeto existe na pilha.

Cria um programa em C# que apresente um menu ao utilizador com quatro opções:

1. Inserir _string_ na pilha
2. Remover _string_ da pilha, imprimindo a mesma no ecrã
3. Verificar se determinada _string_ existe na pilha
4. Sair

O menu deve ser apresentado em ciclo, e o programa só deve terminar quando o
utilizador selecionar a opção 4.

_Nota:_ A _stack_/pilha aqui referida é a estrutura de dados e não a
_stack_ (zona de memória) onde os programas colocam as variáveis locais dos
métodos e por ai fora.

> [Soluções](../solucoes/03_poo/02.md)

---

3 - Dá uma vista de olhos na documentação da classe
[`Math`](https://docs.microsoft.com/dotnet/api/system.math)
(_namespace_ [`System`](https://docs.microsoft.com/dotnet/api/system)).
É possível instanciar objetos desta classe? Porquê?

> [Soluções](../solucoes/03_poo/03.md)

---

4 - A classe
[`Queue`](https://docs.microsoft.com/dotnet/api/system.collections.queue)
(_namespace_ [`System.Collections`](https://docs.microsoft.com/dotnet/api/system.collections))
implementa a estrutura de dados
[queue/fila](https://en.wikipedia.org/wiki/Queue_(abstract_data_type)),
na qual a primeira coisa a ser inserida é a primeira a ser retirada. Objetos do
tipo `Queue` podem ser instanciados com o construtor simples
[`Queue()`](https://docs.microsoft.com/dotnet/api/system.collections.queue.-ctor#System_Collections_Queue__ctor).
O método
[`Enqueue()`](https://docs.microsoft.com/dotnet/api/system.collections.queue.enqueue#System_Collections_Queue_Enqueue_System_Object_)
coloca um objeto no fim da fila, enquanto o método
[`Dequeue()`](https://docs.microsoft.com/dotnet/api/system.collections.queue.dequeue#System_Collections_Queue_Dequeue)
retira o primeiro objeto lá colocado. O método
[`ToArray()`](https://docs.microsoft.com/dotnet/api/system.collections.queue.toarray)
copia todos os elementos da fila para um _array_ e devolve esse _array_.

Cria um programa em C# que apresente um menu ao utilizador com quatro opções:

1. Inserir _string_ na fila
2. Remover _string_ da fila, imprimindo a mesma no ecrã
3. Listar todas as _string_ existentes na fila
4. Sair

O menu deve ser apresentado em ciclo, e o programa só deve terminar quando o
utilizador selecionar a opção 4.

> [Soluções](../solucoes/03_poo/04.md)

---

5 - Considera uma classe chamada `Line` com os seguintes membros:

```cs
// Construtor que cria uma nova instância de Line com as coordenadas indicadas
public Line(double x1, double y1, double x2, double y2);

// Método que indica se esta linha cruza com a linha indicada no primeiro
// argumento
public bool Cross(Line otherLine);
```

Escreve um programa que solicite ao utilizador a informação necessária para
criar duas linhas e depois apresente no ecrã a indicação se as mesmas se
cruzam.

> [Soluções](../solucoes/03_poo/05.md)

---

6 - Cria uma classe chamada `NPC` com três variáveis do tipo `float` (_energy_,
_damage_ e _speed_) e uma variável do tipo `NPCType`, sendo este último uma
enumeração com três valores: `Minion`, `Soldier` e `Boss`. A classe deve ter
um construtor para inicializar estes quatro atributos, e os seguintes métodos:

* `TakeHit()` - Diminui a energia do NPC para metade.
* `Die()` - Mata o NPC, colocando energia e velocidade a zero.
* `Faster()` - Aumenta velocidade em 10%.
* `Slower()` - Diminui velocidade em 10%.
* `Hit()` - NPC desfere golpe e este método retorna a potência do golpe, que é
igual a _damage_ vezes 1, 10 ou 100 caso o `NPCType` seja `Minion`, `Soldier`
ou `Boss`, respetivamente.

Além da classe `NPC`, apresenta também o código da enumeração `NPCType`, tendo
em conta que esta pode facilitar as contas do método `Hit()`.

Apresenta também uma classe `Program` com um único método estático `Main()`
para testar a classe `NPC` e os seus métodos.

> [Soluções](../solucoes/03_poo/06.md)
---

7 - Cria uma classe chamada `CharChecker` com um único método de nome
`CharCheck()`. Este método recebe três argumentos: 1) uma _string_; 2) um
caráter `c`; e, 3) um inteiro `n`. O método retorna `true` caso a _string_
contenha o caráter `c` pelo menos `n` vezes seguidas.

Adiciona o método estático `Main()` à classe `CharChecker`. Este método deve: 1)
solicitar ao utilizador uma _string_; 2) solicitar ao utilizador o valor de
`c`; 3) solicitar ao utilizador o valor de `n`; 4) criar uma nova instância de
`CharChecker`; 5) invocar o respetivo método `CharCheck()` para verificar se o
`c` aparece mais de `n` vezes seguidas na _string_; e, 6) indicar no ecrã o
resultado.

> [Soluções](../solucoes/03_poo/07.md)

---

8 - Cria uma classe chamada `Checker` com um único método de nome `Check()`.
Este método recebe dois argumentos: 1) um _array_ bidimensional de `int`; e, 2)
um `int`. O método retorna `true` caso encontre uma linha (horizontal, vertical
ou diagonal) de quatro ou mais inteiros iguais ao 2º argumento, ou `false`
caso contrário.

Adiciona o método estático `Main()` à classe `Checker`. Este método deve: 1)
solicitar ao utilizador as dimensões do _array_; 2) solicitar ao utilizador os
valores do _array_; 3) solicitar ao utilizador o valor a procurar no
_array_; 4) criar uma nova instância de `Checker`; 5) invocar o respetivo
método `Check()` para verificar se o valor a procurar no _array_ aparece em
forma uma linha com comprimento igual ou maior a quatro; e, 6) indicar no ecrã
se essa linha existe ou não.

> [Soluções](../solucoes/03_poo/08.md)

---

9 - Nos dois exercícios anteriores faria sentido a respetiva classe e o seu
único método serem `static`? Porquê?

> [Soluções](../solucoes/03_poo/09.md)

---

10 - Cria uma classe chamada `Car` com três variáveis de instância, _speed_
(`float`), _weight_ (`float`) e _fuelType_ (enumeração `Fuel` com 4 valores
possíveis: `Gasoline`, `Diesel`, `LPG` e `Electric`). A classe deve ter ainda
uma variável de classe (estática) chamada _maxSpeed_ (`float`), com valor por
omissão igual a 220.0f. A classe deve ter um único construtor que aceita
argumentos para inicializar as variáveis  _weight_ e _fuelType_, inicializando
a variável _speed_ a zero. A classe deve ter os seguintes métodos:

* `Accelerate(float x)` - Aumenta a velocidade com o valor indicado na
  variável `x`, mas nunca acima de _maxSpeed_. Devolve a nova velocidade.
* `Break(float x)` - Diminui a velocidade com o valor indicado na variável `x`,
  mas nunca abaixo de zero. Devolve a nova velocidade.
* `GetSpeed()` - Retorna o valor atual da velocidade sem a alterar.
* `GetFuelType()` - Retorna o tipo de combustível.
* `GetWeight()` - Retorna o peso do carro.
* `GetMaxSpeed()` e `SetMaxSpeed()` - Métodos estáticos para obter e definir
  o valor da variável de classe `maxSpeed`.

Cria ainda uma classe chamada `TestCar` contendo um método estático `Main()`
para testar exaustivamente todos os métodos da classe `Car`.

> [Soluções](../solucoes/03_poo/10.md)

---

11 - Modifica todos os tipos criados no exercício anterior (`Car`, `Fuel` e
`TestCar`) de modo a que façam uso de propriedades e sintaxe de inicialização
de objetos com propriedades. Qual é a versão com menos código _boilerplate_?

> [Soluções](../solucoes/03_poo/11.md)

---

12 - Cria uma classe chamada `Dog`. Instâncias desta classe devem ter os
seguintes atributos:

* Peso (`double`)
* Altura (`double`)
* Cor (`string`)
* Saciação (`double` entre 0 e 1, que corresponde à percentagem de saciação)

Instâncias desta classe devem ter a seguinte funcionalidade:

* Comer (no máximo até estar cheio/saciado)
* Fazer necessidades (no mínimo até estar vazio/cheio de fome)
* Ladrar (deve ser impresso o tipo de ladrar)
* Correr (deve ser devolvida a velocidade, igual a saciação * 100 / peso)

A classe deve ser implementada com as variáveis de instância, propriedades,
construtores e métodos necessários para atingir estes requisitos, usando as
melhores práticas para o efeito. Dentro do possível as propriedades devem ser
públicas com valores por omissão, auto-implementadas e com `set` privado
(_read-only_). Todos os nomes usados devem estar em inglês.

Cria também uma classe `Program` com um método `Main()` estático para testar
todas as funcionalidades da classe `Dog`.

As classes `Dog` e `Program` devem ser completamente documentadas com
comentários XML em inglês.

Este enunciado é propositadamente vago e os alunos devem complementar o
exercício da forma que acharem melhor, desde de que vá ao encontro do que é
pedido.

> [Soluções](../solucoes/03_poo/12.md)

---

13 - Explica por palavras tuas o significado dos seguintes termos:

* Classe
* Objeto / instância
* Método
* Construtor
* Variável de instância
* Propriedade
* Variável de suporte
* Variável local
* _Overloading_
* Encapsulação

> [Soluções](../solucoes/03_poo/13.md)

---

14 - Cria uma classe estática chamada `Program` com um único método estático
`Main()`. Neste método devem ser solicitadas ao utilizador as coordenadas `x`,
`y` e `z` de um vetor 3D, devendo depois o método mostrar o comprimento do
vetor.

Para a resolução deste exercício é obrigatório usar um tipo anónimo, sem
variáveis intermédias, para guardar as coordenadas do vector.

> [Soluções](../solucoes/03_poo/14.md)

---

15 - As enumerações, tipo `enum`, são tipos de referência ou valor?

> [Soluções](../solucoes/03_poo/15.md)

---

16 - Indica duas das principais diferenças entre _structs_ e classes.

> [Soluções](../solucoes/03_poo/16.md)

---

17 - Em que parte da memória são colocadas as variáveis do tipo _struct_ quando
guardadas num _array_? Porquê?

> [Soluções](../solucoes/03_poo/17.md)

---

18 - Estuda, analisa e executa o projeto [18](03_poo/18). Considerando que as
_structs_ são tipos de valor, explica a razão de neste caso a alteração de
campos de uma _struct_ dentro de um método também se repercutir fora do método.

> [Soluções](../solucoes/03_poo/18.md)

---

19 - Explica porque razão as _structs_ não podem ter o valor `null`.

> [Soluções](../solucoes/03_poo/19.md)

---

20 - Explica o que são tipos imutáveis e quais são as vantagens dos mesmos. Dá
um exemplo (em código) de um tipo imutável.

> [Soluções](../solucoes/03_poo/20.md)

---

21 - Explica por palavras tuas o significado e/ou para que servem os seguintes
conceitos e _keywords_:

* Herança
* Classe base/superclasse
* Classe derivada/subclasse
* _Keyword_ `is`
* _Keyword_ `as`
* _Keyword_ `protected`
* _Keyword_ `sealed`

> [Soluções](../solucoes/03_poo/21.md)

---

22 - Considera a seguinte classe e indica, justificando, se a mesma é
imutável ou não.

```cs
public class Map
{
    public float Width { get; }
    public float Height { get; }
    public int NumberOfBosses { get; }
    protected ulong highScore;
    protected string name;

    public Map(float width, float height, int numberOfBosses, ulong highScore, string name)
    {
        Width = width;
        Height = height;
        NumberOfBosses = numberOfBosses;
        this.highScore = highScore;
        this.name = name;
    }
}
```

> [Soluções](../solucoes/03_poo/22.md)

---

<a name="ex23"></a>
23 - Considera o seguinte código:

```cs
public struct Bullet
{
    private float calibre;
    public float Calibre
    {
        get { return calibre; }
        set { if (value < 0.1f) calibre = 0.1f; else calibre = value; }
    }
}
public class Weapon
{
    public float Value { get; }
    public Weapon(float value) { Value = value; }
}
public class Gun : Weapon
{
    private Bullet[] bullets;
    public Gun(float value, int numBullets, float calibre) : base(value)
    {
        bullets = new Bullet[numBullets];
        for (int i = 0; i < numBullets; i++)
        {
            bullets[i] = new Bullet() { Calibre = calibre };
        }
    }
}
```

a) Escreve uma linha de código que: a) crie uma instância de `Gun` com valor
(`value`) 50.0 e três `Bullet`s de calibre 0.5; e, b) guarde essa instância
numa variável do tipo `Weapon`.

b) Adiciona uma propriedade à classe `Gun` chamada `NumberOfBullets`, só de
leitura, que retorne o número de `Bullet`s existentes numa instância de `Gun`.

> [Soluções](../solucoes/03_poo/23.md)

---

<a name="ex24"></a>
24 - Considera o seguinte código:

```cs
public struct Passenger
{
    private double weight;
    public double Weight
    {
        get { return weight; }
        set { if (value < 5) weight = 5; else weight = value; }
    }
}
public class Vehicle
{
    public double Value { get; }
    public Vehicle(double value) { Value = value; }
}
public class Car : Vehicle
{
    private Passenger[] passengers;
    public Car(double value, int numPassengers, float avgWeight) : base(value)
    {
        Random r = new Random();
        passengers = new Passenger[numPassengers];
        for (int i = 0; i < numPassengers; i++)
        {
            passengers[i] = new Passenger()
            {
                Weight = avgWeight + r.Next(-10, 10)
            };
        }
    }
}
```

a) Escreve uma linha de código que: a) crie uma instância de `Car` com valor
(`value`) 2550.0 e três `Passenger`s com peso médio (`avgWeight`) 70; e, b)
guarde essa instância numa variável do tipo `Vehicle`.

b) Adiciona um método à classe `Car` chamado `GetTotalWeight()` que retorne o
peso total dos passageiros numa instância de `Car`.

> [Soluções](../solucoes/03_poo/24.md)

---

<a name="ex25"></a>
25 - Cria uma nova solução em Visual Studio com as seguintes classes:

* Classe abstrata `Character` com:
  * Propriedade _read-only_ `Name` do tipo `string`
  * Método `Move()` abstrato, que retorna um `char` indicando a direção seguida
    (`'N'`, `'S'`, `'W'` ou `'E'`)
* Classe `NPC`, estende `Character`, com:
  * Método `Move()` sobreposto que retorna direção aleatória
* Classe `Player`, estende `Character`, com:
  * Método `Move()` sobreposto que retorna direção após solicitar a mesma ao
    jogador através das teclas *W*, *S*, *A* e *D*
* Classe `Program` com método `Main()` para testar as classes anteriores

> [Soluções](../solucoes/03_poo/25.md)

---

26 - Indica, justificando, se as seguintes afirmações são verdadeiras ou
falsas:

1. O polimorfismo permite que classes derivadas ofereçam implementações
   alternativas de métodos na classe base
2. A _keyword_ `override` indica que um método na subclasse é uma
   extensão/sobreposição de um método na superclasse
3. A _keyword_ `new` indica que um método na subclasse é uma
   extensão/sobreposição de um método na superclasse
4. Métodos `abstract` podem existir em classes não-`abstract`
5. Métodos não-`abstract` podem existir em classes `abstract`
6. Subclasses podem sobrepor métodos `virtual` da superclasse
7. Subclasses podem sobrepor métodos `abstract` da superclasse
8. Numa subclasse é possível sobrepor (`override`) um método não-`virtual` e
   não-`abstract` da superclasse

> [Soluções](../solucoes/03_poo/26.md)

---

27 - Responde às seguintes questões sobre interfaces e herança:

1. Qual a _keyword_ para declarar uma interface?
2. Qual é a visibilidade dos membros de uma interface?
3. Uma classe que implementa uma interface tem de fornecer implementações de
   todos os membros da interface?
4. Uma classe que implementa uma interface pode ter membros que não estão
   definidos na interface?
5. Uma classe pode estender mais do que uma classe base?
6. Uma classe pode implementar mais do que uma interface?
7. As _structs_ podem implementar interfaces?

> [Soluções](../solucoes/03_poo/27.md)

---

28 - Qual a diferença prática entre as _keywords_ `override` e `new` na
declaração de um método? Dá um exemplo.
_Nota: se o exemplo for retirado de algum lado não te esqueças de incluir a
referência._

> [Soluções](../solucoes/03_poo/28.md)

---

29 - Escreve o código de uma classe que contenha:

* Uma variável de instância só de leitura
* Uma propriedade (de instância) só de leitura
* Uma variável de classe só de leitura
* Uma propriedade de classe só de leitura
* Um construtor que inicialize as variáveis/propriedades relevantes

A classe deve ser adequadamente comentada, com explicações ou descrições sobre
o que cada linha de código faz ou representa.

> [Soluções](../solucoes/03_poo/29.md)

---

30 - Considera um projeto com as seguintes classes:

```cs
public class Tree
{
    private string type;
    private float height;

    public Tree(string type, float height)
    {
        this.type = type;
        this.height = height;
    }
}
```

```cs
using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine(new Tree("Pinetree", 5.5f));
    }
}
```

Responde às seguintes questões:

1. O que é impresso quando o projeto é executado?
2. O que é necessário fazer para que seja impresso um valor personalizado
   quando "imprimimos" uma instância de determinado tipo?
3. Adiciona o código necessário à classe `Tree` de modo a que, ao ser impressa
   uma instância da mesma, seja possível observar o tipo e a altura da árvore.

> [Soluções](../solucoes/03_poo/30.md)

---

<a name="ex31"></a>
31 - Considera o seguinte código:

```cs
public abstract class GameObject
{
    public float X { get; protected set; }
    public float Y { get; protected set; }
    public abstract int Priority();
    public virtual bool IsActive() { return true; }
}
```

```cs
public class Trap : GameObject
{
    public override int Priority() { return int.MaxValue; }
    public void DisableTrap() { Console.WriteLine("Trap is now disabled."); }
}
```

```cs
public interface ITaggable
{
    string Tag { get; set; }
}
```

Responde às seguintes questões (neste exercício aceitam-se soluções separadas
a cada uma destas questões):

1. Apresenta o código da classe `PowerUp` que estende `GameObject` e implementa
   a interface `ITaggable`. A prioridade deve ser igual ao comprimento da
   *tag*. Deves sobrepor o método `IsActive()` de modo a retorne `false` se a
   *tag* for `null` ou com comprimento igual a zero, e `true` caso contrário.
2. Sobrepõe o método `ToString()` na classe `PowerUp` de modo a que devolva uma
   *string* que inclua `X` , `Y` e `Tag`. Os números reais devem aparecer com 2
   dígitos significativos.
3. Se `armorPack` for uma instância da classe `PowerUp`, qual a instrução que
   define o valor da sua *tag* como "Armor+75"?
4. Indica, justificando, quais das seguintes instruções são válidas e quais são
   inválidas. As instruções são independentes umas das outras, e naquelas que
   não implicam criação de objetos presume-se que o(s) objeto(s) em questão já
   foram instanciados. Assume que todas as instruções ocorrem fora das classes
   discutidas até ao momento.

```cs
// Instrução 1
PowerUp pu = new PowerUp();
```

```cs
// Instrução 2
GameObject go = new GameObject();
```

```cs
// Instrução 3
Trap t = new Trap();
```

```cs
// Instrução 4
ITaggable it = new ITaggable();
```

```cs
// Instrução 5
go.DisableTrap(); // go é uma variável do tipo GameObject
```

```cs
// Instrução 6
PowerUp armorPack = new GameObject();
```

```cs
// Instrução 7
int p = gobj.DisableTrap; // gobj é do tipo Trap
```

```cs
// Instrução 8
Console.WriteLine($"{trap.Tag}"); // trap é uma instância de Trap
```

```cs
// Instrução 9
GameObject go = new Trap();
```

```cs
// Instrução 10
GameObject go = new PowerUp();
```

```cs
// Instrução 11
Console.WriteLine($"{pup.Priority()}"); // pup é uma instância de PowerUp
```

> [Soluções](../solucoes/03_poo/31.md)

---

32 - Quais as diferenças entre as
[coleções não-genéricas](https://docs.microsoft.com/dotnet/api/system.collections)
e as
[coleções genéricas](https://docs.microsoft.com/dotnet/api/system.collections.generic)
no C#? Quais as vantagens destas últimas?

> [Soluções](../solucoes/03_poo/32.md)

---

33 - O C# providencia um conjunto bastante completo de
[coleções genéricas](https://docs.microsoft.com/dotnet/api/system.collections.generic).
Algumas das mais usadas são as que se seguem:

* [List&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1)
* [Queue&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.queue-1)
* [Stack&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.stack-1)
* [HashSet&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.hashset-1)
* [Dictionary&lt;K,V&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)

Responde às seguintes questões:

1. Qual a interface genérica comum a todas estas coleções? Que comportamento
   ficam as classes obrigadas a ter devido a implementarem essa interface?
2. Explica sucintamente como estas coleções funcionam e dá exemplos onde cada
   uma seja especialmente útil.
3. Além das coleções mencionadas, existem mais coleções genéricas no
  _namespace_
  [System.Collections.Generic](https://docs.microsoft.com/dotnet/api/system.collections.generic).
  Dá o exemplo de uma, explica sucintamente como funciona e dá um exemplo onde
  a mesma possa ser especialmente útil.

> [Soluções](../solucoes/03_poo/33.md)

---

34 - Estás a desenvolver um jogo, e tanto o jogador como os NPCs, representados
de forma abstrata pela classe `GameCharacter`, transportam itens do tipo
`IGameItem`. Os itens de cada `GameCharacter` estão guardados numa coleção
genérica do tipo
[HashSet&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.hashset-1),
representada pela variável de instância `items`. Alguns destes itens podem
implementar a interface `IBurnable`, representada pelo seguinte código:

```cs
public interface IBurnable
{
    float PotentialEnergy { get; }
    void Burn();
}
```

Escreve um método chamado `GetPotentialEnergyOfBurnableItems()`, pertencente à
classe `GameCharacter`, que devolve a soma da energia potencial de todos os
itens queimáveis transportados pelo jogador ou por um NPC.

> [Soluções](../solucoes/03_poo/34.md)

---

35 - Considera o seguinte tipo:

```cs
public struct GameMap
{
    private float topScore;
    private int gamesPlayed;
    private int gamesWon;

    public string Name { get; }
    public string Filename { get; }
    public float SuccessRate
    {
        get {
            if (gamesPlayed == 0)
                return 0f;
            else
                return gamesWon / (float) gamesPlayed;
        }
    }
    public float TopScore {
        get
        {
            return topScore;
        }
        set
        {
            if (value > topScore)
            {
                topScore = value;
            }
        }
    }

    public GameMap(string name, string filename)
    {
        Name = name;
        Filename = filename;
        gamesPlayed = 0;
        gamesWon = 0;
        topScore = 0;
    }

    public void GamePlayed(bool won)
    {
        gamesPlayed++;
        if (won)
        {
            gamesWon++;
        }
    }
}
```

Responde às seguintes questões relativas ao tipo apresentado:

1. O tipo apresentado é de valor ou referência? Justifica a tua resposta.
2. Identifica as variáveis de instância e explica o seu propósito.
3. Identifica as propriedades auto-implementadas.
4. Identifica as propriedades só de leitura.
5. Identifica os construtores.
6. Identifica os métodos de instância.
7. Escreve a documentação XML apropriada para a classe e respetivos membros.
8. Escreve um método `static` que recebe um iterável de `GameMap` e imprime
   uma tabela bem formatada com informação sobre os mesmos, tal como
   representado na seguinte figura:

```
Name              Filename      Sucess Rate    Top Score
--------------------------------------------------------
Hell              hell.map           30.2 %     5069.921
Beach             beach.map          44.0 %     2231.887
Valley            valley.map         72.1 %      131.090
Work              work.map           44.4 %     2334.114
School            school.map         11.5 %       40.587
Graveyard         graveyard.map      69.8 %     1631.103
Mars              mars.map           92.1 %     2257.178
```

> [Soluções](../solucoes/03_poo/35.md)

---

36 - Cria uma `struct` imutável, de nome `Duration`, que representa um
intervalo de tempo, tendo as seguintes propriedades: `Seconds`, `Minutes`,
`Hours`, `Days`, `Weeks` e `Years`. Cria também um programa para testar
diferentes instâncias desta `struct`, e responde às seguintes questões:

1. Quais são as vantagens desta `struct` ser imutável?
2. Podemos usar a sintaxe de inicialização de objetos com propriedades para
   inicializar instâncias desta `struct`? Porquê?

> [Soluções](../solucoes/03_poo/36.md)

---

<a name="ex37"></a>
37 - Considera a seguinte classe:

```cs
public abstract class NPC
{
    public float HP { get; protected set; }

    public NPC(float hp)
    {
        HP = hp;
    }

    public void PlayTurn()
    {
        if (FindEnemies())
        {
            AttackEnemies();
        }
        if (FindFood())
        {
            EatFood();
        }
        Move();
    }

    protected abstract bool FindFood();
    protected abstract bool FindEnemies();
    protected abstract void EatFood();
    protected abstract void AttackEnemies();

    protected virtual void Move()
    {
        Console.WriteLine(this.GetType() + " has moved!");
    }
}
```

Responde às seguintes questões:

1. É possível instanciar esta classe? Porquê?
2. É possível estender esta classe? Porquê?
3. Que métodos desta classe podem ser sobrepostos (_overridden_)? Porquê?
4. Que métodos desta classe **não** podem ser sobrepostos (_overridden_)?
   Porquê?

Este exercício continua no [problema 8](04_uml.md#ex8) de UML e design de
classes.

> [Soluções](../solucoes/03_poo/37.md)

---

38 - Considera a seguinte classe:

```cs
public class Texture
{
    private string textureFile;

    public Texture(string textureFile)
    {
        this.textureFile = textureFile;
    }
}
```

Cria uma classe chamada `PNGTexture` cujo construtor aceita um nome de
ficheiro, invocando o construtor da classe base com o nome de ficheiro
concatenado com a _string_ ".png".

> [Soluções](../solucoes/03_poo/38.md)

---

39 - Quais são os requisitos para que uma classe possa ser instanciada usando
a sintaxe de inicialização de coleções?

> [Soluções](../solucoes/03_poo/39.md)

---

40 - Quais são os requisitos para que uma instância de uma classe possa ser
usada num `foreach` como fornecedor de itens?

> [Soluções](../solucoes/03_poo/40.md)

---

41 - Considera a seguinte classe:

```cs
public class Weapon
{
    public float AttackPower { get; }
    public float Durability { get; }

    public Weapon(float attackPower, float durability)
    {
        AttackPower = attackPower;
        Durability = durability;
    }
}
```

Assume que temos uma lista de armas, ou seja, uma variável do tipo
`List<Weapon>` e responde às seguintes questões:

1. Faz as alterações necessárias à classe `Weapon` de modo a que quando
invocarmos o método
[`Sort`](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1.sort)
(ou mais concretamente, o seu
[_overload_ sem parâmetros](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1.sort#System_Collections_Generic_List_1_Sort)) da classe `List<T>`, as instâncias de `Weapon` fiquem ordenadas por
`AttackPower` decrescente. _Sugestão:_ a classe `Weapon` tem de implementar
[`IComparable<T>`](https://docs.microsoft.com/pt-pt/dotnet/api/system.icomparable-1).
2. Cria uma classe `Program` com um método `Main()` para testar uma lista de
várias instâncias de `Weapon`, nomeadamente a sua ordenação por `AttackPower`
decrescente usando o método
[`Sort()`](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1.sort#System_Collections_Generic_List_1_Sort)
sem parâmetros.
3. O método
[`Sort`](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1.sort)
da classe `List<T>` tem vários _overloads_. Um deles,
[`Sort(IComparer<T>)`](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1.sort#System_Collections_Generic_List_1_Sort_System_Collections_Generic_IComparer__0__),
permite ordenar a lista usando o critério de ordenação definido numa classe
extra. Tal classe, como indicado na assinatura do método, tem de implementar a
interface
[`IComparer<T>`](https://docs.microsoft.com/dotnet/api/system.collections.generic.icomparer-1).
Cria uma classe deste tipo cujo critério de ordenação seja `Durability`
crescente.
4. Adiciona ao método `Main()` da classe `Program` um teste à ordenação
por `Durability` crescente usando o método
[`Sort(IComparer<T>)`](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1.sort#System_Collections_Generic_List_1_Sort_System_Collections_Generic_IComparer__0__)
e a classe desenvolvida no ponto anterior.

> [Soluções](../solucoes/03_poo/41.md)

---

43 - Considera a seguinte classe:

```cs
public class SpaceFleet
{
    private Spaceship[] spaceships;

    public SpaceFleet() { /* Código do construtor aqui */ }

    public Spaceship GetSpaceship(int i)
    {
        if (i < spaceships.Length)
            return spaceships[i];
        else
            return null;
    }

    public bool SetSpaceship(int i, Spaceship spaceship)
    {
        if (i < spaceships.Length && spaceships[i] == null)
        {
            spaceships[i] = spaceship;
            return true;
        }
        return false;
    }
}

```

1. O tipo `Spaceship` é de referência (classe) ou de valor (`struct` ou
   `enum`)? Porquê?
2. A classe está a usar métodos _getter_ e _setter_. Não seria preferível usar
   uma propriedade? Justifica a tua resposta.

> [Soluções](../solucoes/03_poo/43.md)

---

44 - Considera a seguinte classe:

```cs
public class Enemy
{
    public static int NumberOfEnemies { get; private set; }
    public int Health { get; set; }

    public Enemy(int health)
    {
        NumberOfEnemies++;
        Health = health;
    }

    public void Die()
    {
        NumberOfEnemies--;
        Health = 0;
    }
}
```

Responde às seguintes questões:

1. Considera que `monster` é uma instância de `Enemy`. Escreve duas linhas de
   código, uma para imprimir no ecrã a propriedade `Health` da instância,
   outra para imprimir a propriedade `NumberOfEnemies` da classe.
2. Porque razão faz sentido a propriedade `NumberOfEnemies` ser `static`?
3. De que parte do código pode ser alterado o valor da propriedade
   `NumberOfEnemies`?

> [Soluções](../solucoes/03_poo/44.md)

---

45 - Considera o seguinte código:

```cs
public class Power
{
    public string Description { get; set; }
    public int Range { get; set; }
}

public class PlayerClass
{
    private int health;
    private int shield;
    private List<Power> powers;

    public PlayerClass(int health, int shield)
    {
        this.health = health;
        this.shield = shield;
        powers = new List<Power>();
    }

    public void AddPower(Power p)
    {
        powers.Add(p);
    }
}

public struct PlayerStruct
{
    private int health;
    private int shield;
    private List<Power> powers;

    public PlayerStruct(int health, int shield)
    {
        this.health = health;
        this.shield = shield;
        powers = new List<Power>();
    }

    public void AddPower(Power p)
    {
        powers.Add(p);
    }
}
```

Pretende-se que os tipos `PlayerClass` e `PlayerStruct` implementem a interface
[`ICloneable`](https://docs.microsoft.com/dotnet/api/system.icloneable), de
modo a que uma chamada ao respetivo método
[`IClone()`](https://docs.microsoft.com/dotnet/api/system.icloneable.clone)
devolva uma cópia profunda da instância em questão. Uma cópia profunda consiste
numa nova instância cujos campos têm o mesmo valor do objeto original. Se algum
dos campos for um tipo de referência, a instância associada deve também ser
clonada da mesma forma, e por ai fora. Reescreve o código dos tipos
`PlayerClass` e `PlayerStruct` de modo a que implementem
[`ICloneable`](https://docs.microsoft.com/dotnet/api/system.icloneable) segundo
estas especificações.

> [Soluções](../solucoes/03_poo/45.md)

---

46 - Considera a seguinte classe:

```cs
public abstract class GameItem
{
    public readonly string name;
    public readonly string description;

    public GameItem(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
}
```

Responde às seguintes questões:

1. Implementa a classe `Sword` que estende `GameItem`, tendo adicionalmente
   como estado os campos `length`, `typeOfMetal` e `condition`. O primeiro
   pode ser representado com um número real, e os outros têm um tipo próprio,
   `TypeOfMetal` e `WeaponCondition`, respetivamente. O construtor de `Sword`
   aceita 5 parâmetros, que são usados para inicializar todos os campos da
   classe. No entanto, os campos herdados de `GameItem` devem ser
   inicializados pelo respetivo construtor.
2. Cria as enumerações `TypeOfMetal` e `WeaponCondition` com valores à tua
   escolha mas de modo a que façam sentido no contexto do problema.
3. Dá um exemplo em código de como podemos criar uma instância de `Sword`.
4. Normalmente as variáveis de instância têm visibilidade privada de modo a
   não comprometer a encapsulação. No entanto não é esse o caso no código
   apresentado. Porque razão a quebra de encapsulação não é tão grave neste
   caso?
5. Podemos instanciar diretamente `GameItem`? Porquê?

> [Soluções](../solucoes/03_poo/46.md)

---

47 - Considera a seguinte interface:

```cs
public interface ILightSource
{
    double Illuminance { get; }
}
```

Cria a classe `Star` que implementa as interfaces `ILightSource` e
[`IComparable<T>`](https://docs.microsoft.com/dotnet/api/system.icomparable-1).
A propriedade `Illuminance` da classe `Star` é obtida com a seguinte fórmula:

_I = d \* A \* T<sup>4</sub>_

na qual _d_ é a
[constante de Stefan–Boltzmann](https://en.wikipedia.org/wiki/Stefan%E2%80%93Boltzmann_constant)
(com um valor de 5.670 x 10<sup>−8</sup>), _A_ é a área de superfície da
estrela e _T_ é a temperatura média da estrela. O construtor de `Star` aceita
como parâmetros iniciais _A_ e _T_, que não mudam durante o tempo de vida da
estrela.

O critério de ordenação quando várias instâncias de `Star` são ordenadas segue
a área de superfície (decrescente, da maior para a mais pequena), e em caso de
estrelas com a mesma área, a temperatura serve como critério de desempate
(também decrescente).

> [Soluções](../solucoes/03_poo/47.md)

---

48 - A API do C# contém uma coleção especializada na manipulação de booleanos
(zeros e uns). Faz uma pesquisa para descobrires que coleção é essa e realça
algumas das suas principais funcionalidades, nomeadamente vantagens sobre o uso
de um simples _array_ de booleanos.

> [Soluções](../solucoes/03_poo/48.md)

---

49 - Dá três exemplos de coleções genéricas do C# que implementem
[`ICollection<T>`](https://docs.microsoft.com/dotnet/api/system.collections.generic.icollection-1).
Qual é ou quais são as funcionalidades que as coleções que implementam esta
interface são obrigadas a ter?

> [Soluções](../solucoes/03_poo/49.md)

---

50 - Considera as interfaces
[`IList<T>`](https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1)
e
[`IDictionary<TKey,TValue>`](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2)
.

1. Para cada uma das interfaces, dá um exemplo de uma coleção do C# que a
   implemente.
2. Qual é ou quais são as funcionalidades que as coleções que implementam
   estas interfaces são obrigadas a ter?

> [Soluções](../solucoes/03_poo/50.md)

---

51 - Indica três coleções da API do C# que suportem sintaxe de inicialização de
coleções e dá um exemplo de uso para cada uma delas.

> [Soluções](../solucoes//03_poo/51.md)

---

52 -  Considera os tipos `MonsterType` e `Monster`, definidos pelo seguinte
código:

```cs
enum MonsterType { Troll, Ogre, Elf, Demon }
```

```cs
class Monster
{
    public const double MaxHealth = 100;
    public const int MaxStrength = 200;
    public MonsterType Type { get; set; }
    public double Health { get; set; }
    public int Strength { get; set; }
}
```

Responde às seguintes questões:

1. Existe algum campo `static` (de classe) na classe `Monster`?
2. Adiciona o método iterável `CreateRandomMonsters()` à classe `Monster`, que
   recebe um inteiro _n_ indicando quantos monstros devem ser criados, e que
   devolve um `IEnumerable<Monster>` de _n_ monstros com campos inicializados
   aleatoriamente (dentro dos limites especificados nos tipos).
3. O método `CreateRandomMonsters()` deve ser `static`? Justifica a tua
   resposta.
4. Faz _override_ do método `ToString()` na classe `Monster` de modo a que o
   mesmo devolva uma _string_ indicando, de forma bem formatada, as várias
   propriedades do monstro. Por exemplo, a propriedade `Health` não deve ter
   mais de duas casas decimais.
5. Cria a classe `Program` com um método `Main` para testares a criação de 20
   monstros aleatórios com o método `CreateRandomMonsters()`, imprimindo no
   ecrã a _string_ devolvida pelo método `ToString()` para cada monstro.

> [Soluções](../solucoes/03_poo/52.md)

---

53 - Escreve um programa que comece por solicitar ao utilizador dois conjuntos
de números inteiros, _conjunto 1_ e _conjunto 2_. O programa deve depois
apresentar os resultados das seguintes operações:

1. **União** - Operação de união entre os dois conjuntos, ou seja, elementos
   presentes no _conjunto 1_, no _conjunto 2_, e em ambos os conjuntos.
2. **Interseção** - Operação de interseção entre os dois conjuntos, ou seja,
   elementos simultaneamente presentes no _conjunto 1_ e no _conjunto 2_.
3. **Diferença** -  Operação de diferença entre o  _conjunto 1_ e o _conjunto
   2_, ou seja, elementos do _conjunto 1_ exceto aqueles que também existam no
   _conjunto 2_.
4. **Diferença simétrica** - Operação de diferença simétrica entre o _conjunto
   1_ e o _conjunto 2_, ou seja, elementos que existam ou no _conjunto 1_ ou
   no _conjunto 2_, mas não em ambos os conjuntos.
5. **Subconjunto** - Se o _conjunto 1_ é um subconjunto do _conjunto 2_, ou
   seja, se todos os elementos do _conjunto 1_ existem também no  _conjunto
   2_.
6. **Superconjunto** - Se o _conjunto 1_ é um superconjunto do _conjunto 2_,
   ou seja, se o _conjunto 1_ contem todos os elementos do  _conjunto 2_.

Os resultados das operações 1 a 4 devem aparecer de forma ordenada, e as
operações devem ser independentes umas das outras, partindo sempre dos
conjuntos 1 e 2 originais.

Este problema deve ser resolvido com recurso direto às funcionalidades
oferecidas pelas coleções do C#.

> [Soluções](../solucoes/03_poo/53.md)

---

54 - Em alguns casos os dicionários podem ser usados para fins de
[_caching_](https://en.wikipedia.org/wiki/Cache_%28computing%29), ou seja, para
guardar resultados obtidos recentemente. Escreve um programa que leia a lista
de jogos disponível [aqui](https://pastebin.com/raw/EuxZMbWT) para um _array_
de _strings_, e que solicite ao utilizador (em ciclo infinito) uma frase, que
será comparada com todos os jogos no _array_. Para existir um _match_, basta
que uma _string_ que representa o nome de um jogo
[contenha](https://docs.microsoft.com/dotnet/api/system.string.contains) a
frase inserida pelo utilizador. A procura deve ser independente de maiúsculas e
minúsculas. Após a procura, o programa deve indicar quantos jogos encontrou e
quanto tempo demorou a fazer a procura. O seguinte código apresenta um
_template_ da solução:

```cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        // Abrir ficheiro com nomes de jogos e colocar num array de strings
        string[] games = File.ReadAllLines("videogames.txt");

        // Ciclo de procuras, infinito
        while (true)
        {
            // Cronómetro
            Stopwatch stopwatch;
            // String a procurar
            string searchString;
            // Resultados da procura, têm de ser enumeráveis e contáveis
            ICollection<string> results;

            // Solicitar string de procura, transformar em minúsculas para
            // facilitar comparação mais à frente
            Console.Write("Search for? ");
            searchString = Console.ReadLine().ToLower();

            // Começar contagem do tempo
            stopwatch = Stopwatch.StartNew();

            // Realizar procura aqui e colocar resultados na variável results,
            // que provavelmente será uma lista. A procura deve:
            // - Ignorar strings vazias ou que comecem com cardinal #
            //   (que representa um comentário no ficheiro videogames.txt)
            // - Ser independente de maiúsculas e minúsculas

            // Parar o cronómetro
            stopwatch.Stop();

            // Mostrar resultados da procura
            Console.WriteLine($"Time to find {results.Count} games was" +
                $"{stopwatch.Elapsed}");

            // Opcionalmente podemos mostrar alguns ou todos os jogos
            // encontrados para fins de debugging
        }
    }
}
```

Cada vez que é feita uma procura é necessário percorrer todo o _array_ de jogos
novamente. No entanto a tua solução deve primeiro verificar se a procura já foi
feita e existe em _cache_ (i.e., num dicionário criado para o efeito). Caso a
procura exista em _cache_, serão devolvidos os resultados previamente
guardados. Caso contrário é percorrido novamente todo o _array_ de jogos.
Compara o tempo da procura no _array_ para novas procuras com o tempo de
procura no dicionário para pesquisas previamente efetuadas.

_Sugestão_: O dicionário deve ser do tipo `Dictionary<string,
ICollection<string>>`, em que a chave representa a frase de procura e o valor
representa os resultados dessa mesma procura.

> [Soluções](../solucoes/03_poo/54.md)

---

55 - Considera o tipos `LootType` e `Loot`:

```cs
public enum LootType { Health, Ammo, Shield, Weapon, Collectible }
```

```cs
public class Loot
{
    public LootType WhatKindOfLootAmI { get; set; }
    public string Description { get; set; }
    public ulong Value { get; set; }
}
```

1. Faz _override_ dos métodos
   [`GetHashCode()`](https://docs.microsoft.com/dotnet/api/system.object.gethashcode)
   e [`Equals()`](https://docs.microsoft.com/dotnet/api/system.object.equals)
   de modo a que um _loot_ seja considerado único no jogo se tiver o mesmo
   tipo, nome e valor. _Sugestão_: Uma forma rápida de obter um _hash code_
   para um dado tipo consiste em realizar a operação XOR no _hash code_ dos
   seus diferentes campos.
2. Testa a tua solução colocando vários objetos do tipo `Loot` num conjunto,
   repetindo propositadamente os campos de duas instâncias diferentes.
3. Se o tipo `Loot` fosse uma `struct` qual seria o comportamento por
   omissão relativamente à igualdade de instâncias? Era necessário ter feito
   os _overrides_ na primeira alínea do exercício?

> [Soluções](../solucoes/03_poo/55.md)

---

56 - Considera a seguinte classe:

```cs
public class Problem
{
    public static void Main()
    {
        // Um array de objetos de diferentes tipos
        object[] stuff = { "ola", 1, 2.3, 5f, 12L, 4UL, 5U, "bye", 4, 9 };
        // Imprimir apenas objetos do tipo int
        foreach (int i in Filter<int>(stuff))
        {
            Console.WriteLine("int = " + i);
        }
        // Imprimir apenas objetos do tipo float
        foreach (float f in Filter<float>(stuff))
        {
            Console.WriteLine("float = " + f);
        }
    }
}
```

Escreve e adiciona o método `Filter()` à classe `Problem` de modo a que o
código no `Main()` faça sentido e funcione.

> [Soluções](../solucoes/03_poo/56.md)

---

57 - Escreve um método `static` que inicialize e devolva uma
[lista genérica](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1)
contendo _n_ cópias de um valor passado como parâmetro e tipo especificado como
argumento genérico.

> [Soluções](../solucoes/03_poo/57.md)

---

58 - Quais são os requisitos para que uma instância de uma classe possa ser
usada num `foreach` como fornecedor de itens?

> [Soluções](../solucoes/03_poo/58.md)

---

59 - Numa classe ou método genérico como podemos obrigar a que o tipo genérico
tenha um construtor vazio?

> [Soluções](../solucoes/03_poo/59.md)

---

60 - Numa classe ou método genérico como podemos obrigar a que o tipo genérico
seja um tipo de referência?

> [Soluções](../solucoes/03_poo/60.md)

---

61 - Numa classe ou método genérico como podemos inicializar o tipo genérico
com o seu valor por omissão (equivalente a zero ou `null`)?

> [Soluções](../solucoes/03_poo/61.md)

---

62 - De modo a que o seguinte código passe a funcionar é necessário adicionar
algumas linhas antes do mesmo. Quais são?

```cs
class Program
{
    public static void Main()
    {
        float number;
        WriteLine("Escreve um número: ");
        number = ToSingle(ReadLine());
        WriteLine("O coseno desse número é {0:f3}", Cos(number));
    }
}
```

> [Soluções](../solucoes/03_poo/62.md)

---

63 - O método [`Next`](https://docs.microsoft.com/dotnet/api/system.random.next)
da classe [`Random`](https://docs.microsoft.com/dotnet/api/system.random) tem
vários _overloads_. Explica o que é um _overload_ e descreve as diferenças
entre os vários _overloads_ do método indicado.

> [Soluções](../solucoes/03_poo/63.md)

---

64 - Existe uma class `Random` tanto na API do C# como na API do Unity, que
podem respetivamente ser importadas com os seguintes `using`:

```cs
using System;
using UnityEngine;
```

Responde às seguintes questões:

1. Como podemos diferenciar, no nosso código, entre o
   [`Random`](https://docs.microsoft.com/dotnet/api/system.random) do C# e o
   [`Random`](https://docs.unity3d.com/ScriptReference/Random.html) do Unity?
2. Qual a principal diferença entre as duas classes, do ponto de vista de
   instanciação e invocação dos métodos que produzem números aleatórios?

> [Soluções](../solucoes/03_poo/64.md)

---

65 - Considera a classe `static`
[`Input`](https://docs.unity3d.com/ScriptReference/Input.html) do Unity.
Responde às seguintes questões:

1. O que é necessário para que uma classe seja `static`?
2. Porque razão faz sentido a classe
   [`Input`](https://docs.unity3d.com/ScriptReference/Input.html) ser
   `static`?
3. O que é necessário fazer para usarmos os métodos e propriedades da classe
   [`Input`](https://docs.unity3d.com/ScriptReference/Input.html) diretamente
   no nosso código, por exemplo, escrevermos `GetButton()` em vez de
   `Input.GetButton()`?
4. Quais são os perigos de usar a abordagem indicada na pergunta anterior.
5. Identifica mais duas classes `static` na
   [API do Unity](https://docs.unity3d.com/ScriptReference/index.html).
   Discute se faz sentido essas classes serem `static`.

> [Soluções](../solucoes/03_poo/65.md)

---

66 - Considera o seguinte código, altamente abstrato:

```cs
public interface IFighter
{
    void Fight();
}

public abstract class DarkSideFighter : IFighter
{
    public abstract void Fight();
}

public abstract class GoodGuyFighter : IFighter
{
    public abstract void Fight();
}

public abstract class FighterFactory
{
    protected abstract DarkSideFighter CreateDarkSideFighter();
    protected abstract GoodGuyFighter CreateGoodGuyFighter();
}
```

1. Adiciona um método concreto à classe `FighterFactory` que não aceite
   parâmetros e devolva uma instância de `DarkSideFighter` e outra de
   `GoodGuyFighter`, devendo para o efeito invocar os respetivos métodos
   `Create...Fighter()`.
2. Desenha o diagrama UML de classes do código.
3. Este código corresponde a um _design pattern_ muito comum. Faz uma pesquisa
   e tenta descobrir qual.
4. Considera que `myFighter` é um objeto cuja classe concreta (que
   desconheces) implementa `IFighter`. Identifica o polimorfismo na seguinte
   instrução: `myFighter.Fight();`.

Neste exercício aceitam-se soluções separadas para cada uma das alíneas.

> [Soluções](../solucoes/03_poo/66.md)

---

67 - Escreve um método `static` que inicialize e devolva um
[enumerável genérico](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1)
contendo _n_ cópias de um valor passado como parâmetro e tipo especificado como
argumento genérico.

> [Soluções](../solucoes/03_poo/67.md)

---

68 - Cria a classe genérica `AwesomeList<T>` que estende
[`List<T>`](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1)
e faz `override` do método `ToString()` de modo que a devolva uma _string_ que
indique o número de elementos na lista bem como o tipo desses elementos.

_Nota:_ pode ser necessário recorrer ao operador
[`typeof`](https://docs.microsoft.com/dotnet/csharp/language-reference/keywords/typeof)
para obter o tipo de `T`.

> [Soluções](../solucoes/03_poo/68.md)

---

69 - Considera a seguinte classe:

```cs
using System.Collections;
using System.Collections.Generic;

public class BasketballTeam : IEnumerable<string>
{
    public string Guard { get; set; }
    public string ShootingGuard { get; set; }
    public string SmallForward { get; set; }
    public string PowerForward { get; set; }
    public string Center { get; set; }

    public IEnumerator<string> GetEnumerator()
    {
        yield return Guard;
        yield return ShootingGuard;
        yield return SmallForward;
        yield return PowerForward;
        yield return Center;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
```

1. Cria uma classe `Program` com um método `Main` para testar a classe
   apresentada. Mais concretamente, no método `Main` deves: a) criar uma
   instância de `BasketballTeam` usando a
   [sintaxe de inicialização de objectos com propriedades](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers);
   e, b) imprimir no ecrã o nome de todos os elementos da equipa usando o
   facto da classe `BasketballTeam` ser iterável.
2. Supõe que o C# não tem a declaração `yield return`. Reescreve o método
   `GetEnumerator` tendo em conta essa limitação.
3. Quais são as vantagens óbvias do uso de `yield return` relativamente à
   forma como reescreveste o código na alínea anterior?

> [Soluções](../solucoes/03_poo/69.md)

---

70 - Escreve um método `static` que troque o valor de duas variáveis de entrada
cujo tipo é definido em tempo de execução (ou seja, por quem invoca o método).

> [Soluções](../solucoes/03_poo/70.md)

---

71 - Cria uma classe `IntList` que estende `List<int>`, adicionando três versões
de um método que retorne o valor mínimo (`int`), o valor máximo (`int`) e o
valor médio (`float`) referentes aos inteiros contidos na lista. Cada versão do
método deve retornar estes valores de forma diferente: 1) usando parâmetros de
saída (`out`); 2) usando uma classe/_struct_ específica; e, 3) usando tuplos. A
segunda forma pressupõe a criação de uma classe ou _struct_ extra; neste caso
podem criar uma classe/_struct_ interna, ou seja, dentro da classe `IntList`.
Sobrepõe ainda o método `ToString()` de modo a que a _string_ devolvida indique
quantos elementos tem a lista, bem como os valores mínimo, máximo e médio
contidos na mesma.

> [Soluções](../solucoes/03_poo/71.md)

---

72 - Cria uma classe chamada `HighScoreManager`, que contém internamente uma
coleção com um máximo de 10 `Tuple<string, float>`, cada um representando o
nome de um jogador e o respetivo _score_. Além da coleção referida, a classe
deve ainda conter:

* Um construtor, que aceita opcionalmente um nome de ficheiro (deve existir
  um nome por omissão), e:
  * Caso o ficheiro não exista, inicializa a coleção sem elementos.
  * Caso o ficheiro exista, abre-o e inicializa a coleção de modo a que
    contenha os nomes e _scores_ especificados no ficheiro.
  * Caso o ficheiro exista, mas tenha um formato inválido, lançar uma excepção
    do tipo `InvalidOperationException`.
* Um método `AddScore(string name, float score)`, que adiciona um novo
  `Tuple<string, float>` à coleção. Se o número de _scores_ ultrapassar 10, o
  tuplo contendo o menor _score_ deve ser removido.
* Um método `Save()`, que guarda os _scores_ no ficheiro especificado no
  construtor.
* Um método `ToString()`, que devolve uma _string_ contendo uma tabela
  devidamente formatada com todos os nomes e _scores_, do mais alto ao mais
  baixo.
* Um método iterável `GetScores()` que retorna de forma ordenada (do _score_
  mais alto até ao _score_ mais baixo) todos tuplos guardados na coleção.

O formato do ficheiro de _high scores_ fica ao critério dos alunos.

Cria também uma classe `Program` com um método `Main` para testar os vários
métodos da classe `HighScoreManager`.

> [Soluções](../solucoes/03_poo/72.md)

---

73 - Cria uma classe, com **um único** método estático `Main()`, que solicita
ao utilizador um número inteiro positivo e apresenta o respetivo número da
[sequência de Lucas](https://en.wikipedia.org/wiki/Lucas_number). O número
deve ser calculado de forma recursiva com uma ou mais **funções locais**.

> [Soluções](../solucoes/03_poo/73.md)

---

74 - Considera o seguinte método:

```cs
public void AwesomeMethod(float a, float b, int c = 2, string d = "hi!")
{
    Console.WriteLine($"{a} {b} {c} {d}");
}
```

1. Quais os parâmetros obrigatórios?
2. Quais os parâmetros opcionais?
3. Qual o valor de `a`, `b`, `c` e `d` se método for invocado da seguinte
forma: `AwesomeMethod(-1.0f, 0.0f, d: "bye!")`?
4. Qual o valor de `a`, `b`, `c` e `d` se método for invocado da seguinte
forma: `AwesomeMethod(50, -10, 14)`?
5. Qual o valor de `a`, `b`, `c` e `d` se método for invocado da seguinte
forma: `AwesomeMethod(c: 100, b: 123f, d: "yeah!", a: 0)`?
5. Qual o valor de `a`, `b`, `c` e `d` se método for invocado da seguinte
forma: `AwesomeMethod(b: 1, a: 2)`?

> [Soluções](../solucoes/03_poo/74.md)

---

75 - Cria uma classe estática chamada `Stats` com vários métodos utilitários
para determinar estatísticas simples. Cada um destes métodos deve aceitar um
número variável de _doubles_ e retornar o valor estatístico que lhe compete.
Devem existir métodos para a retornar a média, mediana, moda, máximo e mínimo.

Cria também uma classe `Program` com um método `Main()` para testar os vários
métodos da classe `Stats`.

> [Soluções](../solucoes/03_poo/75.md)

---

76 - Adiciona dois método à classe criada no exercício anterior:

1. O primeiro retorna todas as estatísticas de um número variável de _doubles_
   (média, mediana, moda, máximo e mínimo) num tuplo.
2. O segundo retorna todas as estatísticas de um número variável de _doubles_
   (média, mediana, moda, máximo e mínimo) em parâmetros `out`.

Ambos os métodos devem fazer uso dos métodos já existentes para cálculo das
estatísticas.

Atualiza o método `Main()` da classe `Program` para testar os dois métodos
novos.

> [Soluções](../solucoes/03_poo/76.md)

---

77 - Responde às seguintes questões:

1. Nos métodos, os parâmetros opcionais têm de aparecer a seguir a todos
   os parâmetros obrigatórios?
2. Num método, um parâmetro com a _keyword_ `params` tem de ser o último?
3. Dado o método
   `void AwesomeMethod(float x, int y = 2, params double[] z) {...}`, quais das
   seguintes instruções são válidas? Em caso afirmativo, quais os conteúdos de
   `x`, `y` e `z`?

* `AwesomeMethod(a: 2.1f, 3, 12, 23f, 34.5, -123.0);`
* `AwesomeMethod(1.7f);`
* `AwesomeMethod();`
* `AwesomeMethod(0.01f, z: new double[] { 2.3, 4, -4f });`
* `AwesomeMethod(0, 2.3f, 2, 3, 4, 5);`
* `AwesomeMethod(-1.9f, 2, 3.0, 4.0, 5.0, 6.0, 19, -1, 4);`

> [Soluções](../solucoes/03_poo/77.md)

---

78 - Quais as vantagens e desvantagens do uso de `out` e `ref` na passagem de
parâmetros para métodos?

> [Soluções](../solucoes/03_poo/78.md)

---

79 - Qual a diferença entre `out` e `ref` na passagem de parâmetros para
métodos?

> [Soluções](../solucoes/03_poo/79.md)

---

80 - Responde Sim/Não às seguintes questões:

1. Um parâmetro `out` indica que foi passada uma referência para a própria
variável em vez de uma cópia da mesma?
2. Um parâmetro `ref` indica que foi passada uma referência para a própria
variável em vez de uma cópia da mesma?
3. Os parâmetros `out` têm de ser inicializados dentro do método?
4. Os parâmetros `ref` têm de ser inicializados dentro do método?

> [Soluções](../solucoes/03_poo/80.md)

---

81 - Escreve um programa que aceita _strings_ escritas pelo utilizador em
_loop_, gravando as mesmas convertidas em maiúsculas num ficheiro especificado
como argumento da linha de comandos. O programa termina quando o utilizador
insere uma _string_ vazia (isto é, simplesmente pressiona ENTER sem escrever
nada).

_Sugestão_: confere o método [ToUpper()](https://docs.microsoft.com/dotnet/api/system.string.toupper)
da classe [string](https://docs.microsoft.com/dotnet/api/system.string).

> [Soluções](../solucoes/03_poo/81.md)

---

82 - Escreve um programa que aceita _strings_ escritas pelo utilizador em
_loop_ e tenta converte-las em `byte`. Em caso de sucesso mostra uma mensagem
apropriada contendo o valor convertido. Em caso de falhanço, mostra uma
mensagem com indicação desse facto. O programa termina quando o utilizador
insere uma _string_ vazia (isto é, simplesmente pressiona ENTER sem escrever
nada).

> [Soluções](../solucoes/03_poo/82.md)

---

83 - Considera o seguinte programa:

```cs
using System;

public class NPC
{
    public float HP { get; private set; }

    public NPC(float hp) { HP = hp; }

    public void TakeHit(float damage)
    {
        HP -= damage;
        if (HP < 0) HP = 0;
    }
}

public class Program
{
    public static void Main()
    {
        NPC[] npcs = new NPC[]
        {
            new NPC(12.5f),
            new NPC(19.5f)
        };

        NPC npc1 = npcs[0];
        npc1.TakeHit(5f);

        foreach(NPC npc in npcs)
        {
            Console.WriteLine($"HP={npc.HP}");
        }
    }
}
```

Responde às seguintes questões:

1. O que é impresso pelo programa? Descreve sucintamente o que acontece no
`Main()`.
2. Se a classe `NPC` passar a ser uma `struct`, o que é impresso pelo programa?
Porquê?
3. Que alteração temos de fazer no `Main()` (à parte de manipular o NPC
diretamente no _array_), para podermos alterar o valor do HP do NPC, sendo este
uma `struct`?

> [Soluções](../solucoes/03_poo/83.md)

---

84 - Escreve o código de um método genérico que instancie e devolva um _array_
de objetos do tipo genérico `T`. O tamanho do _array_ e o valor inicial de
todos os elementos do _array_ devem ser passados como argumentos opcionais
do método, cujos valores por omissão são 10 e `default(T)`, respetivamente.
Mostra 5 formas diferentes de usar o método (com tipos diferentes,
especificando ou não todos os parâmetros, indicando o nome dos parâmetros,
trocando a ordem dos mesmos, etc).

> [Soluções](../solucoes/03_poo/84.md)

---

85 - A classe [`Array`](https://docs.microsoft.com/dotnet/api/system.array) tem
vários métodos utilitários `static`. Um deles tem uma série de _overloads_ que
fazem algo similar ao especificado no exercício anterior. Descobre qual é o
nome deste método e utiliza um dos seus _overloads_ para instanciar uma matriz
(i.e., um _array_ bidimensional) de 50 x 50 booleanos.

> [Soluções](../solucoes/03_poo/85.md)

---

86 - Escreve um método chamado `Saturate()` que recebe dois inteiros e devolve
um booleano. O primeiro inteiro deve ser positivo e define um limite inferior e
superior dentro do qual o segundo inteiro deve estar. Caso o segundo inteiro
esteja dentro dos limites, o método simplesmente retorna `false`. Caso
contrário o método modifica o segundo inteiro, colocando-o dentro dos limites,
devolvendo `true`. A modificação do segundo inteiro deve ser visível fora do
método. Alguns exemplos:

|1º `int`|2º `int` (original)|2º `int` (talvez modificado)|Valor de retorno|
|-------:|------------------:|---------------------------:|----------------|
|10|23|10|`true`|
|15|-20|-15|`true`|
|5|-3|-3|`false`|
|25|-22|-22|`false`|
|12|15|12|`true`|

Testa o método `Saturate()` com diferentes valores de modo a verificares o seu
correto funcionamento. Faz sentido este método ser `static`? Porquê?

> [Soluções](../solucoes/03_poo/86.md)

---

87 - Escreve um programa que cria uma matriz binária bi-dimensional aleatória
que irá servir de input para uma outra função que retorna uma nova matriz 
bi-dimensional de inteiros que consiste na soma de todos os numeros das celulas 
vizinhas incluíndo a própria célula. Para este exercício iremos usar o método 
de vizinhança de [`Von Neumann`](https://en.wikipedia.org/wiki/Von_Neumann_neighborhood) 
e do método de vizinhança de [`Moore`](https://en.wikipedia.org/wiki/Moore_neighborhood). 
É importante considerar que nestes métodos o mundo é [`Toroidal`](https://en.wikipedia.org/wiki/Toroid), 
ou seja "dá a volta" ao início quando chegamos as extremidades (ver figura em baixo).

![`Toroidal World`](../img/Torus-from-rectanglegif.gif)
