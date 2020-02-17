using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace InterfaceExample
{
    public interface ITransactions{
        void showTransaction();
        double getAmount();
    }

    public class Transaction : ITransactions{
        // Private Field Variables
        private string tCode;
        private string date;
        private double amount;

        // Empty Constructor
        public Transaction(){
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        // Parameterized Constructor
        public Transaction(string _tCode, string _date, double _amount){
            tCode = _tCode;
            date = _date;
            amount = _amount;
        }

        // Interface Method
        public void showTransaction(){
            Console.WriteLine("Transaction : {0}", tCode);
            Console.WriteLine("Date : {0}", date); ;
            Console.WriteLine("Amount : {0}", amount);
        }

        // Interface Method
        public double getAmount(){
            return amount;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 82400.00);

            t1.showTransaction();
            t1.getAmount();

            t2.showTransaction();
            t2.getAmount();
        }
    }
}
