// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CLAN_WAR_MATCH_TEAM_COUNT_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using System;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CLAN_WAR_MATCH_TEAM_COUNT_ACK : SendPacket
  {
    private int count;

    public PROTOCOL_CLAN_WAR_MATCH_TEAM_COUNT_ACK(int count)
    {
      this.count = count;
    }

    public override void write()
    {
      this.writeH((short) 6915);
      this.writeH((short) this.count);
      this.writeC((byte) 13);
      this.writeH((short) Math.Ceiling((double) this.count / 13.0));
    }
  }
}
