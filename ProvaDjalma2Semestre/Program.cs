using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDjalma2Semestre
{
    class Program
    {
        static void Main(string[] args)
        {

            ////NOME: Rita de Cassia Franca Faria       RA: 6322054
            
            ////1 - Faça um programa que receba o nome do aluno, nota de trabalho, nota da prova 1 e nota da prova 2.Calcule a média 
            ////final(média simples) e apresente o conceito obtido seguindo a seguinte formula:
            ////O conceito da será calculado da seguinte forma:
            
            ////Se a nota final for maior ou igual a 8.5, então o conceito é A.
            ////Se a nota final estiver entre 7.0 e 8.4, então o conceito é B.
            ////Se a nota final estiver entre 6.0 e 6.9, então o conceito é C.
            ////Se a nota final estiver entre 0.1 e 5.9, então o conceito é D.
            ////Se a nota final for igual a 0.0, então o conceito é E.

            double n2, n3, n4, media;
            string nome;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a sua nota de trabalho");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua nota da prova 1");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua nota de prova 2");
            n4 = double.Parse(Console.ReadLine());

            media = ((n2 + n3 + n4) / 3);

            if (media > 8.5)
            {
                Console.WriteLine(" Conceito final : A");
            }
            if (media >= 7.0 == media <= 8.4)
            {
                Console.WriteLine(" Conceito final : B");
            }
            if (media >= 6.0 == media <= 6.9)
            {
                Console.WriteLine(" Conceito final : C");
            }
            if (media >= 0.1 == media <= 5.9)
            {
                Console.WriteLine(" Conceito final : D");
            }
            if (media == 0.0)
            {
                Console.WriteLine(" Conceito final : E");
            }



            //********************************************************************************************************************************************************

            ////NOME: Rita de Cassia Franca Faria      RA: 6322054

            ////2 – Fazer um programa para que mostre uma lista de cidades para o usuário e que ele informe o código da cidade escolhida.
            ////Em seguida pedir uma data para o usuário. Ao final deve ser apresentada em tela a data completa em formato extenso longo,
            ////juntamente com a cidade escolhida. 

            ////Exemplo: Bragança Paulista, 29 de junho de 2022.

            ////A relação das cidades é a seguinte:

            ////1 – Atibaia
            ////2 – Bragança Paulista
            ////3 – Mairiporã
            ////4 – Nazaré
            ////5 – Terra Preta
            ////6 – Extrema
            ////7 – Vargem

            ////Requisitos: Criar uma função para converter a data em extenso.

            double codi;

            Console.WriteLine("\t Dentre as cidades proposta, informe o codico da cidade escolhida :\n\n Atibaia(1) : Bragança Paulista(2) : Mairiporã(3) : Nazaré(4) : Terra Preta(5) : Extrama(6) : Vargem(7)");
            codi = int.Parse(Console.ReadLine());

            string mesextenso = null;
            Console.WriteLine("Digite a data desejada em números separados por barra (Ex: 28/03/2021): ");
            var datan = Convert.ToDateTime(Console.ReadLine());

            int datames, datadia, dataano;
            datames = datan.Month;
            datadia = datan.Day;
            dataano = datan.Year;

            switch (datames)
            {
                case 1:
                    mesextenso = "Janeiro";
                    break;
                case 2:
                    mesextenso = "Fevereiro";
                    break;
                case 3:
                    mesextenso = "Março";
                    break;
                case 4:
                    mesextenso = "Abril";
                    break;
                case 5:
                    mesextenso = "Maio";
                    break;
                case 6:
                    mesextenso = "Junho";
                    break;
                case 7:
                    mesextenso = "Julho";
                    break;
                case 8:
                    mesextenso = "Agosto";
                    break;
                case 9:
                    mesextenso = "Setembro";
                    break;
                case 10:
                    mesextenso = "Outubro";
                    break;
                case 11:
                    mesextenso = "Novembro";
                    break;
                case 12:
                    mesextenso = "Dezembro";
                    break;
            }


            if (codi == 1)
            {
                Console.WriteLine($"\n \t Atibaia,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 2)
            {
                Console.WriteLine($"\n \t Bragança Paulista,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 3)
            {
                Console.WriteLine($"\n \t Maitiporã,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 4)
            {
                Console.WriteLine($"\n \t Nazaré,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 5)
            {
                Console.WriteLine($"\n \t Terra Preta,  {datadia} de {mesextenso} de {dataano}");
            }
            if (codi == 6)
            {
                Console.WriteLine($"\n \t Extrema, {datadia} de {mesextenso} de {dataano}.");
            }
            if (codi == 7)
            {
                Console.WriteLine($"\n \t Vargem,  {datadia} de {mesextenso} de {dataano}.");
            }

 //**********************************************************************************************************************************************************

            ////NOME: Rita de Cassia Franca Faria          RA: 6322054

            ////3 – Criar um programa para calcular e mostrar a área de 3 figuras geométricas diferentes, não vale quadrado e nem retângulo.
            ////Observação: as figuras são de escolha livre, dá um Google se não lembrar como faz o cálculo de alguma delas.
            ////Requisitos: Deve ser apresentada uma lista para o usuário com o nome das 3 figuras que ele pode escolher para calcular
            ////.Deve - se utilizar Switch Case.

            ;

            Console.WriteLine("Dentre as três figuras, escolha uma para ser calculada a àrea \n \n \t 1 Triângulo: 2 Losango : 3 Trapézio");

            int numero = Convert.ToInt32(Console.ReadLine());
            string figura = null;


            switch (numero)
            {
                case 1: figura = "Triângulo"; break;
                case 2: figura = "Losango"; break;
                case 3: figura = "Trapézio"; break;

            }

            if (figura == "Triângulo")
            {
                Console.WriteLine("Digite quanto vale a Base:");
                double baset = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite quanto vale a Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = (baset * altura) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }
            else if (figura == "Losango")
            {
                Console.WriteLine("Digite o valor da Diagonal maior:");
                double diagmaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Diagonal menor:");
                double diaglmenor = Convert.ToDouble(Console.ReadLine());

                double area = (diagmaior * diaglmenor) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }

            if (figura == "Trapézio")
            {
                Console.WriteLine("Digite o valor da Base maior:");
                double basemaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Base maior:");
                double basemenor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = ((basemaior + basemenor) * altura) / 2;
                Console.WriteLine($"A área do {figura} é de {area} cm2");
            }

            Console.WriteLine("\n\t\t Vamos outra vez, porem com outra figura?\n\n Dentre as três figuras, escolha uma para ser calculada a àrea \n \n \t 1 Triângulo: 2 Losango : 3 Trapézio\n");

            switch (numero)
            {
                case 1: figura = "Triângulo"; break;
                case 2: figura = "Losango"; break;
                case 3: figura = "Trapézio"; break;

            }

            if (figura == "Triângulo")
            {
                Console.WriteLine("Digite quanto vale a Base:");
                double baset = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite quanto vale a Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = (baset * altura) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }
            else if (figura == "Losango")
            {
                Console.WriteLine("Digite o valor da Diagonal maior:");
                double diagmaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Diagonal menor:");
                double diaglmenor = Convert.ToDouble(Console.ReadLine());

                double area = (diagmaior * diaglmenor) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }

            if (figura == "Trapézio")
            {
                Console.WriteLine("Digite o valor da Base maior:");
                double basemaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Base maior:");
                double basemenor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = ((basemaior + basemenor) * altura) / 2;
                Console.WriteLine($"A área do {figura} é de {area} cm2");
            }

 //***************************************************************************************************************************************


            ////NOME: Rita de Cassia Franca Faria      RA: 6322054
            //// 4 – Utilizando estrutura FOR, escrever um programa para exibir os números de 1 até 50 na tela.
            int i;

            for (i = 1; i <= 50; i++)
            {
                Console.WriteLine(i * 1);
            }
            Console.ReadLine();



//***************************************************************************************************************************************

            //// NOME: Rita de Cássia Franca Faria RA: 6322054
            //// 5 - Fazer um programa para encontrar todos os números pares entre 1 e 100.
            int i;

            for(i = 1 ; i <= 50; i++ )
            {
                Console.WriteLine(i * 2);
            }
            Console.ReadLine();

 //****************************************************************************************************************************************

            Console.ReadKey();

        }
    }
}
