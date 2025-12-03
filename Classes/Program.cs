namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           var carOne = new Car();
           carOne.Make = "BMW";
           carOne.Model = "IXL";
           carOne.year = 2005;
           
           Console.WriteLine($"this is a {carOne.Make} {carOne.Model}, made in the year {carOne.year}");
        }
    }
}
