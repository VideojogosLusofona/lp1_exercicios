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

<!--
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
-->