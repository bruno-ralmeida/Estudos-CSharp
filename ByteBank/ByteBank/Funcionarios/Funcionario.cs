using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        public string Nome { set; get; }
        public string  CPF{ get; set; }
        public double Salario{ get; set; }

      
        public virtual double GetBonification()
        {
            return Salario * 0.10;
        }


        public string ToString()
        {
            return $"Nome: {Nome} \nCPF: {CPF} \nSalario: {Salario:C} \nBonificação: {GetBonification():C} ";
             
        }

        
    }
}
