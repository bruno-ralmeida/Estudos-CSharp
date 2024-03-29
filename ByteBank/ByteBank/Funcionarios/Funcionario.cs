﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
            Console.WriteLine("Criando Funcionario");
            Console.WriteLine(TotalFuncionarios);
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();


    }
}
