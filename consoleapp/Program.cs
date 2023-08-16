internal class Program
{
    private static void Main(string[] args )
    {
        int a = 10;
        if ( a < 0 )
        {
            System.Console.WriteLine("{0} la so nguye am", a);

        } else {
            if ( a % 2 == 0){
                System.Console.WriteLine("{0} la so guyen duong chan", a);

            } else{
                System.Console.WriteLine("{0} La so nguyen duong le", a);
            }
        }
        
    }
}
