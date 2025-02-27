namespace Calculadora_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("escolha a operação: +, -, *, /");
            Console.ReadLine();

            Console.WriteLine("Digite o primeiro número:");
            double num1 = convert.todouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;


        }
    }
}
