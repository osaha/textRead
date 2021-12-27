using System;
using System.IO;
using System.Text;

class Program
{
  static void Main()
  {
    foreach (string line in File.ReadLines(
      "log-dummy.csv", Encoding.GetEncoding("Shift_JIS")
    ))
    {
      Console.WriteLine(line);
    }

  }
}