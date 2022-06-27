// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CLAN_WAR_CREATE_ROOM_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CLAN_WAR_CREATE_ROOM_ACK : SendPacket
  {
    public Match _mt;

    public PROTOCOL_CLAN_WAR_CREATE_ROOM_ACK(Match match)
    {
      this._mt = match;
    }

    public override void write()
    {
      this.writeH((short) 1564);
      this.writeH((short) this._mt._matchId);
      this.writeD(this._mt.getServerInfo());
      this.writeH((short) this._mt.getServerInfo());
      this.writeC((byte) 10);
    }
  }
}
