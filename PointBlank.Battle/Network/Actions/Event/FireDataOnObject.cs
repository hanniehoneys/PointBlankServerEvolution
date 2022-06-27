// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.Event.FireDataOnObject
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models.Event;

namespace PointBlank.Battle.Network.Actions.Event
{
  public class FireDataOnObject
  {
    public static FireDataObjectInfo ReadInfo(ReceivePacket p, bool genLog)
    {
      return new FireDataObjectInfo() { ShotId = p.readUH() };
    }

    public static void ReadInfo(ReceivePacket p)
    {
      p.Advance(2);
    }

    public static void WriteInfo(SendPacket s, ReceivePacket p, bool genLog)
    {
      FireDataObjectInfo fireDataObjectInfo = FireDataOnObject.ReadInfo(p, genLog);
      s.writeH(fireDataObjectInfo.ShotId);
    }
  }
}
