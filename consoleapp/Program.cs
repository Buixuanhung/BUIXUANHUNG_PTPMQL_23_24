﻿internal class Program
{
    private static void Main(string[] args )
    {
        float a = 2;
        if ( a >= 8){
            System.Console.WriteLine("hoc sinh hoc luc gioi");
        } else if ( a>= 6.5){
            System.Console.WriteLine("hoc sinh hoc luc kha");
        } else if ( a>= 5){
            System.Console.WriteLine("hoc sinh hoc luc trung binh");
        } else if ( a>= 3.5){
            System.Console.WriteLine("hoc sinh hoc luc yeu");
        } else {
            System.Console.WriteLine("hoc sinh hoc luc kem");
        }
    }
}
