internal class ex1
{
    public static int GetNumLength(int number)
    {
        var result = number == 0 ? 1 : (int)Math.Ceiling(Math.Log10(number));
        return result;
       
    }
    //private static void Main(string[] args)
    //{
    //    Console.WriteLine(GetNumLength(0));
    //}
}