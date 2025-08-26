using Part_Three___OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Prepend(1);
        list.Prepend(2);
        list.Prepend(3);
        Console.WriteLine(list);
        //Console.WriteLine(list.Pop());
        //Console.WriteLine(list);
        //Console.WriteLine(list.Pop());
        //Console.WriteLine(list);
        //list.Append(4);
        //list.Append(5);
        //Console.WriteLine(list);
        //Console.WriteLine(list.Unqueue());
        //foreach (int value in list.ToList())
        //{
        //    Console.Write(value+" ");
        //}
        //list.Append(4);
        //list.Append(1);
        //list.Append(3);
        //list.Append(1);
        //list.Head.Next.Next.Next.Next = list.Head;
        //Console.WriteLine(list.IsCircular());
        //Console.WriteLine(list.ToString());
        //foreach (int item in list.ToList())
        //{
        //    Console.Write(item + " ");
        //}
        //list.Sort();
        //Console.WriteLine(list.ToString());
        Console.WriteLine(list.Max?.Value);
        Console.WriteLine(list.Min?.Value);
        list.Append(1);
        list.Append(2);
        list.Append(5);
        list.Append(7);
        Console.WriteLine(list);
        Console.WriteLine("----");
        Console.WriteLine(list.Max.Value);
        Console.WriteLine(list.Min.Value);
        list.Pop();
        list.Unqueue();
        Console.WriteLine("----");
        Console.WriteLine(list.Max.Value);
        Console.WriteLine(list.Min.Value);
        list.Append(10);
        Console.WriteLine("----");
        Console.WriteLine(list.Max.Value);
        Console.WriteLine(list.Min.Value);



    }
}