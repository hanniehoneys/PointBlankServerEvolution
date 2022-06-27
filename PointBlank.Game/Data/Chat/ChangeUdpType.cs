// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Chat.ChangeUdpType
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Models.Enums;
using PointBlank.Game.Data.Configs;

namespace PointBlank.Game.Data.Chat
{
  public static class ChangeUdpType
  {
    public static string SetUdpType(string str)
    {
      int num = int.Parse(str.Substring(4));
      if ((UdpState) num == GameConfig.udpType)
        return Translation.GetLabel("ChangeUDPAlready");
      if (num < 1 || num > 4)
        return Translation.GetLabel("ChangeUDPWrongValue");
      GameConfig.udpType = (UdpState) num;
      return Translation.GetLabel("ChangeUDPSuccess", (object) GameConfig.udpType);
    }
  }
}
