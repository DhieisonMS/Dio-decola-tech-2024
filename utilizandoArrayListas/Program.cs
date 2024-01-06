using System;

class Program
{
    static void Main()
    {
        int quantidadeJogos = int.Parse(Console.ReadLine());
        string [] jogos = new string[quantidadeJogos];

        for (int i = 0; i < jogos.Length; i++ )
        {
            AdicionarJogo(i, jogos);
        }

        ExibirResumoAdicaoJogos(quantidadeJogos, jogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        string jogos = string.Join(", ", nomes);
        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {jogos} ao catalogo.");
    }
}