namespace g10;

internal class Program
{
    static void Main(string[] texts)
    {
        //25.Rostlikga tekshiring a, b va c sonlari berilgan. 
        //Eng kattasi a.

        Console.Write("1 son kiriting : ");
        var firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("2 son kiriting : ");
        var secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("3 son kiriting : ");
        var thirdNumber = Convert.ToInt32(Console.ReadLine());

        var result = (firstNumber > secondNumber && firstNumber > thirdNumber);

        Console.WriteLine(result);

        Main(texts);
    }
}