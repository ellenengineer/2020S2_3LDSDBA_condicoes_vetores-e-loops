﻿using System;

namespace TesteCondicoes
{

    class Program
    {

       static string[] arrDiasSemana = new string[] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };

       static int[] arrayWhile = new int[] { 1, 2, 3, 4, 5 };
        static void Main(string[] args)
        {
            //comentario por linha
            /*comentário por código*/


            /* //1 - Teste IF-ELSE
            string strValorDiaDaSemana = Console.ReadLine();

            int intValorUsuarioConvertido = Convert.ToInt32(strValorDiaDaSemana);
            showCondition((DiaUteisSemana)intValorUsuarioConvertido);
            //Fim do teste IF- ELSE*/


            /*
            //  2 - Teste Switch Case no C#
            string strValorDiaDaSemana = Console.ReadLine();
            int intValorUsuarioConvertido = Convert.ToInt32(strValorDiaDaSemana);
            showSwitchCase((DiaUteisSemana)intValorUsuarioConvertido);
            //FIM Teste Switch Case no C#
            */


            /*  //3 - switchCaseClasse - switch case com parametro de classe
              string strValorDiaDaSemana = Console.ReadLine();
              int intValorUsuarioConvertido = Convert.ToInt32(strValorDiaDaSemana);

              clsDiasSemana clsDia = new clsDiasSemana();
              clsDia.DiaSemanaProperty = (DiaUteisSemana)intValorUsuarioConvertido;
              decimal retorno =  switchCaseClasse(clsDia, 50);

              Console.WriteLine(retorno);
              Console.ReadLine();
              //switchCaseClasse - switch case com parametro de classe*/

            /*
             // 4 - SwitchCase2 - uma das formar de implementar condicoes switch case no C#
             string strValorDigitadoPeloUsuario = Console.ReadLine();
             int intValorDigitadoConvertido = Convert.ToInt32(strValorDigitadoPeloUsuario);
             DiaUteisSemana diaUtil = (DiaUteisSemana)intValorDigitadoConvertido;
             string retorno = SwitchCase2(diaUtil);
             Console.WriteLine(retorno);
             Console.ReadLine();
             //FIM SwitchCase2 - uma das formar de implementar condicoes switch case no C#
             */

            /* //5 - Switch case Com duas condições RetornarDiasDeAula

             Console.WriteLine("Digite o primeiro dia da semana");

             string strDiaSemana1 = Console.ReadLine();

             Console.WriteLine("Digite o segundo dia da semana");

             string strDiaSemana2 = Console.ReadLine();


             int intDiaSemana1 = Convert.ToInt32(strDiaSemana1);
             int intDiaSemana2 = Convert.ToInt32(strDiaSemana2);

             DiaUteisSemana diaSemana1 = (DiaUteisSemana)intDiaSemana1;
             DiaUteisSemana diaSemana2 = (DiaUteisSemana)intDiaSemana2;

            string retorno = RetornarDiasDeAula(diaSemana1, diaSemana2);

             Console.WriteLine(retorno);

             Console.ReadLine();
             // FIM Switch case Com duas condições RetornarDiasDeAula*/


            /* //6 - Switch case com mais de uma opcao, com propriedades de classe 

             Console.WriteLine("Digite o primeiro dia da semana");

             string strDiaSemana1 = Console.ReadLine();

             Console.WriteLine("Digite o segundo dia da semana");

             string strDiaSemana2 = Console.ReadLine();


             int intDiaSemana1 = Convert.ToInt32(strDiaSemana1);
             int intDiaSemana2 = Convert.ToInt32(strDiaSemana2);

             DiaUteisSemana diaSemana1 = (DiaUteisSemana)intDiaSemana1;
             DiaUteisSemana diaSemana2 = (DiaUteisSemana)intDiaSemana2;


             clsDiasSemana objDiaSemana = new clsDiasSemana(diaSemana1, diaSemana2);

             string retorno = GetDiasUteis(objDiaSemana);

             Console.WriteLine(retorno);
             Console.ReadLine();

             //Fim Switch case com mais de uma opcao, com propriedades de classe*/

            /* comentario em bloco*/

            TesteForeach();



        }

