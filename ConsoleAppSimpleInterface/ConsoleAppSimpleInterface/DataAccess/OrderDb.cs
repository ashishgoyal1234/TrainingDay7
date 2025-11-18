using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSimpleInterface.DataAccess
{
    internal class OrderDb:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Order Created");
        }

        public void Read()
        {
            Console.WriteLine("Order Read");
        }

        public void Update()
        {
            Console.WriteLine("Order Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Order Deleted");
        }
    }
}
