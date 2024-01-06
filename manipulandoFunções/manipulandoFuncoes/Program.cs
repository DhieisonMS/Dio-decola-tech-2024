using System;

class Program
{
    static void Main()
    {
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());
       
       double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
       Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
       Console.ReadLine();
    }

    static double CalcularPegadaDeCarbono(double quilometros, int horas, int refeicoes )
    {
        const double fatorQuilometrosPorDia = 0.2;
        const double fatorHorasDeEletronicos = 0.1;
        const double fatorRefeicoesComCarne = 0.5;

        double result = (quilometros * 365 * fatorQuilometrosPorDia)+
                        (horas * fatorHorasDeEletronicos) +
                        (refeicoes * fatorRefeicoesComCarne);
        
        return result;
    }
    
}
