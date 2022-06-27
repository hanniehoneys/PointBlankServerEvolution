// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_START_KICKVOTE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Room;
using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_START_KICKVOTE_ACK : SendPacket
  {
    private VoteKick vote;

    public PROTOCOL_BATTLE_START_KICKVOTE_ACK(VoteKick vote)
    {
      this.vote = vote;
    }

    public override void write()
    {
      this.writeH((short) 3399);
      this.writeC((byte) this.vote.creatorIdx);
      this.writeC((byte) this.vote.victimIdx);
      this.writeC((byte) this.vote.motive);
    }
  }
}
