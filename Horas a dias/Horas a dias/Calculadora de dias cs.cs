using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horas_a_dias
{
    class Calculadora_de_dias_cs
    {

        public int Horas, Dias, Residuo;
        public Calculadora_de_dias_cs() 
        {
            Convertidor(Horas, Dias, Residuo);

          
            

           

        }
           
        public static void Convertidor(int hora,int dia,int residuo)
    {
        Console.WriteLine("Bienvenidos al convertidor de horas a dias");
        Console.WriteLine(" ");
        Console.Write("Ingrese las horas que quieras convertir a dias: ");
        hora = int.Parse(Console.ReadLine());

        dia = hora / 24;
        residuo = hora % 24;
        Console.WriteLine(" ");
        if (dia < 1)
        {
            Console.WriteLine("No Llega ni al dia" +residuo+" Horas ");
        }
        else 
        {
            Console.WriteLine("son "+dia+" Dias "+" "+" Con " +residuo+" Horas ");
        }
        }/*soy muy bueno*/


            
     
    }
            
        }

    
    

