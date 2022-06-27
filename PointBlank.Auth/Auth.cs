// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Auth
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Network;
using PointBlank.Core.Xml;
using System;
using System.Threading.Tasks;

namespace PointBlank.Auth
{
  public class Auth
  {
    public static async void Update()
    {
      while (true)
      {
        Console.Title = "Point Blank - Auth [Users: " + (object) AuthManager._socketList.Count + " Online: " + (object) ServersXml.getServer(0)._LastCount + " Used RAM: " + (object) (GC.GetTotalMemory(true) / 1024L) + " KB]";
        ComDiv.updateDB("onlines", "auth", (object) ServersXml.getServer(0)._LastCount);
        await Task.Delay(1000);
      }
    }
  }
}
