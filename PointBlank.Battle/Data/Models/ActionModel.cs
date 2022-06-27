// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Data.Models.ActionModel
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Enums;

namespace PointBlank.Battle.Data.Models
{
  public class ActionModel
  {
    public ushort Slot;
    public ushort Length;
    public UDP_GAME_EVENTS Flag;
    public UDP_SUB_HEAD SubHead;
    public byte[] Data;
  }
}
