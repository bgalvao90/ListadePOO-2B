while (true)
{
    try
    {
        string input;
        Console.Write("Digite o número A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o número B: ");
        int b = int.Parse(Console.ReadLine());

        int calcularDivisao = a / b;
        Console.WriteLine($"Resultado da divisão: {calcularDivisao}");
        Console.WriteLine("Digite 'sair' para encerrar o programa ou pressione Enter para continuar.");
        input = Console.ReadLine();
        if (input.ToLower() == "sair")
        {
            Console.WriteLine("Programa encerrado pelo usuário.");
            return;
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Erro: Valor inválido. Digite um número inteiro.");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Erro: Não é possível dividir por zero...");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Operação finalizada.");
    }
}