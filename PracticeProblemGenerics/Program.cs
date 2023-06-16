namespace PracticeProblemGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic array deletion!!!\n");

            //-- Using Object array non generic method
            //DeleteArray array = new DeleteArray();
            //object[] arr = { 10, 20, 30.14, 5, 'A', 2.84 };
            //array.DeleteElement(arr, 5);

            //-- Using generic method

            //int[] arr1 = {10,20,30,40,50};
            //array.DeleteMethod(ref arr1, 40);
            

            //-- Using Generic class 

            DeleteArray<int> array = new DeleteArray<int>();

            int[] arr = { 10, 20, 30, 31, 32, };

            array.DeleteMethod(arr, 32);

            Console.WriteLine("\n:::::::::::::::::::::::::::::\n");


            DeleteArray<double> array2 = new DeleteArray<double>();
            double[] arr2 = { 1.14,2.15,3.15,3.33,4.50 };

            array2.DeleteMethod(arr2, 3.15);
            Console.Read();
        }
    }
}