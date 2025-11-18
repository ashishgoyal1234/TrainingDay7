using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSimpleInterface.DataAccess
{
    internal class CustomerDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Created");
        }

        public void Read()
        {
            Console.WriteLine("Customer Read");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted");
        }
    }
}
