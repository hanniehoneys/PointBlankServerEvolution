// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_CS_MEMBER_INFO_CHANGE_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Data.Model;
using PointBlank.Core.Models.Enums;
using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_CS_MEMBER_INFO_CHANGE_ACK : SendPacket
  {
    private ulong status;
    private Account member;

    public PROTOCOL_CS_MEMBER_INFO_CHANGE_ACK(Account player)
    {
      this.member = player;
      this.status = ComDiv.GetClanStatus(player._status, player._isOnline);
    }

    public PROTOCOL_CS_MEMBER_INFO_CHANGE_ACK(Account player, FriendState st)
    {
      this.member = player;
      if (st == FriendState.None)
        this.status = ComDiv.GetClanStatus(player._status, player._isOnline);
      else
        this.status = ComDiv.GetClanStatus(st);
    }

    public override void write()
    {
      this.writeH((short) 1875);
      this.writeQ(this.member.player_id);
      this.writeQ(this.status);
    }
  }
}
