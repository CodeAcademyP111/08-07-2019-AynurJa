using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public enum Months:byte { Yanvar=1,Fevral,Mart,Aprel,May};
        public enum JsonResult { Error,Success,DataNotFound };
        static void Main(string[] args)
        {
            #region HomeWork
            //int n = 9;
            //n.FindSimpleNum();

            //string str = "AzerbAycan";

            //Console.WriteLine(str.MyLastIndexOf('A')); 
            #endregion

            #region Nullable
            //int? a = 5;
            //char? c = 'c';
            //c = null;
            //a = null;
            #endregion

            #region Enum
            //foreach (var item in Enum.GetNames(typeof(Months)))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Struct
            //Position position = new Position();
            //position.X = 500;
            //Position p = position;
            //p.X = 600;

            //Console.WriteLine($"position.X : {position.X} ,p.X : {p.X}");

            //Total total = new Total();
            //total.X = 500;
            //Total t = total;
            //t.X = 600;
            //Console.WriteLine($"total.X : {total.X} ,t.X : {t.X}");
            #endregion

        }
    }

    #region Struct
    //public struct Position
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int? Z { get; set; }

    //    public Position(int y)
    //    {
    //        X = 5;
    //        Y = y;
    //        Z = null;

    //    }

    //    public Position(int x, int y,int z)
    //    {
    //        X = x;
    //        Y = y+z;
    //        Z = y + x;
    //    }
    //}

    //class Total
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //}
    #endregion

    class Person
    {
    }

    class Woman : Person,IRunable,IEatable
    {
        public int Run(int x)
        {
            return x;
        }

        public void Eat()
        {

        }
    }

    interface IRunable
    {
        int Run(int x);
    }

    interface IEatable
    {
        void Eat();
    }



}
