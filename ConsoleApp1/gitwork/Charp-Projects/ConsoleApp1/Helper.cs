using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Helper <T>  where T: IComparable<T>
    {
        public static void Swap(ref T x,ref T y) {
            T temp = x;
            x = y;
            y = temp;
        
        }
        public static bool search(T[] arr, T item) { 
            if (arr == null) return false;
            for (int i = 0; i < arr.Length; i++) {
                if(arr[i].Equals(item)) return true;

            }
            return false;

        }

        public static void bubblesort(T[] arr) {
            if (arr!=null)
            {
                for (int i = 0; i < arr.Length; i++) {
                    for (int j = 0; j < arr.Length; j++) {
                        if (arr[j].CompareTo(arr[j + 1]) == 1) Swap(ref arr[j],ref arr[j + 1]);
                    }
                }
            }

        }

        public int CompareTo(T? other)
        {
            if(other != null){
                if (this.Equals(other)) return 0;

                else return(this.CompareTo(other));
            }
            return 0;

        }
    }
}
