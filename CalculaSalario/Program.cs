using System;
using System.Globalization;

namespace CalculaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numeroFunc, horasTrabalhadas;
                double valorHora, salario;

                Console.WriteLine("Digite o número do funcionário:");
                numeroFunc = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número de horas trabalhadas:");
                horasTrabalhadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da hora trabalhada:");
                valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                salario = horasTrabalhadas * valorHora;

                Console.WriteLine($"NUMBER = {numeroFunc}");
                Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
