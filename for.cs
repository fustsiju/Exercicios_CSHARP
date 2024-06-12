public class Exercise1
{
    public static void Main( )
    {    
        int a;

        System.Console.WriteLine("\nInsira o numero a ser multiplicado: ");
        a = int.Parse(System.Console.ReadLine());
		
		for(int i = 0; i <= 10; i++){
			System.Console.WriteLine(a + " x " + i + " = " + a * i);
		}

        
    }
}