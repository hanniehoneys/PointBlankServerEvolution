﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.Event.FireNHitDataOnObject
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models;
using PointBlank.Battle.Data.Models.Event;
using PointBlank.Battle.Data.Sync;

namespace PointBlank.Battle.Network.Actions.Event
{
  public class FireNHitDataOnObject
  {
    public static FireNHitDataObjectInfo ReadInfo(
      ActionModel ac,
      ReceivePacket p,
      bool genLog)
    {
      FireNHitDataObjectInfo nhitDataObjectInfo = new FireNHitDataObjectInfo() { Portal = p.readUH() };
      if (genLog)
        Logger.warning("Slot: " + (object) ac.Slot + " passed on the portal [" + (object) nhitDataObjectInfo.Portal + "]");
      return nhitDataObjectInfo;
    }

    public static void ReadInfo(ReceivePacket p)
    {
      p.Advance(2);
    }

    public static void SendPassSync(Room room, Player p, FireNHitDataObjectInfo info)
    {
      BattleSync.SendPortalPass(room, p, (int) info.Portal);
    }

    public static void WriteInfo(SendPacket s, ActionModel ac, ReceivePacket p, bool genLog)
    {
      FireNHitDataObjectInfo info = FireNHitDataOnObject.ReadInfo(ac, p, genLog);
      FireNHitDataOnObject.WriteInfo(s, info);
    }

    public static void WriteInfo(SendPacket s, FireNHitDataObjectInfo info)
    {
      s.writeH(info.Portal);
    }
  }
}
