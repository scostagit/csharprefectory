using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Aula3.R07.RemoveAssignmentsToPara
{
    /*
     * Remover atribuição a parâmetro

 
         A atribuição de valores a um parâmetro faz você ter dificuldades em saber qual informação deveria ser contida no parâmetro num determinado momento.
         O problema piora se o seu parâmetro e seu conteúdo estão documentados mas o valor real pode divergir daquilo que é esperado dentro do método.

        Cada componente do código do programa deve ser responsável uma e somente uma coisa. Isso deixa o código mais fácil de dar manutenção, pois você pode 
        facilmente substituir qualquer pedaço sem medo de efeitos colaterais.

        A refatoração de número sete, Remove atribuição a parâmetros. É um caso bem parecido com o item seis, em que o parâmetro ta acumulando tarefas, 
        fazendo a função que seria de uma variável temporária. Nesse caso, podemos perceber que o desenvolvedor está tentando economizar variável temporária,
        e com isso está prejudicando o código, perdendo o valor inicial, o valor que foi mandado para o método como mensagem.
     */
    public class CalculadoraDePrecos
    {
        /*
         * Perceba que a variável descontoInicial é modificada ao longo do método, até que esse descontoInicial é retornado como um "desconto final". 
         * Então, o parâmetro descontoInicial está sendo usado tanto para receber uma mensagem de fora do método, como também está sendo usado como 
         * variável temporária local. Isso é ruim, pois como já vimos, esse parâmetro está acumulando funções.
         * 
         * Então, quando o parâmetro é modificado, nós simplesmente perdemos o seu valor inicial, nós perdemos a 
         * mensagem que o método recebeu. O que será necessário fazer, é introduzir uma variável local, uma variável de retorno com o
         * mesmo tipo do parâmetro que irá armazenar o desconto inicial.
         
        decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos)
        {
            if (descontoInicial > 50M)
            {
                descontoInicial = 50M;
            }
            if (quantidade > 100)
            {
                descontoInicial += 15M;
            }
            if (clienteHaQuantosAnos > 4)
            {
                descontoInicial += 10M;
            }
            return descontoInicial;
        }*/

        decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos)
        {
            decimal resultdo = descontoInicial;
            if (resultdo > 50M)
            {
                resultdo = 50M;
            }
            if (quantidade > 100)
            {
                resultdo += 15M;
            }
            if (clienteHaQuantosAnos > 4)
            {
                resultdo += 10M;
            }

            return resultdo;

            /*
             * E com isso, conseguimos substituir a atribuição ao parâmetro por uma atribuição à variável local, realizando a refatoração com sucesso.
             */
        }
    }
}
