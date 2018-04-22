using System;

namespace refatoracao
{
    class Program
    {
        /*
          O que é, e o que nao é referação
          Por que Refatorar?
         
         * Para reduzir a quantidade de classes e métodos desnecessários ou redundantes 
           Classes e métodos que não possuem um bom motivo para existir no programa acabam confundindo a leitura e se tornam um incômodo.
           A refatoração também serve para reduzir classes e métodos desnecessários e manter a aplicação enxuta.

         * Para eliminar de duplicação de código 
            Isso mesmo! Duplicação de código representa um dos problemas mais comuns em computação, e geralmente é provocado pelo infame 
            “CTRL-C + CTRL-V”. Quando um código que está duplicado precisa de uma mudança, você acaba tendo que modificar o código em vários 
            pontos do programa. A chance de que você tenha feito algo errado em alguma dessas mudanças é grande. Refatorar código é o meio adequado 
            para eliminar esse vício de programação.

          *Para reduzir o tempo necessário para eventual manutenção do código 
           Quanto mais obscuro o código, mais difícil a sua leitura pela equipe de desenvolvimento, e isso leva a um tempo maior para diagnosticar
           bugs e falhas em algoritmo e na arquitetura da aplicação, e também aumenta o tempo para adicionar e testar novas funcionalidades.
           A refatoração visa melhorar a clareza do código e combater esses problemas.
         */

        /*
         * Tecnica Inline Method: que é a operação inversa do "Extract Method".
         *  Usaremos essa técnica quando o método é tão óbvio quando o seu nome, e então o método se torna desnecessário. Nós não refatoramos 
         *  quando o corpo do método não é auto-explicativo, quando é óbvio, e quando o nome do método não explica o que a expressão faz.
         *  
         *  Code Smell: codigo cheirando mal. Quando temos codigo repitido.
         *  
         *  Método Longo: Quando temos um método muito longo, geralmente violamos o "Princípio de Responsabilidade Única" ou Simple Responsibility Principle. 
         *  Esse princípio diz que o método tem que fazer somente uma única tarefa. Um outro problema é que os Métodos Longos são difíceis de ler.
         *  Já os Métodos Curtos são mais fáceis de comparar e de entender.
         *  
         *  Comentários: Já os comentários, são considerados um Code Smell porque podem não explicar o código da forma correta, 
         *  podem estar mais desatualizados que o código, podem enganar o desenvolvedor, e também podem inibir a refatoração.
         *  Resolvemos os comentários, extraindo métodos.
         *  De acordo com a imagem, podemos ver a eliminação de dois comentários através da extração do método A() e do método B().
         */
        static void Main(string[] args)
        {
        }
    }
}


/*
 * 

O que aprendemos?
Refatoração NÃO É correção de bugs

Um código só deve ser refatorado DEPOIS de rodar corretamente os requisitos da aplicação
Refatoração NÃO É criação de novas funcionalidades

Código Limpo

evita duplicação de código
possibilita maior clareza
facilita comunicação entre a equipe de desenvolvimento
para identificar e eliminar as classes e métodos supérfluos
facilita manutenção do código
precisa garantir que todos os testes continuem passando

Débito técnico

É o código ruim que vai se acumulando ao decorrer do desenvolvimento
É muito comum postergar melhorias. O famoso "deixar para depois".
Refatorar reduz/elimina o débito técnico
Refatorar garante código com maior qualidade
Código com qualidade reduz o tempo de correção de bugs
Técnica de Refatoração Nº 1
Extrair método (Extract Method)
é usado quando você tem um trecho de código que pode ser agrupado
Quando Extrair método?
Quando houver código duplicado
Quando o método for muito grande
Quando houver comentários
Quando houver cadeias de mensagens
Quando NÃO extrair método?
Quando o corpo do método for ficar tão óbvio quanto seu nome
Técnica de Refatoração Nº 2
Incorporar método (Inline Method)
Quando incorporar método?
Quando o corpo do método é tão óbvio quanto seu nome, e o método se torna desnecessário
Quando NÃO refatorar?
Quando NÃO incorporar método?
Quando ocorpo do método não é auto-explicativo:
int GetNextLevel() { return level + 1; }
é óbvio, mas
int GetValue() { return (valorBase + acrescimo - desconto) * promocao;}
tem uma expressão complexa demais para o nome do método, e não deveria ser incorporado
 */
