// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.Event.ActionState
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models;
using PointBlank.Battle.Data.Models.Event;

namespace PointBlank.Battle.Network.Actions.Event
{
  public class ActionState
  {
    public static ActionStateInfo ReadInfo(
      ReceivePacket p,
      ActionModel ac,
      bool genLog)
    {
      ActionStateInfo actionStateInfo = new ActionStateInfo() { Action = p.readUD() };
      if (!genLog);
      return actionStateInfo;
    }

    public static void WriteInfo(SendPacket s, ActionModel ac, ReceivePacket p, bool genLog)
    {
      ActionStateInfo info = ActionState.ReadInfo(p, ac, genLog);
      ActionState.WriteInfo(s, info);
    }

    public static void WriteInfo(SendPacket s, ActionStateInfo info)
    {
      s.writeD(info.Action);
    }
  }
}
