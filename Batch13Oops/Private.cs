using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class PrivateClass
    {
        private int Privatefield;

        public void setfield(int value)
        {
            Privatefield = value;

        }
        public void show()
        {
            Console.WriteLine("Private field value" + Privatefield);
        }
    }
    class Private
    {
        static void Main()
        {
            PrivateClass obj = new PrivateClass();
            obj.setfield(10);
            obj.show();
        }
    }
}
