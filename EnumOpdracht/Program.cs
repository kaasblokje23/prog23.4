namespace EnumOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colors myMainThemeColor = Colors.Red;
            Console.WriteLine("Hello, World!");

            if (myMainThemeColor == Colors.Red)
            {
                Console.WriteLine("dat is mijn kleur!");
            }
            else
                Console.WriteLine("idioot...");
        }
    }
}