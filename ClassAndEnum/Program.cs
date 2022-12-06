// See https://aka.ms/new-console-template for more informati
using ClassAndEnum;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dog=0");
        Console.WriteLine("Cat=1");
        Console.WriteLine("Fish=2");
        Console.WriteLine("Birds=3");
        int a = Convert.ToInt16(Console.ReadLine());
        switch (a)
        {
            case 0:
                string dog = AnimalClass.Haff.ToString();
                Console.WriteLine(dog);
                 break;
            case 1:
                string cat = AnimalClass.Myau.ToString();
                Console.WriteLine(cat);
                break;
            case 2:
                string fish = AnimalClass.Blk.ToString();
                Console.WriteLine(fish);
                break;
            case 3:
                string birds = AnimalClass.Tiv.ToString();
                Console.WriteLine(birds);
                break;
            default:
                break;

        }






    }
}