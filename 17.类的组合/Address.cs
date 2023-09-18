using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.类的组合
{
    internal class Address
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Contry { get; set; }

        public string Info()
        {
            return $"{this.Contry} - {this.City} - {this.Street}";
        }
    }
    internal class Person
    {
        public string? Name { get; set; }
        public Address? Addr { get; set; }

        public void Printf()
        {
            Console.WriteLine($"----{this.Name}----");
            if ( Addr != null )
            {
                Console.WriteLine($"地址为：{Addr.Info()}");
            }
            else
            {
                Console.WriteLine("地址不详");
            }
        }

    }
}
