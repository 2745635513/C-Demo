using System;

namespace demo
{
  class NumberManipulator
  {

    class MyArray
    {

      static void Main(string[] args)
      {
        int[] list = { 34, 72, 13, 44, 25, 30, 10 };

        Console.Write("原始数组： ");
        foreach (int i in list)
        {
          Console.Write(i + " ");
        }
        Console.WriteLine();

        // 逆转数组
        Array.Reverse(list);
        Console.Write("逆转数组： ");
        foreach (int i in list)
        {
          Console.Write(i + " ");
        }
        Console.WriteLine();

        // 逆转排序数组
        Array.Sort(list);
        Array.Reverse(list);
        Console.Write("排序数组： ");
        foreach (int i in list)
        {
          Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.ReadKey();
      }
    }
  }
}
