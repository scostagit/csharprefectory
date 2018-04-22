using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Aula4.R08.ReplaceMethodWithMethod
{
    /* public class Produto
     {
         public decimal promocional { get; set; }
         decimal Preco(decimal precoBase, decimal acrescimo, decimal desconto)
         {

             var resultado = precoBase;

             if (promocional > 0 && desconto > 0)
             {
                 throw new Exception("Produto já é promocional e não pode ter desconto!");
             }

             if (desconto > 20)
             {
                 desconto = 20;
             }

             if (acrescimo > 15)
             {
                 acrescimo = 15;
             }

             return precoBase + precoBase * (acrescimo - desconto);
         }


     }*/
    public class Produto
    {
        public decimal promocional { get; set; }
        decimal Preco(decimal precoBase, decimal acrescimo, decimal desconto)
        {
            //Com isso, conseguimos com sucesso, realizar a refatoração de substituir o método pelo método-objeto.
            return new CalculadoraDePrecos(this, precoBase, acrescimo, desconto).Calcular();
        }
    }

    public class CalculadoraDePrecos
    {
        private readonly Produto produto;
        private decimal precoBase;
        private decimal acrescimo;
        private decimal desconto;

        public CalculadoraDePrecos(Produto produto, decimal precoBase, decimal acrescimo, decimal desconto)
        {
            this.produto = produto;
            this.precoBase = precoBase;
            this.acrescimo = acrescimo;
            this.desconto = desconto;
        }

        public decimal Calcular()
        {
            var resultado = precoBase;

            if (produto.promocional > 0 && desconto > 0)
            {
                throw new Exception("Produto já é promocional e não pode ter desconto!")
            }

            if (desconto > 20)
            {
                desconto = 20;
            }

            f(acrescimo > 15)
        {
                acrescimo = 15;
            }

            return precoBase + precoBase * (acrescimo - desconto);
        }

    }
}


/*
 * O que aprendemos?
Técnica de Refatoração Nº 8
Substituir um método com um objeto-método (Replace Method With Method Object)
Um método é tão complexo que você não consegue extrair um método
Quando refatorar?
Um método é longo e complexo, mesmo assim não dá pra extrair métodos menores a partir dele.
Porém...
Você vai precisar de mais uma classe, o que aumenta a complexidade do programa
Técnica de Refatoração Nº 9
Substituir o algoritmo (Substitute Algorithm)
O algoritmo atual funciona, mas você teve uma ideia bem melhor
Quando refatorar?
Quando você vê um algoritmo e sente que pode fazer melhor, simplificando ou esclarecendo o código.
Quando NÃO refatorar?
Você não entendeu muito bem o funcionamento do código original, ou não tem testes unitários suficientes para garantir que o programa vai funcionar como antes.
 */
