// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

{
    int[] num = new int [8];
 num[ 0] = 0;
num [1] = 1;
Console.WriteLine(num[0]);
Console.WriteLine(num[1]);
for (int i=2;i< num.Length;i++)
{
    num[i] = num[i-1] + num[i-2];
    Console.WriteLine (num [i]);
    }
   }
Console.WriteLine();
{
    string [] months = new string[12] { "January", "Fabruary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    for (int i = 0; i < months.Length; i++)
    { 
        Console.WriteLine(months[i]); 
    }
}
Console.WriteLine();
{
    int[,] a = new int [3, 3];
    int b = a[0, 0] = 2;
    int c = a[0, 1] = 3;
    int d = a[0, 2] = 4;
    for (int i = 0; i < 3; i++)
    { for (int j = 0; j < 3; j++)
        {
            a[i,j] = (int)Math.Pow(a[0,j], i+1);
            Console.WriteLine(a[i,j]);
        }
    }
 }
Console.WriteLine();
{
    double[][] mass = new double[3][];
    mass[0] = new double[5];
    mass[1] = new double[2];
    mass[2] = new double[4];

    for(int i = 0;i < mass[0].Length;i++)
    {
        mass[0][i] = i+1;
        Console.WriteLine(mass[0][i]);
    }
    Console.WriteLine();
    for (int i = 0;i<2;i++)
    {
        if (i == 0)
        { 
            mass[1][i] = Math.PI; 
            Console.WriteLine(mass[1][i]);
        }
        else 
        {
            mass[1][i] = Math.E; 
        Console.WriteLine(mass[1][i]);
        }
    }
    Console.WriteLine() ;
    for (int i = 0; i < mass[2].Length;i++)
    {
        double c = (int)Math.Pow(10,i);
        
        mass[2][i] = Math.Log10(c);
        Console.WriteLine(mass[2][i]);
    }
}
Console.WriteLine() ;

int[] array = { 1, 2, 3, 4, 5 };
int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
Array.Copy(array, 0, array2, 0, 3);
foreach (int i in array2)
{ Console.WriteLine(i); }
Console.WriteLine() ;

Array.Resize(ref array, 10);
foreach (var i in array)
{
    Console.WriteLine(i);
}
