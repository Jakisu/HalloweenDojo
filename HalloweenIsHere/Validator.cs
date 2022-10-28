using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenIsHere
{
    public class Validator
    {
        public void MostrarCaracteres(string palavra)
        {
            Console.WriteLine(palavra.Length);
        }

        public void MostrarVogais(string palavra)
        {
            var rules = "aieou";
            palavra = "Halloween is Here";
            int vogais = palavra.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));
            Console.WriteLine($"Quantidade de vogais: {vogais}");
        }

        public void MostrarConsoantes(string palavra)
        {
            int consoantes = palavra.Count(x => (x != 'a') && (x != 'e') && (x != 'i') && (x != 'o') && (x != 'u'));
            Console.WriteLine($"Quantidade de consoantes: {consoantes}");
        }


        public int MostrarMaísculo(string palavra)
        {   
            
            var contadorMai = 0;
            
            for (int i = 0; i < palavra.Length; i++)
            {
                if (char.IsUpper(palavra[i]))
                {
                    contadorMai++;
                }

            }
            return contadorMai; 
        }

        public int MostrarMinusculo(string palavra)
        {
            int contadorMin = 0;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (char.IsLower(palavra[i]))
                {
                    contadorMin++;
                }

            }
            return contadorMin;
        }


        public int MostrarPalavras(string palavra)
        {

            string[] rules = {"Halloween", "is", "here"};
            var total = 0;
            
                foreach (var item in rules)
                {
                    if (palavra.Contains(item))
                    {
                        total++;
                    }
                }
            return total;

        }
        //public void MostrarConsoantes(int contadorMai, int contadorMin, int vogais)
        //{
        //    int consoantes = palavra.Count(x => (x != 'a') && (x != 'e') && (x != 'i') && (x != 'o') && (x != 'u'));
        //    Console.WriteLine($"Quantidade de consoantes: {consoantes}");

        //    //int somaMaiMin = contadorMai + contadorMin;
        //    //int consoantes = somaMaiMin - vogais;
        //    //Console.WriteLine(consoantes);
        //}

    }
}
