public class Exercise1
{
    public static void Main( )
    {    
        int a, b, aux;

        System.Console.WriteLine("\nInsira o primeiro numero: ");
        a = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("\nInsira o segundo numero: ");
        b = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("\nOs numero são " + a + " e " + b);
        System.Console.WriteLine("\nRealizando trocas...");
        
        aux = a;
        a = b;
        b = aux;

        System.Console.WriteLine("Os numeros atualizados são " + a + " e " + b);
    }
}