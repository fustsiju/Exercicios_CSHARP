public class Exercise1
{
    public static void Main( )
    {
         int num;
         bool conf = 1;
         while(conf == 1){
            System.Console.Write("Insira um numero de 1 a 10: ");
            num = System.Convert.ToInt32(System.Console.ReadLine());
            if(num > 10 || num == 0){
                System.Console.Write("Seu número não se enquadra ao intervalo proposto. Tente novamente...");
            }else{
                conf = 0
            }
        }

        if(num == 1){
            System.Console.Write(" {0} ", num);
            System.Console.Write("{0}{0} ", num);
            System.Console.Write(" {0} ", num);
            System.Console.Write(" {0} ", num);
            System.Console.Write(" {0} ", num);
            System.Console.Write("{0}{0}{0}", num);
        }

    }
}