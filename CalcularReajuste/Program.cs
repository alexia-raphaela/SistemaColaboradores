using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CalcularReajuste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool saida = false;
            do
            {
                Console.WriteLine("Digite o nome do colaborador");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o cargo do colaborador");
                string cargo = Console.ReadLine();

                Console.WriteLine("Digite o salário do colaborador");
                double salario = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de admissao");
                String dataAdmissao = Console.ReadLine();

                DateTime dataAdmissaoParsed = DateTime.Parse(dataAdmissao);

                

                DateTime Date = DateTime.Today;

                TimeSpan Intervalo = Date - dataAdmissaoParsed;
                int anos = Intervalo.Days / 365;

                if (anos >= 3)
                {
                    ColaboradoresAntigos c1 = new ColaboradoresAntigos(nome, cargo, salario, dataAdmissao);
                    double salarioColaborador = c1.getSalario();

                    double percentual;

                    if (salarioColaborador > 7000)
                    {
                        percentual = 10;
                        c1.setReajuste(percentual);
                    } else
                    {
                        
                        do
                        {
                            Console.WriteLine("Digite o percentual a solicitar, entre 0.1 e 10%");
                            percentual = double.Parse(Console.ReadLine());

                        } while (percentual <= 0 || percentual >= 10);

                        c1.setReajuste(percentual);
                    }
                    c1.MostrarColaborador();
                } else
                {
                    Colaboradores colaborador = new Colaboradores(nome, cargo, salario, dataAdmissao);
                    colaborador.MostrarColaborador();
                }
                
                Console.WriteLine("Deseja encerrar? (sim/nao)");
                string saidaSistema = Console.ReadLine();

                switch (saidaSistema)
                {
                    case "sim":
                        saida = true; break;

                    case "nao":
                        saida = false; break;

                    default: saida = false; break;
                }
                
            } while (!saida);

            if (!saida)
            {
                Console.Read();
            }









          
        }
    }
}
