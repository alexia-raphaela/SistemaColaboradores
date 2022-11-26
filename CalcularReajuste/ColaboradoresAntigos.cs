using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CalcularReajuste
{
    public class ColaboradoresAntigos : Colaboradores, IColaboradores
    {
        private double novoSalario;
        private double percentual;

        public ColaboradoresAntigos(string name, string occupation, double salary, string admissionDate) : base(name, occupation, salary, admissionDate)
        {
        }

        public void setReajuste(double percentual)
        {
            this.percentual = percentual;
            double salario = this.getSalario();

            novoSalario = salario + (salario * (percentual / 100));
        }

        //assinatura: a classe implementa obrigatóriamente os métodos da interface
        //implementar: dar uma ação ao método da interface
        public new void MostrarColaborador()
        {

            string nome = this.getNome();
            string cargo = this.getCargo();
            double salario =  this.getSalario();
            string dataAdmissao = this.getDataAdmissao();

            Console.WriteLine("\nColaborador antigo: " + "\n- nome: " + nome + "\n- cargo: " + cargo + "\n- salário base: "+ salario + "\n- data de admissão: " + dataAdmissao + "\n");
            Console.WriteLine("Seu salário sofreu um reajuste de " + this.percentual + "%. Novo salário: " + this.novoSalario + "\n");
        }
    }
}
