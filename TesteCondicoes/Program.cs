using System;

namespace TesteCondicoes
{

    class Program
    {

       static string[] arrDiasSemana = new string[] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };

       static int[] arrayWhile = new int[] { 1, 2, 3, 4, 5 };
        static void Main(string[] args)
        {
            //DiaSemana();

            //TesteTaxa();

            //TestarDoisDiasSemana();

            // TesteQuadrante();

            //InicializarArray();

            //PercorreWhile();

            //PercorreDOWhile();

            //TesteBreak();

            // TEsteContinue();
            // TEsteFor();

            TesteForeach();
            Console.ReadLine();


        }

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

        private static void PercorreDOWhile()
        {
            int indice = 0;
            do
            {
                Console.WriteLine(arrayWhile[indice]);
                indice++;

            } while (arrayWhile[indice] < 5);
        }

        private static void PercorreWhile( )
        {
            int indice = 0;
            while (arrayWhile[indice] < 5)
            {
                Console.WriteLine(arrayWhile[indice]);
                indice++;

            }

        }

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

        private static void TesteQuadrante()
        {
            Point pt = new Point(2, -4);

            Quadrant quadr = GetQuadrant(pt);

            Console.WriteLine(quadr);
            Console.ReadLine();
        }

        private static void TestarDoisDiasSemana()
        {
            string strNumReceb = Console.ReadLine();
            string strNumReceb2 = Console.ReadLine();

            int numReceb = Convert.ToInt32(strNumReceb);
            int numReceb2 = Convert.ToInt32(strNumReceb2);

            DiaUteisSemana diaSemana1 = (DiaUteisSemana)numReceb;
            DiaUteisSemana diaSemana2 = (DiaUteisSemana)numReceb2;

            string retorno = RetornarDiasDeAula(diaSemana1, diaSemana2);

            Console.WriteLine(retorno);
        }

        static Quadrant GetQuadrant(Point point) => point switch
        {
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            var (_, _) => Quadrant.OnBorder,
            _ => Quadrant.Unknown
        };

        public static string RetornarDiasDeAula(DiaUteisSemana dia1, DiaUteisSemana dia2)
    => (dia1, dia2) switch
    {
        (DiaUteisSemana.Segunda, DiaUteisSemana.Quarta) => "Faço balé",
        (DiaUteisSemana.Terca, DiaUteisSemana.Quinta) => "Academia",
        (DiaUteisSemana.Quarta, DiaUteisSemana.Sexta) => "Vou pro bar",
         //default
         (_, _) => "Final de Semana"
    };

        private static void TesteTaxa()
        {
            Address objAddress = new Address();
            objAddress.State = Console.ReadLine();


            decimal valorTotal = ComputeSalesTax(objAddress, 20);
            Console.WriteLine(String.Format("Valor total é : ", valorTotal));
        }

        static void DiaSemana()
        { 
            string strNumReceb = Console.ReadLine();
            int numReceb = Convert.ToInt32(strNumReceb);

            DiaUteisSemana diaSemana = (DiaUteisSemana)numReceb;

             Console.WriteLine(FromDiaDaSemana(diaSemana));
        }

        //Switch case no c#8.0
        public static string FromDiaDaSemana(DiaUteisSemana diaSemana) =>
   diaSemana switch
   {
       DiaUteisSemana.Segunda => "Inicio da Semana",
       DiaUteisSemana.Terca => "Semana Caminhando",
       DiaUteisSemana.Quarta => "Metade da Semana",
       DiaUteisSemana.Quinta => "Final de semana chegando",
       DiaUteisSemana.Sexta => "Sextou",
       _ => throw new ArgumentException(message: "Dias não uteis", paramName: nameof(diaSemana)),
   };

        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
   location switch
   {
       { State: "SP" } => salePrice * 0.06M,
       { State: "MG" } => salePrice * 0.075M,
       { State: "RJ" } => salePrice * 0.05M,

        //Default igual a 0
        _ => 0M
   };


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
