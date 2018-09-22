using System;

namespace demo
{
  class NumberManipulator
  {
    public string swap(int x, int y)
    {
      int temp;

      temp = x; /* 保存 x 的值 */
      x = y;    /* 把 y 赋值给 x */
      y = temp; /* 把 temp 赋值给 y */
      return "x: "+x+",\t"+"y: "+y;
    }

    static void Main(string[] args)
    {
      NumberManipulator n = new NumberManipulator();
      /* 局部变量定义 */
      int a = 100;
      int b = 200;

      Console.WriteLine("在交换之前，a 的值： {0}", a);
      Console.WriteLine("在交换之前，b 的值： {0}", b);

      /* 调用函数来交换值 */
      n.swap(a, b);
      Console.WriteLine("交换后的结果 {0}",n.swap(a, b));
      Console.WriteLine("在交换之后，a 的值： {0}", a);
      Console.WriteLine("在交换之后，b 的值： {0}", b);

      Console.ReadLine();
    }
  }
}
