using System;
using System.IO;
using System.Text;

class Program
{
  static void Main()
  {
    ReadLineAsync("log-dummy.csv");
  }

  static async void ReadLineAsync(string file)
  {
    using (StreamReader reader = new StreamReader(
      file, Encoding.GetEncoding("Shift_JIS")
    ))
    {
      string line;
      int count = 1;
      while((line = await reader.ReadLineAsync()) != null)
      {
        Console.WriteLine(count++);
        Console.WriteLine(line);
      }
    }
  }
}