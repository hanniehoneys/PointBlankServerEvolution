// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_MEMBER_INFO_INSERT_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_MEMBER_INFO_INSERT_ACK : SendPacket
  {
    private Account p;
    private ulong status;

    public PROTOCOL_CS_MEMBER_INFO_INSERT_ACK(Account pl)
    {
      this.p = pl;
      this.status = ComDiv.GetClanStatus(pl._status, pl._isOnline);
    }

    public override void write()
    {
      this.writeH((short) 1871);
      this.writeC((byte) (this.p.player_name.Length + 1));
      this.writeUnicode(this.p.player_name, true);
      this.writeQ(this.p.player_id);
      this.writeQ(this.status);
      this.writeC((byte) this.p._rank);
      this.writeC((byte) this.p.name_color);
    }
  }
}
