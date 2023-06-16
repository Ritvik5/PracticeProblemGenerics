namespace PracticeProblemGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic array deletion!!!\n");

            //-- Using Object array non generic method
            DeleteArray array = new DeleteArray();
            //object[] arr = { 10, 20, 30.14, 5, 'A', 2.84 };
            //array.DeleteElement(arr, 5);

            //-- Using generic method

            int[] arr1 = {10,20,30,40,50};
            array.DeleteMethod(ref arr1, 40);
            
        }
    }
}