        /// <summary>
        /// Foreach
        /// </summary>
        private static void TesteForeach()
        {
            foreach (var item in arrDiasSemana)
            {
                if (item == "Sabado")
                {
                    Console.WriteLine("Sabado é dia de dar banho no cachorro");
                }

                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// For
        /// </summary>
        private static void TEsteFor()
        {
            for (int indice = 0; indice <= arrayWhile.Length; indice++)
            {

                if(arrayWhile[indice] == 3)
                {
                    Console.WriteLine("achei meu numero!");
                    break;
                }
                Console.WriteLine(arrayWhile[indice]);
            }
        }

        /// <summary>
        /// continue
        /// </summary>
        private static void TEsteContinue()
        {
            int indice = 0;
            while (arrayWhile[indice] <= 5)
            {   
                if(arrayWhile[indice] == 3)
                {
                    break;
                }

                if (arrayWhile[indice] <4)
                {
                    indice++;
                    continue;
                }

             
                Console.WriteLine(arrayWhile[indice]);

            }
        }

        /// <summary>
        /// Break
        /// </summary>
        private static void TesteBreak()
        {
            int indice = 0;
            while (arrayWhile[indice] < 5)
            {

                if(arrayWhile[indice] == 3)
                { break; }
                Console.WriteLine(arrayWhile[indice]);
                indice++;

            }
        }

        /// <summary>
        /// Do While
        /// </summary>
        private static void PercorreDOWhile()
        {
            int indice = 0;
            do
            {
                Console.WriteLine(arrayWhile[indice]);
                indice++;

            } while (arrayWhile[indice] < 5);
        }

        /// <summary>
        /// Whilie
        /// </summary>
        private static void PercorreWhile( )
        {
            int indice = 0;
            while (arrayWhile[indice] < 5)
            {
                Console.WriteLine(arrayWhile[indice]);
                indice++;

            }

        }

        //Apenas exemplo para mostrar as formas de inicializar um array
        private static void InicializarArray()
        {
            // Array unidimensional de 5 inteiros .
            int[] array1 = new int[5];
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;
            array1[3] = 40;
            array1[4] = 50;

            // Declarar e setar valores nos array.
            int[] array2 = new int[] { 10, 20, 30, 40, 50 };

            // sintaxe alteranativa
            int[] array3 = { 10, 20, 30, 40, 50 };

            // Array de 2 dimensões - matriz.
            int[,] multiDimensionalArray1 = new int[2, 3];
            multiDimensionalArray1[0, 0] = 10;
            multiDimensionalArray1[0, 1] = 20;
            multiDimensionalArray1[0, 2] = 30;

            multiDimensionalArray1[1, 0] = 40;
            multiDimensionalArray1[1, 1] = 50;
            multiDimensionalArray1[1, 2] = 60;

            // Declarar e setar elementos no array .
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declarar um jagged array (array de array).
            int[][] jaggedArray = new int[6][];

            // Setar valores no primeiro array de um jagged array.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = array1;
        }

        /// <summary>
        /// 6 - Switch case com mais de uma opcao, com propriedades de classe GetDiasUteis
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        static string GetDiasUteis(clsDiasSemana dia) => dia switch
        {
            var (dia1, dia2) when dia1 == DiaUteisSemana.Segunda && dia2 == DiaUteisSemana.Quarta => "faço balé",
            var (dia1, dia2) when dia1 == DiaUteisSemana.Terca && dia2 == DiaUteisSemana.Quinta=> "academia",
            var (dia1, dia2) when dia1 == DiaUteisSemana.Quarta && dia2 == DiaUteisSemana.Sexta => "Vou pro bar",
            var (_, _) =>"Dia não especificado",
            _ => "Dia inexistente"
        };

        /// <summary>
        /// 5 - Switch case Com duas condições RetornarDiasDeAula
        /// </summary>
        /// <param name="dia1"></param>
        /// <param name="dia2"></param>
        /// <returns></returns>
        public static string RetornarDiasDeAula(DiaUteisSemana dia1, DiaUteisSemana dia2)
    => (dia1, dia2) switch
    {
        (DiaUteisSemana.Segunda, DiaUteisSemana.Quarta) => "Faço balé",
        (DiaUteisSemana.Terca, DiaUteisSemana.Quinta) => "Academia",
        (DiaUteisSemana.Quarta, DiaUteisSemana.Sexta) => "Vou pro bar",
         //default
         (_, _) => "Dias não especificados"

        //if(dia1 == "Segunda" && dia2 == "Quarta"){...}
    };

     

        /// <summary>
        /// 4 - SwitchCase2
        /// </summary>
        /// <param name="diaSemana"></param>
        /// <returns></returns>
        public static string SwitchCase2(DiaUteisSemana diaSemana) =>
   diaSemana switch
   {
       DiaUteisSemana.Segunda => "Inicio da Semana",
       DiaUteisSemana.Terca => "Semana Caminhando",
       DiaUteisSemana.Quarta => "Metade da Semana",
       DiaUteisSemana.Quinta => "Final de semana chegando",
       DiaUteisSemana.Sexta => "Sextou",
       _ => throw new ArgumentException(message: "Dias não uteis", paramName: nameof(diaSemana)),
   };

        /// <summary>
        /// 3 - switchCaseClasse - switch case com parametro de classe
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="preco"></param>
        /// <returns></returns>
        public static decimal switchCaseClasse(clsDiasSemana dia, decimal preco) => dia switch
        {
            { DiaSemanaProperty: DiaUteisSemana.Segunda } => preco * 0.06M,
            { DiaSemanaProperty: DiaUteisSemana.Quarta } => preco * 0.05M,
            _ => 0M
        };

        /// <summary>
        /// 2 - Teste Switch Case no C#
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        static string showSwitchCase(DiaUteisSemana dia)
        {
            string retorno = string.Empty; // "";
            switch (dia)
            {
                case DiaUteisSemana.Segunda:
                    retorno =  "Iniciou a Semana";
                    break;
                    //return "string"
                case DiaUteisSemana.Terca:
      
                    retorno = "Semana caminhando";
                    break;
                case DiaUteisSemana.Quarta:
                    retorno = "Metade da semana";
                    break;
                case DiaUteisSemana.Quinta:
                    retorno = "final de semana chegando!";
                    break;
                case DiaUteisSemana.Sexta:
                    retorno = "sextou!";
                    break;
                default:
                    retorno = "final de semana!";
                    break;
            }
            return retorno;
        }

        /// <summary>
        ///  1 - Teste IF ELSE
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        static string showCondition(DiaUteisSemana dia)
        {
            if (dia == DiaUteisSemana.Segunda)
            {
                return "Iniciou a semana";
            }
            else if(dia == DiaUteisSemana.Terca)
            {
                return "Já estamos no caminho";
            }
            else if (dia == DiaUteisSemana.Quarta)
            {
                return "Metade da semana já";
            }
            else if (dia == DiaUteisSemana.Quinta)
            {
                return "final de semana chegando";
            }
            else if(dia == DiaUteisSemana.Sexta)
            {
                return "sextou!";
            }
            else
            {
                return "Final de semana!";
            }
            
        }
    }
}
