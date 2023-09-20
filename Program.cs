using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDeAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Empleado
    {
        private string Nombre;
        private double Salario;
        public Empleado(string nombre) 
        {
         this.Nombre = nombre;
        }

        public void SetSalario(double salario) 
        {
         if(salario > 0) 
            {
                Console.WriteLine("El salario no puede ser negativo. se asignara 0 como salario");
                this.Salario = 0;
            }
         else
            {
                this.Salario = salario;
            }
        }
        public double GetSalario() 
        {
         return Salario;
        }
    }
}
