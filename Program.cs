namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Введіть довжину вектора:");
            string temp = Console.ReadLine();
            int length = Convert.ToInt32(temp);
            Console.WriteLine("Введіть кут під яким знаходиться вектор:");
            temp = Console.ReadLine();
            int angle = Convert.ToInt32(temp);
            Vector A = new Vector(angle, length);
            Console.WriteLine("Координати вектора:");
            Console.WriteLine(A.Coordinates);
        }

    }
}