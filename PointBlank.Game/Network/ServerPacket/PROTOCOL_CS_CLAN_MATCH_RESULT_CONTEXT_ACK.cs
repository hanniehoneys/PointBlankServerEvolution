// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_CLAN_MATCH_RESULT_CONTEXT_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using System;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_CLAN_MATCH_RESULT_CONTEXT_ACK : SendPacket
  {
    private int matchCount;

    public PROTOCOL_CS_CLAN_MATCH_RESULT_CONTEXT_ACK(int count)
    {
      this.matchCount = count;
    }

    public override void write()
    {
      this.writeH((short) 1955);
      this.writeC((byte) this.matchCount);
      this.writeC((byte) 13);
      this.writeC((byte) Math.Ceiling((double) this.matchCount / 13.0));
    }
  }
}
