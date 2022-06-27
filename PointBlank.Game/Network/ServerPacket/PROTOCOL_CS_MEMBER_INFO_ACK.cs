// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_MEMBER_INFO_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;
using System.Collections.Generic;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_MEMBER_INFO_ACK : SendPacket
  {
    private List<Account> _players;

    public PROTOCOL_CS_MEMBER_INFO_ACK(List<Account> players)
    {
      this._players = players;
    }

    public override void write()
    {
      this.writeH((short) 1869);
      this.writeC((byte) this._players.Count);
      for (int index = 0; index < this._players.Count; ++index)
      {
        Account player = this._players[index];
        this.writeC((byte) (player.player_name.Length + 1));
        this.writeUnicode(player.player_name, true);
        this.writeQ(player.player_id);
        this.writeQ(ComDiv.GetClanStatus(player._status, player._isOnline));
        this.writeC((byte) player._rank);
        this.writeC((byte) player.name_color);
      }
    }
  }
}
