// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.Event.HpSync
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

namespace PointBlank.Battle.Network.Actions.Event
{
  public class HpSync
  {
    public static ushort ReadInfo(ReceivePacket p, bool genLog)
    {
      return p.readUH();
    }

    public static void ReadInfo(ReceivePacket p)
    {
      p.Advance(2);
    }

    public static void writeInfo(SendPacket s, ReceivePacket p, bool genLog)
    {
      s.writeH(HpSync.ReadInfo(p, genLog));
    }
  }
}
