using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GenericData<T> where T : class, new()
    {
        public T data { get; set; }

        public void print(T data) {
            Console.WriteLine(data);
        
        }
    }
}
