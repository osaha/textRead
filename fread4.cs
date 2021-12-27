using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class FileRead4
{
  static void Main()
  {
    var array = new List<string>();

    using (StreamReader sr = new StreamReader(
      "log-dummy.txt", Encoding.GetEncoding("Shift_JIS")))
    {
      while((line = sr.ReadLine())!= null)
      {
        array.Add(line);
      }
    }

    foreach (var item in array)
    {
      Console.WriteLine(item);
    }
  }
}