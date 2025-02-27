namespace Calculadora_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("escolha a operação: +, -, *, /");
            String? operacao = Console.ReadLine();

            if (string.IsNullOrEmpty(operacao))

                Console.WriteLine("Digite o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case "*":
                    resultado = Multiplicar(num1, num2);
                    break;
                case "/":
                    resultado = Dividir(num1, num2);
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;

            }
            Console.WriteLine($"Resultado: {resultado}");

            static double Multiplicar(double a, double b)
            {
                return a * b;
            }

            static double Dividir(double a, double b)
            {
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero.");
                    return 0;

                }
            }
        }
    }
}
