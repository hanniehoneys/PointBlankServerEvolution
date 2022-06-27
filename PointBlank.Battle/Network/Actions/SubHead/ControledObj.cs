// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.SubHead.ControledObj
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models.SubHead;
using System;

namespace PointBlank.Battle.Network.Actions.SubHead
{
  public class ControledObj
  {
    public static ControledInfo ReadSyncInfo(ReceivePacket p, bool genLog)
    {
      ControledInfo controledInfo = new ControledInfo() { _unk = p.readB(9) };
      if (genLog)
        Logger.warning("[ControledObj] " + BitConverter.ToString(controledInfo._unk));
      return controledInfo;
    }

    public static void WriteInfo(SendPacket s, ReceivePacket p, bool genLog)
    {
      ControledInfo controledInfo = ControledObj.ReadSyncInfo(p, genLog);
      s.writeB(controledInfo._unk);
    }
  }
}
