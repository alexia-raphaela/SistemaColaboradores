using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularReajuste
{
    public class Colaboradores : IColaboradores
    {
        private string nome;
        private string cargo;
        private double salario;
        private string dataAdmissao;

        // coisas de fora que vem da instancia
        public Colaboradores(string name, string occupation, double salary, string admissionDate) 
        {
            nome = name;
            cargo = occupation;
            salario= salary;
            dataAdmissao = admissionDate;

        }
        public string getNome()
        {
            return nome;
        }
        public string getCargo()
        {
            return cargo;
        }

        public double getSalario()
        {
            return salario;
        }

        public string getDataAdmissao()
        {
            return dataAdmissao;
        }

       public void MostrarColaborador()
        {
            Console.WriteLine("\nColaborador novo: " + "\n- nome: " + nome + "\n- cargo: " + cargo + "\n- salário base: " + salario + "\n- data de admissão: " + dataAdmissao + "\n");
        }
    }
}
