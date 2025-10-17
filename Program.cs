namespace Introducao_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao sistema.");

        // Entrada de Dados
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nOlá, {nome}! Você tem {idade} anos.");

        if (idade < 18)
        {
            Console.WriteLine("Você ainda é menor de idade.");
        }
        else
        {
            Console.WriteLine("Você já é maior de idade");
        }

        // Menu
        Console.WriteLine("\nEscolha uma opção: ");
        Console.WriteLine("1 - Ver a tabuada de um número: ");
        Console.WriteLine("2 - Contar até um número: ");
        Console.WriteLine("3 - Sequencia de fibonacci");
        Console.WriteLine("4 - Sair");
        Console.Write("Digite a sua opção: ");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao){
            case 1: 
            Console.WriteLine("Digite um número");
            int tabuada = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++){
                // opcao = opcao * i;
                Console.WriteLine(tabuada * i);
            }
            break;

            case 2: Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numero; i++){
                Console.WriteLine(i);
            }
            break;

            case 3:
            Console.WriteLine("Escolha o tamanho da sequencia de fibonacci");
            int numeroFibonacci = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int resultado = 0;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for (int i = 0; i < numeroFibonacci - 2; i++){
                resultado = n1 + n2;
                n1 = n2;
                n2 = resultado;
                Console.WriteLine(resultado);
            }
            break;

            default: 
            break;
        }
    }
}
  