namespace PracticeProblemGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic array deletion!!!\n");

            DeleteArray array = new DeleteArray();


            object[] arr = { 10, 20, 30.14, 5, 'A', 2.84 };

            array.DeleteElement(arr, 5);
        }
    }
}