// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_GET_MYINFO_RECORD_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Account.Players;
using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_GET_MYINFO_RECORD_ACK : SendPacket
  {
    private PlayerStats s;

    public PROTOCOL_BASE_GET_MYINFO_RECORD_ACK(PlayerStats s)
    {
      this.s = s;
    }

    public override void write()
    {
      this.writeH((short) 577);
      this.writeD(this.s.fights);
      this.writeD(this.s.fights_win);
      this.writeD(this.s.fights_lost);
      this.writeD(this.s.fights_draw);
      this.writeD(this.s.kills_count);
      this.writeD(this.s.headshots_count);
      this.writeD(this.s.deaths_count);
      this.writeD(this.s.totalfights_count);
      this.writeD(this.s.totalkills_count);
      this.writeD(this.s.escapes);
      this.writeD(this.s.assist);
      this.writeD(this.s.fights);
      this.writeD(this.s.fights_win);
      this.writeD(this.s.fights_lost);
      this.writeD(this.s.fights_draw);
      this.writeD(this.s.kills_count);
      this.writeD(this.s.headshots_count);
      this.writeD(this.s.deaths_count);
      this.writeD(this.s.totalfights_count);
      this.writeD(this.s.totalkills_count);
      this.writeD(this.s.escapes);
      this.writeD(this.s.assist);
    }
  }
}
