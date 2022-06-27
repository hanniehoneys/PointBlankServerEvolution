// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Xml.BattleServer
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using System.Net;

namespace PointBlank.Game.Data.Xml
{
  public class BattleServer
  {
    public string IP;
    public int Port;
    public int SyncPort;
    public IPEndPoint Connection;

    public BattleServer(string ip, int syncPort)
    {
      this.IP = ip;
      this.SyncPort = syncPort;
      this.Connection = new IPEndPoint(IPAddress.Parse(ip), syncPort);
    }
  }
}
