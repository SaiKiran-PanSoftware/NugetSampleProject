using System;
using ProjectA;

namespace TestProjectA
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new BaseService();
            Console.WriteLine(obj.GetBaseData());
            Console.WriteLine(obj.GetDerviedData());
            Console.WriteLine(obj.GetNewService());
            Console.ReadLine();
        }
    }
}
