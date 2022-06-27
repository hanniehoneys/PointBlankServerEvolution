// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Translation
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System.Collections.Generic;
using System.IO;

namespace PointBlank.Core
{
  public static class Translation
  {
    private static SortedList<string, string> strings = new SortedList<string, string>();

    public static void Load()
    {
      foreach (string readAllLine in File.ReadAllLines("Config/Translate/Strings.ini"))
      {
        int length = readAllLine.IndexOf("=");
        if (length >= 0)
        {
          string key = readAllLine.Substring(0, length);
          string str = readAllLine.Substring(length + 1);
          Translation.strings.Add(key, str);
        }
      }
    }

    public static string GetLabel(string title)
    {
      try
      {
        string str;
        if (Translation.strings.TryGetValue(title, out str))
          return str.Replace("\\n", '\n'.ToString());
        return title;
      }
      catch
      {
        return title;
      }
    }

    public static string GetLabel(string title, params object[] args)
    {
      return string.Format(Translation.GetLabel(title), args);
    }
  }
}
