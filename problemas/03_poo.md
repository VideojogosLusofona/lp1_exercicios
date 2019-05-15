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
[queue/fila],
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

15 - Explica por palavras tuas o significado dos seguintes termos:

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
Console.WriteLine($“{trap.Tag}”); // trap é uma instância de Trap
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
Console.WriteLine($“{pup.Priority}”); // pup é uma instância de PowerUp
```

> [Soluções](../solucoes/03_poo/31.md)

---

<!--
32 - Estás a desenvolver um jogo, e tanto o jogador como os NPCs, representados
de forma abstrata pela classe `GameCharacter`, transportam itens do tipo
`IGameItem`. Os itens de cada `GameCharacter` estão guardados numa coleção
genérica do tipo [HashSet&lt;T&gt;][], representada pela variável de instância
`items`. Alguns destes itens podem implementar a interface `IBurnable`,
representada pelo seguinte código:

```cs
public interface IBurnable
{
    float PotentialEnergy { get; }
    void Burn();
}
```

Escreve um método chamado `GetPotentialEnergyOfBurnableItems()`, pertencente à
classe `GameCharacter`, que devolve a energia potencial de todos os itens
queimáveis transportados pelo jogador ou por um NPC.

> [Soluções](../solucoes/03_poo/32.md)
-->
