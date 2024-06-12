public class Exercise1
{
    public static void Main( )
    {    
        int a, b, c;

        System.Console.WriteLine("\nInsira o primeiro numero: ");
        a = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("\nInsira o segundo numero: ");
        b = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("\nInsira o segundo numero: ");
        c = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine(a + " x " + b + " x " + c + " = " + a*b*c );
    }
}