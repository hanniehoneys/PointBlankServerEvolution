// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Model.SlotMatch
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Enums;

namespace PointBlank.Game.Data.Model
{
  public class SlotMatch
  {
    public SlotMatchState state;
    public long _playerId;
    public long _id;

    public SlotMatch(int slot)
    {
      this._id = (long) slot;
    }
  }
}
