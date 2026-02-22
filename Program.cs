using System;

class Program
{
    static void Main()
    {
        Console.Title = "Verificador de Bandeira de Cartão";

        Console.WriteLine("--- Validador de Cartão de Crédito ---");
        Console.Write("Digite o número do cartão (apenas números): ");

        string numero = Console.ReadLine().Replace(" ", ""); 

        if (string.IsNullOrEmpty(numero) || !long.TryParse(numero, out _))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro: Por favor, insira um número válido.");
            return;
        }

        string bandeira = IdentificarBandeira(numero);

        Console.ResetColor();
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine($"Resultado: {bandeira}");
        Console.WriteLine("------------------------------------");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static string IdentificarBandeira(string n)
    {
        if (n.StartsWith("4"))
            return "Visa";

        if (n.StartsWith("34") || n.StartsWith("37"))
            return "American Express (Amex)";

        if (n.StartsWith("6011") || n.StartsWith("644") || n.StartsWith("65"))
            return "Discover";

        int prefixo2 = int.Parse(n.Substring(0, Math.Min(2, n.Length)));
        int prefixo4 = int.Parse(n.Substring(0, Math.Min(4, n.Length)));

        if ((prefixo2 >= 51 && prefixo2 <= 55) || (prefixo4 >= 2221 && prefixo4 <= 2720))
            return "Mastercard";

        if (n.StartsWith("4011") || n.StartsWith("4389") || n.StartsWith("4576") || n.StartsWith("5041") || n.StartsWith("6363"))
            return "Elo";

        if (n.StartsWith("38") || n.StartsWith("60"))
            return "Hipercard";

        return "Bandeira desconhecida ou não mapeada.";
    }
}