using Calculadora;

Console.WriteLine();
Console.WriteLine("Calculos basicos:");
Console.WriteLine("Index      *");
Console.WriteLine("  0        +");
Console.WriteLine("  1        -");
Console.WriteLine("  2        /");
Console.WriteLine("  3        x");
Console.WriteLine("  4        ^");

while (true)
{
    try
    {
        Console.WriteLine();
        Console.Write("Informe o index da operacao: ");
        string? resultado = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Informe o primeiro numero: ");
        string? value1 = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Informe o segundo numero: ");
        string? value2 = Console.ReadLine();
        decimal valuUm;
        decimal valuDois;
        if (decimal.TryParse(value1, out valuUm) && decimal.TryParse(value2, out valuDois) && !string.IsNullOrEmpty(resultado))
        {
            Matematica matematica = new Matematica();
            switch (resultado.ToUpper())
            {
                case "0":
                    {
                        Console.WriteLine("Resultado adição: {0}", matematica.Adicao(valuUm, valuDois));
                        break;
                    }
                case "1":
                    {
                        Console.WriteLine("Resultado subtração: {0}", matematica.Subtracao(valuUm, valuDois));
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Resultado divisão: {0}", matematica.Divisao(valuUm, valuDois));
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Resultado multiplicação: {0}", matematica.Multiplicacao(valuUm, valuDois));
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Resultado potencia: {0}", matematica.Potencia(valuUm, valuDois));
                        break;
                    }
            }
        }
        else
        {
            break;
        }
    }
    catch (Exception e) 
    { 
        Console.WriteLine("Menssagem: {0} Exception: {1}", e.Message, e.InnerException); 
        break;
    }
}