// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Room.VoteKick
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System.Collections.Generic;

namespace PointBlank.Core.Models.Room
{
  public class VoteKick
  {
    public int kikar = 1;
    public int deixar = 1;
    public List<int> _votes = new List<int>();
    public bool[] TotalArray = new bool[16];
    public int creatorIdx;
    public int victimIdx;
    public int motive;
    public int allies;
    public int enemys;

    public VoteKick(int creator, int victim)
    {
      this.creatorIdx = creator;
      this.victimIdx = victim;
      this._votes.Add(creator);
      this._votes.Add(victim);
    }

    public int GetInGamePlayers()
    {
      int num = 0;
      for (int index = 0; index < 16; ++index)
      {
        if (this.TotalArray[index])
          ++num;
      }
      return num;
    }
  }
}
