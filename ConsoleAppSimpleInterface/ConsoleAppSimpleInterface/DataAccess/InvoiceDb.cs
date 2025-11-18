using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSimpleInterface.DataAccess
{
    internal class InvoiceDb:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Invoice Created");
        }

        public void Read()
        {
            Console.WriteLine("Invoice Read");
        }

        public void Update()
        {
            Console.WriteLine("Invoice Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Invoice Deleted");
        }
    }
}
