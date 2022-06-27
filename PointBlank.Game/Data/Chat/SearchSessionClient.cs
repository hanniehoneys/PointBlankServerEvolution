// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Chat.SearchSessionClient
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

namespace PointBlank.Game.Data.Chat
{
  public static class SearchSessionClient
  {
    public static string genCode1(string str)
    {
      GameManager.SearchActiveClient(uint.Parse(str.Substring(13)));
      return "";
    }
  }
}
