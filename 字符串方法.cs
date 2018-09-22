using System;

namespace demo
{
  class NumberManipulator
  {
    class Program
    {
      static void Main(string[] args)
      {
        //字符串，字符串连接
        string fname, lname;
        fname = "Rowan";
        lname = "Atkinson";

        string fullname = fname + lname;
        Console.WriteLine("Full Name: {0}", fullname);

        //通过使用 string 构造函数
        char[] letters = { 'H', 'e', 'l', 'l', 'o' };
        string greetings = new string(letters);
        Console.WriteLine("Greetings: {0}", greetings);

        //方法返回字符串
        string[] sarray = { "Nice", "To", "Meet", "You" };
        string message = String.Join(" ", sarray);
        Console.WriteLine("Message: {0}", message);

        //用于转化值的格式化方法
        DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
        string chat = String.Format("Message sent at {0:t} on {0:D}",
        waiting);
        Console.WriteLine("Message: {0}", chat);
        

        //分割字符串
         string testSplit = "hello,i am from China,hi,i am from America";
         string[] strSplit = testSplit.Split(",");
         foreach (var i in strSplit)
         {
             Console.WriteLine(i);
         }
         Console.ReadKey();
      }
    }
  }
}
