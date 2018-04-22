using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Aula3.R06.SplitTemporaryVariable
{

    /*
     * Chegamos ao final de mais um capítulo do nosso curso. Falamos sobre o item seis Quebrar uma variável em duas ou mais, onde uma variável é declarada uma vez,
     * e ela é utilizada posteriormente para armazenar outros valores. Isso faz com que nós não respeitemos o princípio da responsabilidade única. Um outro problema 
     * encontrado é que essa variável sempre terá um nome genérico que nunca vai representar corretamente o valor que ela armazena.

Um outro ponto a ser visto, é que quando utilizamos a mesma variável para várias coisas diferentes, acabamos amarrando o código, e todo o código posterior fica
dependente daquela linha onde essa variável é declarada.

           public Retangulo(double altura, double largura)
        {
            var temp = 2 * (altura + largura);
            System.Console.WriteLine($"Perímetro: {temp}");

            temp = altura * largura;
            System.Console.WriteLine($"Área: {temp}");
        }
     */
    public class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            double Perimetro = 2 * (altura + largura);
            System.Console.WriteLine($"Perímetro: {Perimetro}");

            double area = altura * largura;
            System.Console.WriteLine($"Área: {area}");
        }
    }
}

/*
 *          a varivel temp esta quebrando o principio de resposibalidade unica.
 *          essa varias esta usando mais de uma vez para armazer valores de duas taregas diferentes.
 *          
            double temp = 2 * (altura + largura);
            System.Console.WriteLine($"Perímetro: {temp}");

            temp = altura * largura;
            System.Console.WriteLine($"Área: {temp}");

    Como podemos ver, temos uma declaração de uma variável temporária temp, que recebe o valor do calculo do perímetro do retângulo. Em seguida, a
    mesma variável temp é usada para armazenar o calculo da área. Qual é o problema disso?

Primeiro, a variável temp não explica o que ela faz. Para saber disso, precisamos olhar a sua declaração e ver o que ela está armazenando. Segundo, 
a mesma variável temp está sendo usada em dois propósitos, ou seja, ela está acumulando tarefas, quebrando o princípio da responsabilidade única.
O terceiro problema é que temos dois trechos de código que deveriam ser independentes. Por exemplo, se quisermos realizar o calculo da área antes 
do perímetro. Será que mover o trecho da área para antes do trecho do perímetro resolveria o nosso problema?

    Isso não seria possível, pessoal. Agora, a variável temp está sendo usada antes da sua declaração, e o código não irá compilar. 
    Como vimos, são dois trechos independentes. Deixe o método do jeito que estava, caso você tenha mudado os trechos de posição.



    O que aprendemos?
Técnica de Refatoração Nº 6
Quebrar uma variável em duas ou mais (Split Temporary Variable)

Você tem uma variável temporária que recebe valor mais de uma vez

Por que refatorar?

Uma variável está com mais de uma responsabilidade
Nome da variável não explica o que ela armazena
Todo o código fica “amarrado” com a linha onde a variável é declarada
Código pouco legível
Quando NÃO refatorar?

Quando a variável só é usada uma vez
Técnica de Refatoração Nº 7
Remover atribuição a parâmetros (Remove Assignments to Parameters)

Você modificou um parâmetro de entrada dentro de um método

Quando refatorar?

Você está “economizando” variável ao modificar um parâmetro de entrada.
Quando NÃO refatorar?
Em métodos recursivos ou não, quando o parâmetro funciona como acumulador
 */


