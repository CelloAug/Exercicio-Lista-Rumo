using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA1
{
    public class Atividades
    {

        public void Exercicio1()
        {

            //EXERCICIO 1

            int num1, num2, soma;


            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um  segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.Write("A soma dos dois números é : " + soma);



        }

        public void Exercicio2()
        {

            decimal num1, num2, soma, mult, divisao, subtracao;


            Console.WriteLine(" Escreva o primeiro número:");
            num1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(" Escreva o segundo  número:");
            num2 = decimal.Parse(Console.ReadLine());


            mult = num1 * num2;
            soma = num1 + num2;
            subtracao = num1 - num2;
            divisao = num1 / num2;

            Console.WriteLine("A soma dos numeros é " + soma + ", sua subtração é " + subtracao + ", sua divisao é " + divisao + " e por fim, sua multiplicação é " + mult);



        }


        public void Exercicio3()
        {
            decimal kmLitro, autonomiaTanque, litroTanque, diferencaLitro, kmPercorrido;

            Console.WriteLine("Digite quantos km por litro o seu carro faz:");
            kmLitro = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Quantos litros de gasolina há no tanque de seu carro? ");
            litroTanque = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual a distância a ser percorrida até seu destino ");
            kmPercorrido = decimal.Parse(Console.ReadLine());



            autonomiaTanque = kmLitro * litroTanque;


            diferencaLitro = kmPercorrido - autonomiaTanque;



            Console.WriteLine("Seu carro tem uma autonomia de rodar " + autonomiaTanque + " kms por litro.");
            Console.WriteLine("Você gastará nessa viagem " + diferencaLitro + "litros de gasolina.");



        }


        public void Exercicio4()
        {
            string nomeVendedor;
            decimal salarioVendedor, totalVendas, comissao, totalPagar;

            Console.WriteLine("Digite o nome do vendedor: ");
            nomeVendedor = Console.ReadLine();

            Console.WriteLine("Digite o salario do vendedor: ");
            salarioVendedor = Convert.ToDecimal( Console.ReadLine());

            Console.WriteLine("Quantas vendas realizou o  vendedor? ");
            totalVendas = Convert.ToDecimal(Console.ReadLine());

            comissao = totalVendas * (15.0m / 100.0m);

            totalPagar = salarioVendedor + comissao;

            Console.WriteLine("O vendedor de nome " + nomeVendedor + " que tem o salário R$" + salarioVendedor
        + "  recebeu no total com sua comissao : R$" + totalPagar);







        }

        public void Exercicio5()
        {
            string nomeAluno ;
            decimal soma, media;
            decimal[] notasProvas = new decimal[3];
            soma = 0m;

            Console.WriteLine("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            int cont = 0;

            while (cont < 3)
            {

                
                Console.WriteLine("Informe a nota da prova " + cont++);
                notasProvas[cont] = Convert.ToDecimal(Console.ReadLine());

                soma += notasProvas[cont];



            }
            media = (soma / 3);
            Console.WriteLine("O aluno " + nomeAluno + " teve uma média de " + media + " pontos nas provas.");





        }



        public void Exercicio6()
        {
            decimal a, b, intermediario;

            Console.WriteLine(" Escreva um valor para A: ");
            a = Convert.ToDecimal(Console.ReadLine());



            Console.WriteLine(" Escreva um valor para B: ");
            b = Convert.ToDecimal(Console.ReadLine());
            intermediario = a;
            a = b;
            b = intermediario;


            Console.WriteLine(" Invertendo os valores, A fica com  " + a + " e B com " + b);



        }

        public void Exercicio7()
        {

            double celsius, faren;

            Console.WriteLine("Digite a temperatura em Celsius a ser convertida em Fahrenheit: ");
            celsius = double.Parse(Console.ReadLine());


            faren = (celsius* 9d / 5d) + 32d;

            Console.WriteLine("A temperatura informada em Celsius convertida para Fahrenheit é" + faren);




        }


        public void Exercicio8()
        {

            double cotacaoDolar, real, conversao;

            Console.WriteLine("Digite o valor em real que deseja converter para dolar");
            real = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cotação do dolar atual");
            cotacaoDolar = double.Parse(Console.ReadLine());

            conversao = real * cotacaoDolar;

            

            Console.WriteLine("Você possui na sua carteira " + conversao + " em dolar");
            


        }

        public void Exercicio9()
        {
            decimal valorDeposito, rendimento, juros, calculoJuros;

            Console.WriteLine("Digite o valor que foi depositado");
            valorDeposito = Convert.ToDecimal(Console.ReadLine());


            juros = 0.7m;

            calculoJuros = valorDeposito * juros;


            rendimento = valorDeposito + calculoJuros;


            Console.WriteLine("O rendimento da poupança após um mês será: " + rendimento);



        }

        public void Exercicio10()
        {

            decimal valorCompra, prestacao;

            Console.WriteLine("Digite o valor da compra: ");
            valorCompra = Convert.ToDecimal(Console.ReadLine());

            prestacao = valorCompra / 5m;

            Console.WriteLine(" O valor das prestações a pagar é de: " + prestacao);



        }


        public void Exercicio11()
        {

            decimal valorProduto, valorVenda, percentual;

            Console.WriteLine(" Digite o quanto custou o produto:");
            valorProduto = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine(" Digite o percentual da venda : ");
            percentual = Convert.ToDecimal(Console.ReadLine());


            percentual = (percentual / 100m) * valorProduto;

            valorVenda = valorProduto + percentual;

            Console.WriteLine("O valor de venda deste produto é " + valorVenda);




        }

        public void Exercicio12()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");


        }

        public void Exercicio13()

        {
            int num;


            Console.WriteLine("Digite um número inteiro");
            num = int.Parse(Console.ReadLine());

            if (num >= 100 & num <= 200)

            {
                Console.WriteLine("Este número está entre 100 e 200");



            }

            else
            {

                Console.WriteLine("Este número não está entre 100 e 200");

            }



        }

        public void Exercicio14()

        {
            int valor1, valor2;

            Console.WriteLine("Digite um número inteiro");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo número inteiro: ");
            valor2 = int.Parse(Console.ReadLine());


            if (valor1 > valor2)
            {


                Console.WriteLine(" O valor 1 é maior que o valor 2");
            }

            else if (valor1 < valor2)
            {

                Console.WriteLine(" O valor 2 é maior que o valor 1");


            }

            else
            {

                Console.WriteLine(" Os valores são iguais");

            }
        }


        public void Exercicio15()

        {
            int num;


            Console.WriteLine("Digite um número inteiro");
            num = int.Parse(Console.ReadLine());

            if (num >= 100 & num <= 200)

            {
                Console.WriteLine("Este número está entre 100 e 200");



            }

            else
            {

                Console.WriteLine("Este número não está entre 100 e 200");

            }



        }

        public void Exercicio16()

        {
            string nomeAluno;
            decimal soma;
            decimal[] notasProvas = new decimal[3];
            decimal media;
            soma = 0m;

            Console.WriteLine("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            int cont = 0;

            while (cont < 3)
            {


                Console.WriteLine("Informe a nota da prova " + cont++);
                notasProvas[cont] = Convert.ToDecimal(Console.ReadLine());

                soma += notasProvas[cont];

            }
            media = (soma / 3m);

            if (media >= 7)
            {
                Console.WriteLine("O aluno " + nomeAluno + " teve uma média de " + media + " está aprovado.");

            }
            else if (media <= 5)
            {
                Console.WriteLine("O aluno " + nomeAluno + " teve uma média de " + media + " está reprovado.");

            }

            else 
                 {


                Console.WriteLine("O aluno " + nomeAluno + " teve uma média de " + media + " está em recuperação.");

            }


        }

        public void Exercicio17()

        {
            int num, intervalo, i=0;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            while (i > 0 & i<=80) {
            
                if (num>=10 & num <=150 )
                {

                    intervalo=num++;

                    Console.WriteLine("Foram digitados" + intervalo + "números no intervalo entre 10 e 150");

                }

                
            
            
            }


        }

        public void Exercicio18()

        {
            int idade, i=0;
            
            
            while (i > 0 & i <= 75)

            {
                Console.WriteLine("Informe a idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 18) {
                    Console.WriteLine(" A pessoa da idade informada é de maior");
                
                                    }
                else
                {
                    Console.WriteLine(" A pessoa da idade informada é de menor");

                }
            }

            }

        public void Exercicio19()

        {

            string nome;
            int i=0 ,sexo,h=0,m=0;

            while (i >= 0 & i <= 5)
            {
                Console.WriteLine("Digite o nome da pessoa: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite 1 - para HOMEM E  2- para MULHER :  ");
                sexo = int.Parse(Console.ReadLine());

                switch (sexo)
                {

                    case 1:

                        h = h + 1;
                        Console.WriteLine("O" + nome + "é homem");
                        break;

                    case 2:
                        m = m + 1;
                        Console.WriteLine("A" + nome + "é mulher");
                        break;

                }
                Console.WriteLine("Foram adicionados" + h + "homens e " + m + "mulheres");


                }

                    

                }
            


                }


            }


        



    



