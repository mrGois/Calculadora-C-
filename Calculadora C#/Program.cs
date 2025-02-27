namespace Calculadora_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            string operacao;

            Console.WriteLine("Escolha a operação que deseja realizar: -, +");
            operacao = Console.ReadLine();
            
            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());


            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine($"O resultado da soma {num1} e {num2} é de: {resultado}");
                    break;

                case "-":
                    resultado = (num1 - num2);
                    Console.WriteLine($"O resultado da subtração {num1} e {num2} é de: {resultado}");
                    break;



            }
        }
    }
}
