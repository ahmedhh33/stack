namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack(5);
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);
            mystack.Push(6);//it dos not pushed 
            Console.WriteLine(mystack.Pop());//delet the last pushed one 5
            Console.WriteLine(mystack.peak());//shows the top element 4
            Console.WriteLine(mystack.Pop());//delet 4
            mystack.Push(6);//add 6
            Console.WriteLine(mystack.peak());//shows 6

        }
    }
}