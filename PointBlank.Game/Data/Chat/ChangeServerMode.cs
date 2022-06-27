// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Chat.ChangeServerMode
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Game.Data.Configs;

namespace PointBlank.Game.Data.Chat
{
  public static class ChangeServerMode
  {
    public static string EnableTestMode()
    {
      if (GameConfig.isTestMode)
        return Translation.GetLabel("AlreadyTestModeOn");
      GameConfig.isTestMode = true;
      return Translation.GetLabel("TestModeOn");
    }

    public static string EnablePublicMode()
    {
      if (!GameConfig.isTestMode)
        return Translation.GetLabel("AlreadyTestModeOff");
      GameConfig.isTestMode = false;
      return Translation.GetLabel("TestModeOff");
    }
  }
}
