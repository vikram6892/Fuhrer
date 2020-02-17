using System;

namespace FIRSTOBJECT
{
    public class FirstObject
    {
        int objectState;

        public FirstObject(int aState)
        {
            objectState = aState;
        }

        public void printState(int num)
        {
            int sum = num + objectState;
            Console.WriteLine(sum);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            FirstObject objectA = new FirstObject(1234);
            FirstObject objectB = new FirstObject(5432);

            objectA.printState(66);
        }
    }
}
