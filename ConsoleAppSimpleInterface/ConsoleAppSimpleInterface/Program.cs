using ConsoleAppSimpleInterface.DataAccess;
using System;

namespace ConsoleAppSimpleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new OrderDb());
            DoDbOperations(new CustomerDb());
            DoDbOperations(new InvoiceDb());
        }

        static void DoDbOperations(ICrudable obj)
        {
            Console.WriteLine( );
            Console.WriteLine(obj.GetType());
            Console.WriteLine("Doing db operations");
            obj.Create();
            obj.Read();
            obj.Delete();
            obj.Update();
        }
    }
}
