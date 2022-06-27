// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_GET_RECORD_INFO_DB_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Account.Players;
using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_GET_RECORD_INFO_DB_ACK : SendPacket
  {
    private PlayerStats st;

    public PROTOCOL_BASE_GET_RECORD_INFO_DB_ACK(PlayerStats stats)
    {
      this.st = stats;
    }

    public override void write()
    {
      this.writeH((short) 559);
      if (this.st != null)
      {
        this.writeD(this.st.fights);
        this.writeD(this.st.fights_win);
        this.writeD(this.st.fights_lost);
        this.writeD(this.st.fights_draw);
        this.writeD(this.st.kills_count);
        this.writeD(this.st.headshots_count);
        this.writeD(this.st.deaths_count);
        this.writeD(this.st.totalfights_count);
        this.writeD(this.st.totalkills_count);
        this.writeD(this.st.escapes);
        this.writeD(this.st.assist);
        this.writeD(this.st.fights);
        this.writeD(this.st.fights_win);
        this.writeD(this.st.fights_lost);
        this.writeD(this.st.fights_draw);
        this.writeD(this.st.kills_count);
        this.writeD(this.st.headshots_count);
        this.writeD(this.st.deaths_count);
        this.writeD(this.st.totalfights_count);
        this.writeD(this.st.totalkills_count);
        this.writeD(this.st.escapes);
        this.writeD(this.st.assist);
      }
      else
        this.writeB(new byte[80]);
    }
  }
}
