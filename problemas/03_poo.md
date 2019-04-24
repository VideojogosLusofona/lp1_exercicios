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

