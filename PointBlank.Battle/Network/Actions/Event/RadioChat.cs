// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.Event.RadioChat
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models;
using PointBlank.Battle.Data.Models.Event;

namespace PointBlank.Battle.Network.Actions.Event
{
  public class RadioChat
  {
    public static RadioChatInfo ReadSyncInfo(
      ActionModel ac,
      ReceivePacket p,
      bool genLog)
    {
      RadioChatInfo radioChatInfo = new RadioChatInfo() { RadioId = p.readC(), AreaId = p.readC() };
      if (genLog)
        Logger.warning("Slot: " + (object) ac.Slot + " Radio: " + (object) radioChatInfo.RadioId + " Area: " + (object) radioChatInfo.AreaId);
      return radioChatInfo;
    }

    public static void WriteInfo(SendPacket s, ActionModel ac, ReceivePacket p, bool genLog)
    {
      RadioChatInfo radioChatInfo = RadioChat.ReadSyncInfo(ac, p, genLog);
      s.writeC(radioChatInfo.RadioId);
      s.writeC(radioChatInfo.AreaId);
    }
  }
}
