// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Chat.AFKInteraction
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;

namespace PointBlank.Game.Data.Chat
{
  public static class AFKInteraction
  {
    public static string GetAFKCount(string str)
    {
      return Translation.GetLabel("AFK_Count_Success", (object) GameManager.KickCountActiveClient(double.Parse(str.Substring(9))));
    }

    public static string KickAFKPlayers(string str)
    {
      return Translation.GetLabel("AFK_Kick_Success", (object) GameManager.KickActiveClient(double.Parse(str.Substring(8))));
    }
  }
}
