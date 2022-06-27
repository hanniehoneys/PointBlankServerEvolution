// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Account.Players.PlayerStats
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System;

namespace PointBlank.Core.Models.Account.Players
{
  public class PlayerStats
  {
    public int fights;
    public int fights_win;
    public int fights_lost;
    public int fights_draw;
    public int kills_count;
    public int totalkills_count;
    public int totalfights_count;
    public int deaths_count;
    public int escapes;
    public int headshots_count;
    public int assist;
    public int ClanGames;
    public int ClanWins;
    public int ClanLoses;

    public int GetKDRatio()
    {
      if (this.headshots_count <= 0 && this.kills_count <= 0)
        return 0;
      return (int) Math.Floor(((double) (this.kills_count * 100) + 0.5) / (double) (this.kills_count + this.deaths_count));
    }

    public int GetHSRatio()
    {
      if (this.kills_count <= 0)
        return 0;
      return (int) Math.Floor((double) (this.headshots_count * 100) / (double) this.kills_count + 0.5);
    }
  }
}
