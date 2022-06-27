// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Chat.EnableMissions
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Managers.Server;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Data.Chat
{
  public static class EnableMissions
  {
    public static string genCode1(string str, Account player)
    {
      bool mission = bool.Parse(str.Substring(8));
      if (!ServerConfigSyncer.updateMission(GameManager.Config, mission))
        return Translation.GetLabel("ActivateMissionsMsg2");
      Logger.warning(Translation.GetLabel("ActivateMissionsWarn", (object) mission, (object) player.player_name));
      return Translation.GetLabel("ActivateMissionsMsg1");
    }
  }
}
