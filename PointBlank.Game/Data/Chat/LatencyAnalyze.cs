// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Chat.LatencyAnalyze
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Models.Enums;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Data.Chat
{
  public static class LatencyAnalyze
  {
    public static string StartAnalyze(Account player, Room room)
    {
      if (room == null)
        return Translation.GetLabel("GeneralRoomInvalid");
      if (room.getSlot(player._slotId).state != SlotState.BATTLE)
        return Translation.GetLabel("LatencyInfoError");
      player.DebugPing = !player.DebugPing;
      if (player.DebugPing)
        return Translation.GetLabel("LatencyInfoOn");
      return Translation.GetLabel("LatencyInfoOff");
    }
  }
}
