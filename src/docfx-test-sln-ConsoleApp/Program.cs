using docfx_test_sln_ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("数値を入力してください:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Class1 multiplier = new Class1();
            int result = multiplier.TestMethod(number);
            Console.WriteLine($"入力された数値の2倍は {result} です。");
        }
        else
        {
            Console.WriteLine("有効な数値を入力してください。");
        }
    }
}