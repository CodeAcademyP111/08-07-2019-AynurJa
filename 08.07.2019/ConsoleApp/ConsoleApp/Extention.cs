using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public static class Extention
    {
        #region MyRegion
        //public static void FindSimpleNum(this int number)
        //{
        //    int count = 0;
        //    for (int i = 1; i <= number; i++)
        //    {

        //        if (number % i == 0)
        //        {
        //            count++;
        //        }
        //    }


        //    if (count > 2)
        //    {
        //        Console.WriteLine("Murekkeb ededdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sade ededdir");
        //    }



        //}
        #endregion


        public static int MyLastIndexOf(this string a,char b)
        {
            int index = -1;
            for (int i = a.Length-1; i >=0; i--)
            {
                if (a[i]==b)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

    }
}
