using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_Introdução.Models
{
    public class Calculadora
    {
        //Método
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
         public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
         public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x*y}");
        }
         public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void Potencia (int x , int y){
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno (double angulo){
            double Radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(Radiano);
            Console.WriteLine($"Seno de {angulo} é igual {Math.Round(seno, 4)}");
        }
          public void Coseno (double angulo){
            double Radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(Radiano);
            Console.WriteLine($"Coseno de {angulo} é igual {Math.Round(coseno, 4)}");
        }
        public void Tangente (double angulo){
            double Radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(Radiano);
            Console.WriteLine($"tangente de {angulo} é igual {Math.Round(tangente, 4)}");
        }

        public void raizQuadrada (double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {raiz}");
        }
    }
}