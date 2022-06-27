// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.Event.ActionForObjectSync
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models;
using PointBlank.Battle.Data.Models.Event.Event;

namespace PointBlank.Battle.Network.Actions.Event
{
  public class ActionForObjectSync
  {
    public static ActionObjectInfo ReadSyncInfo(
      ActionModel ac,
      ReceivePacket p,
      bool genLog)
    {
      ActionObjectInfo actionObjectInfo = new ActionObjectInfo() { Unk1 = p.readC(), Unk2 = p.readC() };
      if (genLog)
        Logger.warning("Slot: " + (object) ac.Slot + " ActionForObjectSync: Unk (" + (object) actionObjectInfo.Unk1 + ";" + (object) actionObjectInfo.Unk2 + ")");
      return actionObjectInfo;
    }

    public static void WriteInfo(SendPacket s, ActionModel ac, ReceivePacket p, bool genLog)
    {
      ActionObjectInfo actionObjectInfo = ActionForObjectSync.ReadSyncInfo(ac, p, genLog);
      s.writeC(actionObjectInfo.Unk1);
      s.writeC(actionObjectInfo.Unk2);
    }
  }
}
