using BE.Helpers;
using CoreConsoleApp.Core;
using CoreConsoleApp.Core.DelegatesLambda;
using CoreConsoleApp.Core.Interfaces;
using CoreConsoleApp.Core.Variables;

namespace CoreConsoleApp
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PrintTriangle();
            PrimitiveTypes.DoUse();
            Comparable.DoUse();
            DelegatesLambdaSample.DoLinq();
            NullableTypes.DoUse();
            Console.WriteLine(DeviceHelper.MachineName);
            Console.WriteLine(DeviceHelper.NewLine);
            Console.WriteLine(DeviceHelper.OsVersion);
            Console.WriteLine(DeviceHelper.UserName);
            Console.WriteLine(DeviceHelper.UserName);
        }

        private static void PrintTriangle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}