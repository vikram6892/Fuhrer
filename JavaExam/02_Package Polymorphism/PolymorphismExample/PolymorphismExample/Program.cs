using System;

namespace PolymorphismExample
{
    public abstract class PlainDataObject
    {
        public int idNumber = 99;
        public String dataName = "No name";

        public PlainDataObject() { }

        public PlainDataObject(int id, String name)
        {
            idNumber = id;
            dataName = name;
        }

        public void print()
        {
            Console.WriteLine("DataObject : {0}, name : {1}", idNumber, dataName);
            return;
        }
    }

    public class ExtendedDataObject : PlainDataObject{
        public int value;

        public ExtendedDataObject():base()
        {
            base.idNumber = 33;
            base.dataName = "extendedDO";
            value = 44;
        }

        public ExtendedDataObject(int num, String name){
            dataName = name;
            value = num;
        }

        public void print(){
            base.print();
            Console.WriteLine(" value: " + value);
        }
    }

    public class AltDataObject : PlainDataObject{
        protected int value = 10;

        AltDataObject() { }
        AltDataObject(String name)
        {
            dataName = name;
            value = 333;
        }
        public void print()
        {
            base.print();
            int tmp = value + idNumber;
            Console.WriteLine("tmp: " + tmp);
        }
    }

    /*
    public class LastDataObject : AltDataObject
    {
        private String dataMsg;
        protected LastDataObject() { }

        LastDataObject(String msg){
            dataMsg = msg;
        }
        
        public void print(){
            base.print();
            Console.WriteLine("Last Data Object : " + dataMsg);
        }
    }
    */

    class Program
    {
        public static void Main(string[] args)
        {
            PlainDataObject myObject = new ExtendedDataObject();
            myObject.print();
            Console.WriteLine();
        }
    }
}
