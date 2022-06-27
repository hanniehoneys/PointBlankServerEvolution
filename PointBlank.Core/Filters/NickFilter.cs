// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Filters.NickFilter
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System;
using System.Collections.Generic;
using System.IO;

namespace PointBlank.Core.Filters
{
  public static class NickFilter
  {
    public static List<string> _filter = new List<string>();

    public static void Load()
    {
      if (File.Exists("Data/Filters/Nicks.txt"))
      {
        try
        {
          using (StreamReader streamReader = new StreamReader("Data/Filters/Nicks.txt"))
          {
            string str;
            while ((str = streamReader.ReadLine()) != null)
              NickFilter._filter.Add(str);
            streamReader.Close();
          }
        }
        catch (Exception ex)
        {
          Logger.error("Filter: " + ex.ToString());
        }
      }
      else
        Logger.warning("Filter file does not exist.");
    }
  }
}
