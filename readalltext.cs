using System;
using System.IO;
using System.Text;

class ReadAllText
{
  static void Main()
  {
    string text = File.ReadAllText(
      "log-dummy.txt", Encoding.GetEncoding("Shift_JIS")
    );
    Console.WriteLine(text);
  }
}