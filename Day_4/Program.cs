namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
