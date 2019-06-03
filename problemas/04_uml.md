# UML e design de classes

_Nota:_

* Alguns exercícios desta secção pedem para desenhar um diagrama UML.
* A imagem contendo o diagrama, em formato PNG, deve ser guardada em modo Git
  LFS na pasta [solucoes/04_uml](../solucoes/04_uml/).
* O respetivo nome de ficheiro deve seguir o número do exercício (por exemplo,
  uma imagem para o exercício 5 deve estar no ficheiro `05.png`).
* O respetivo ficheiro Markdown com a solução deve simplesmente apresentar essa
  imagem.

---

1 - Desenha o diagrama UML de classes completo para o projeto [01](04_uml/01).

> [Soluções](../solucoes/04_uml/01.md)

---

2 - Considera o diagrama UML em baixo, e depois indica, justificando, quais das
seguintes instruções são válidas e quais são inválidas. As instruções são
independentes umas das outras, e naquelas que não implicam criação de objetos
presume-se que o(s) objeto(s) em questão já foram instanciados. Considera-se
que todas as instruções ocorrem fora das classes presentes no diagrama.

![uml02](../img/uml02.png)

* `Animal animal = new Dog();`
* `Cat cat = new Dog();`
* `Cat cat = new Animal();`
* `a.Bark(); // 'a' é uma instância de Animal`
* `dog.Eat(); // 'dog' é uma instância de Dog`
* `float y = tareco.energy; // 'tareco' é uma instância de Cat`
* `Console.WriteLine(myCat.Name); // 'myCat' é uma instância de Cat`
* `bobi.energy = 123.4f; // 'bobi' é uma instância de 'Dog'`
* `Dog pluto = new Animal();`
* `y.Meow(); // 'y' é uma instância de Cat`
* `beast.Bite(); // 'beast' é uma instância de Animal`
* `zz.Eat(); // 'zz' é uma instância de Cat`

> [Soluções](../solucoes/04_uml/02.md)

---

3 - Desenha o diagrama UML de classes (versão simplificada, apenas blocos com
nome do tipo, relações entre os tipos, e cardinalidade) para o código do
[exercício 23](03_poo.md#ex23) de Programação por Objetos.

> [Soluções](../solucoes/04_uml/03.md)

---

4 - Desenha o diagrama UML de classes (versão simplificada, apenas blocos com
nome do tipo, relações entre os tipos, e cardinalidade) para o código do
[exercício 24](03_poo.md#ex24) de Programação por Objetos.

> [Soluções](../solucoes/04_uml/04.md)

---

5 - Desenha o diagrama UML de classes completo para o
[exercício 25](03_poo.md#ex25) de Programação por Objetos.

> [Soluções](../solucoes/04_uml/05.md)

---

6 - Cria um projeto no Visual Studio que respeite o seguinte diagrama UML. O
projeto deve ter funcionalidade mínima para demonstrar as relações indicadas no
diagrama.

![uml06](../img/uml06.png)

> [Soluções](../solucoes/04_uml/06.md)

---

7 - Desenha o diagrama UML de classes completo para o
[exercício 31](03_poo.md#ex31) de Programação por Objetos.

> [Soluções](../solucoes/04_uml/07.md)

---

<a name="ex8"></a>
8 - (continuação do [exercício 37](03_poo.md#ex37) de Programação por Objetos)

Considera a seguinte classe:

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

1. Cria pelo menos 3 subclasses concretas (não abstratas), representando
   diferentes NPCs num jogo, com lógicas concretas e específicas para cada um
   deles. Os métodos `EatFood()` e `AttackEnemies()` podem consistir apenas de
   `Console.WriteLines`.
2. Cria uma classe `Program` com um método `Main()` para testar as classes
   criadas no ponto anterior. Por exemplo, criar uma ou mais instâncias de cada
   classe, colocar as mesmas numa coleção de `NPC`, percorrer a coleção, e
   invocar o método `PlayTurn()` em cada uma delas. Repara que, além do
   construtor, só o método `PlayTurn()` pode ser invocado a partir de outras
   classes.
3. Identifica a presença de polimorfismo na solução que apresentaste no ponto
   anterior.
4. Desenha o diagrama UML da solução apresentada.

> [Soluções](../solucoes/04_uml/08.md)

---

9 - O exercício anterior corresponde a um _design pattern_ muito útil e comum,
que consiste em definir os passos principais de um algoritmo ou operação,
delegando nas subclasses alguns ou todos os passos concretos do mesmo. Por
outras palavras, este _design pattern_ permite redefinir alguns passos do
algoritmo ou operação sem alterar a estrutura do mesmo. Que _design pattern_
é este?

> [Soluções](../solucoes/04_uml/09.md)

---
