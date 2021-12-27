using System;
using System.Text;
using System.IO;

class FileRead2
{
  static void Main()
  {
    string text = "";

    using (StreamReader sr = new StreamReader(
      "log-dummy.csv", Encoding.GetEncoding("Shift_JIS")))
    {
      text = sr.ReadToEnd();
    }
    Console.WriteLine(text);
  }
}