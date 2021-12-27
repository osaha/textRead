using System;
using System.IO;
using System.Text;

class ReadAllLines
{
  static void Main()
  {
    string[] lines = File.ReadAllLines(
      "log-dummy.csv", Encoding.GetEncoding("Shift_JIS")
    );
    foreach (var item in lines)
    {
      Console.WriteLine(item);
    }

    Console.WriteLine(lines[1]);
    Console.WriteLine(lines[1].Length);
  }
}