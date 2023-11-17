//using System.Collections;
//using System.Diagnostics;
//using System.Net.Http.Headers;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography;
//using System.Xml.Schema;

//using System.Collections;
//using System.Diagnostics;
//using System.Net.Http.Headers;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography;
//using System.Xml.Schema;
using System.Xml.Schema;

namespace SomaMedia{
    class Program{
        static void Main(string[] args){
            
            List <decimal> numerosRecebidos = new List<decimal>();

            Console.Write("Digite a quantidade de números que deseja inserir: ");
            
            int quantidadeNumeros;

            for (quantidadeNumeros = int.Parse(Console.ReadLine()!);quantidadeNumeros < 3 || quantidadeNumeros > 10; quantidadeNumeros = int.Parse(Console.ReadLine()!)){
                 Console.Write("Valor invalido, insira um valor válido: ");
            }
            
            var listaDeValores = ColetaValores(quantidadeNumeros);
            
            Console.WriteLine("VALOR DA SOMA DOS NUMEROS INSERIDOS É: "+CalculoSoma(listaDeValores));
            Console.WriteLine("VALOR DA MEDIA DOS NUMEROS INSERIDOS É: "+CalculoMedia(listaDeValores));
            Console.WriteLine("VALOR DA MEDIA DOS NUMEROS INSERIDOS É: "+listaDeValores.Average());
            Console.WriteLine("VALOR DA SOMA DOS NUMEROS INSERIDOS É: "+listaDeValores.Sum());

            }
        static List <decimal> ColetaValores (int quantidadeNumeros){

            List<decimal> listaDeValores = new List<decimal>(quantidadeNumeros);

            for (int i=0; i < quantidadeNumeros; i++){

                Console.Write($"Insira o {i+1}º valor: ");
                listaDeValores.Add(decimal.Parse(Console.ReadLine()!));

            }
            return listaDeValores;
        }
        static decimal CalculoSoma(List<decimal> listaDeValores){

            decimal total = 0;

            foreach (decimal soma in listaDeValores){

                total += soma;
            }

            return total;
        }
        static decimal CalculoMedia(List <decimal> listaDeValores){

            decimal soma = CalculoSoma(listaDeValores);

            decimal media = soma / listaDeValores.Count; 


            return media;
        }
    }
}
