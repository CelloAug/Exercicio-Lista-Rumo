using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA1
{
    public class Atividades2
    {

        public void Exercicio20()

        {
            Console.WriteLine("Exercícios maiores em arquivo a parte");


        }



        public void Exercicio21()

        {
            bool saude;
            string nomePessoa, sexo;
            int idade, totalAptos = 0, iniciar, total = 0;


            iniciar = 1;

            while (iniciar == 1)
            {

                saude = true;
                total = total + 1;

                Console.WriteLine("Digite o nome da pessoa");
                nomePessoa = Console.ReadLine();

                Console.WriteLine("Digite a idade da pessoa");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o sexo da pessoa");
                sexo = Console.ReadLine();

                if (idade >= 18)
                {
                    Console.WriteLine("Apto para o serviço militar");

                }
                Console.WriteLine("Como você classifica o estado de saúde da pessoa? Digite 1 para BOM ou 2 para RUIM");
                saude = bool.Parse(Console.ReadLine());

                if (saude == true)
                {


                    totalAptos = totalAptos + 1;

                }
                else
                {
                    totalAptos = 0;

                }
                Console.WriteLine("Foram testadas " + total + "pessoas e " + totalAptos + "estão aptas ");



            }

        }


        public void Exercicio22()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }

        public void Exercicio23()

        {

            int num;

            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num < 25)
            {

                Console.WriteLine("Este número é menor que 25");

            }
            if (num > 80)
            {

                Console.WriteLine("Este número é maior que 80");

            }
            else if (num == 40)
            {

                Console.WriteLine("Este número é igual a 40");

            }


        }

        public void Exercicio24()

        {

            int i, num;
            i = 1;

            while (i == 1)
            {

                Console.WriteLine("Digite um número:");
                num = int.Parse(Console.ReadLine());


                if (num > 0)
                {
                    Console.WriteLine("Número positivo");

                }
                else if (num < 0)
                {
                    Console.WriteLine("Número negativo");

                }
                else if (num == 0)
                {
                    Console.WriteLine("Este número é 0");

                }


            }




        }

        public void Exercicio25()

        {
            int num1, num2;

            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite um segundo número: ");
            num2 = int.Parse(Console.ReadLine());


            if (num1 == num2)
            {

                Console.WriteLine("Os números informados são iguais ");

            }
            else if (num1 > num2)
            {
                Console.WriteLine("O primeiro numero informado é maior que o segundo número informado ");

            }

            else if (num1 < num2)
            {
                Console.WriteLine("O segundo numero informado é maior que o primeiro número informado ");

            }




        }

        public void Exercicio26()

        {

            string num1, num2, num3, num4, num5;
            int entrada;

            num1 = "NÚMERO UM";
            num2 = "NÚMERO DOIS";
            num3 = "NÚMERO TRÊS";
            num4 = "NÚMERO QUATRO";
            num5 = "NÚMERO CINCO";

            Console.WriteLine("Digite um número de 1 a 5");
            entrada = int.Parse(Console.ReadLine());

            if (entrada > 5)
            {


                Console.WriteLine("Este número é inválido");

            }

            else if (entrada < 1)
            {


                Console.WriteLine("Este número é inválido");

            }

            switch (entrada)
            {

                case 1:

                    Console.WriteLine(num1);

                    break;

                case 2:

                    Console.WriteLine(num2);

                    break;

                case 3:

                    Console.WriteLine(num3);

                    break;

                case 4:

                    Console.WriteLine(num4);

                    break;

                case 5:

                    Console.WriteLine(num5);

                    break;

            }
;
            {




            }

        }

        public void Exercicio27()

        {
            Console.WriteLine("Exercícios maiores em arquivo a parte");



        }

        public void Exercicio28()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }

        public void Exercicio29()

        {
            int mes;

            Console.WriteLine("Digite o número mês desejado: ");
            mes = int.Parse(Console.ReadLine());

            switch(mes)

            {
                case 1:

                    Console.WriteLine("Janeiro");

                    break;

                case 2:

                    Console.WriteLine("Fevereiro");

                    break;

                case 3:

                    Console.WriteLine("Março");

                    break;
                case 4:

                    Console.WriteLine("Abril");

                    break;

                case 5:

                    Console.WriteLine("Maio");

                    break;

                case 6:

                    Console.WriteLine("Junho");

                    break;
                case 7:

                    Console.WriteLine("Julho");

                    break;

                case 8:

                    Console.WriteLine("Agosto");

                    break;

                case 9:

                    Console.WriteLine("Setembro");

                    break;

                case 10:

                    Console.WriteLine("Outubro");

                    break;
                case 11:

                    Console.WriteLine("Novembro");

                    break;

                case 12:

                    Console.WriteLine("Dezembro");

                    break;

                default: 
                  

                    Console.WriteLine("Mês inválido");

                    break;

            }



        }

        public void Exercicio30()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }

        public void Exercicio31()

        {
            int num1, num2, num3;
            int[] ordem = new int[3];


            Console.WriteLine("Digite o valor 1 : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2 : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 3 : ");
            num3 = int.Parse(Console.ReadLine());


            if (num1 > num2)
            {

                ordem[3] = num1;
                ordem[2] = num2;


            }

            else if (num3 > num1)
            {

                ordem[3] = num3;
                ordem[2] = num2;
                ordem[1] = num1;


            }

            else if (num3 > num2)
            {

                ordem[3] = num1;
                ordem[2] = num3;
                ordem[1] = num2;


            }
            

            else if (num3 > num1)
            {

                ordem[3] = num2;
                ordem[2] = num3;
                ordem[1] = num2;


            }
            else
            {

                ordem[3] = num1;
                ordem[2] = num2;
                ordem[1] = num3;


            }

            Console.WriteLine("Os números em ordem crescente são:");
            Console.WriteLine(ordem[1]);
            Console.WriteLine(ordem[2]);
            Console.WriteLine(ordem[3]);


        }

        public void Exercicio32()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }

        public void Exercicio33()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }

        public void Exercicio34()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }


        public void Exercicio35()

        {
            Console.WriteLine("Exercícios maiores em arquivo a parte");


        }


        public void Exercicio36()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }

        public void Exercicio37()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }

        public void Exercicio38()

        {
            Console.WriteLine("Exercícios maiores em arquivo a parte");


        }

        public void Exercicio39()

        {
            Console.WriteLine("Exercícios maiores em arquivo a parte");


        }

        public void Exercicio40()

        {

            Console.WriteLine("Exercícios maiores em arquivo a parte");

        }



    }
}






