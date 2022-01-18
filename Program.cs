using System;

namespace LISTA1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----RESOLUÇÃO LISTA EXERCÍCIOS--- \n");
            Console.WriteLine("\n Selecione uma opção entre 1 e 40: ");
           
            
            var opcao = int.Parse(Console.ReadLine());

            if(opcao > 40 )
            {


                Console.WriteLine("A opção escolhida não existe \n Digite um número de 1 a 40");



            }

            else {
                switch (opcao)
                {

                    case 1:
                        var resposta1 = new Atividades();
                        resposta1.Exercicio1();


                        break;


                    case 2:
                        var resposta2 = new Atividades();
                        resposta2.Exercicio2();



                        break;


                    case 3:

                        var resposta3 = new Atividades();
                        resposta3.Exercicio3();

                        break;


                    case 4:
                        var resposta4 = new Atividades();
                        resposta4.Exercicio4();

                        break;

                    case 5:

                        var resposta5 = new Atividades();
                        resposta5.Exercicio5();

                        break;

                    case 6:

                        var resposta6 = new Atividades();
                        resposta6.Exercicio6();

                        break;


                    case 7:

                        var resposta7 = new Atividades();
                        resposta7.Exercicio7();

                        break;


                    case 8:
                        var resposta8 = new Atividades();
                        resposta8.Exercicio8();
                        break;

                    case 9:
                        var resposta9 = new Atividades();
                        resposta9.Exercicio9();
                        break;

                    case 10:

                        var resposta10 = new Atividades();
                        resposta10.Exercicio10();

                        break;

                    case 11:
                        var resposta11 = new Atividades();
                        resposta11.Exercicio11();


                        break;


                    case 12:

                        var resposta12 = new Atividades();
                        resposta12.Exercicio12();

                        break;

                    case 13:

                        var resposta13 = new Atividades();
                        resposta13.Exercicio13();

                        break;

                    case 14:

                        var resposta14 = new Atividades();
                        resposta14.Exercicio14();

                        break;


                    case 15:
                        var resposta15 = new Atividades();
                        resposta15.Exercicio15();
                        break;


                    case 16:

                        var resposta16 = new Atividades();
                        resposta16.Exercicio16();

                        break;



                    case 17:

                        var resposta17 = new Atividades();
                        resposta17.Exercicio17();

                        break;


                    case 18:

                        var resposta18 = new Atividades();
                        resposta18.Exercicio18();

                        break;


                    case 19:
                        var resposta19 = new Atividades();
                        resposta19.Exercicio19();


                        break;


                    case 20:
                        var resposta20 = new Atividades2();
                        resposta20.Exercicio20();

                        break;


                    case 21:
                        var resposta21 = new Atividades2();
                        resposta21.Exercicio21();

                        break;


                    case 22:

                        var resposta22 = new Atividades2();
                        resposta22.Exercicio22();

                        break;


                    case 23:
                        var resposta23 = new Atividades2();
                        resposta23.Exercicio23();


                        break;


                    case 24:
                        var resposta24 = new Atividades2();
                        resposta24.Exercicio24();

                        break;


                    case 25:

                        var resposta25 = new Atividades2();
                        resposta25.Exercicio25();

                        break;


                    case 26:
                        var resposta26 = new Atividades2();
                        resposta26.Exercicio26();
                        break;


                    case 27:

                        var resposta27 = new Atividades2();
                        resposta27.Exercicio27();

                        break;


                    case 28:
                        var resposta28 = new Atividades2();
                        resposta28.Exercicio28();

                        break;


                    case 29:

                        var resposta29 = new Atividades2();
                        resposta29.Exercicio29();

                        break;


                    case 30:
                        var resposta30 = new Atividades2();
                        resposta30.Exercicio30();
                        break;

                    case 31:
                        var resposta31 = new Atividades2();
                        resposta31.Exercicio31();
                        break;


                    case 32:
                        var resposta32 = new Atividades2();
                        resposta32.Exercicio32();
                        break;

                    case 33:
                        var resposta33 = new Atividades2();
                        resposta33.Exercicio33();
                        break;

                    case 34:
                        var resposta34 = new Atividades2();
                        resposta34.Exercicio34();
                        break;

                    case 35:

                        var resposta35 = new Atividades2();
                        resposta35.Exercicio35();

                        break;

                    case 36:


                        var resposta36 = new Atividades2();
                        resposta36.Exercicio36();

                        break;


                    case 37:
                        var resposta37 = new Atividades2();
                        resposta37.Exercicio37();
                        break;


                    case 38:
                        var resposta38 = new Atividades2();
                        resposta38.Exercicio38();
                        break;


                    case 39:
                        var resposta39 = new Atividades2();
                        resposta39.Exercicio39();
                        break;


                    case 40:
                        var resposta40 = new Atividades2();
                        resposta40.Exercicio40();
                        break;




                }

            }



        }

        }
    }


