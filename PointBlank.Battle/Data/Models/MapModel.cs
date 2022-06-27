// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Data.Models.MapModel
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using System.Collections.Generic;

namespace PointBlank.Battle.Data.Models
{
  public class MapModel
  {
    public List<ObjectModel> Objects = new List<ObjectModel>();
    public List<BombPosition> Bombs = new List<BombPosition>();
    public int Id;

    public BombPosition GetBomb(int BombId)
    {
      try
      {
        return this.Bombs[BombId];
      }
      catch
      {
        return (BombPosition) null;
      }
    }
  }
}
