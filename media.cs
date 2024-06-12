public class Exercise1
{
    public static void Main( )
    {    
        int a, b , c, d;

        System.Console.WriteLine("\nInsira o primeiro numero: ");
        a = int.Parse(System.Console.ReadLine());
		
        System.Console.WriteLine("\nInsira o segundo numero: ");
        b = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("\nInsira o terceiro numero: ");
        c = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("\nInsira o quarto numero: ");
        d = int.Parse(System.Console.ReadLine());

		int soma = a + b + c + d;
        int med = soma / 4;

        System.Console.WriteLine("A media dos valores: " + med);

        
    }
}