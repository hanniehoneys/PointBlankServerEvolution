// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_CLIENT_CLAN_CONTEXT_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using System;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_CLIENT_CLAN_CONTEXT_ACK : SendPacket
  {
    private int clansCount;

    public PROTOCOL_CS_CLIENT_CLAN_CONTEXT_ACK(int count)
    {
      this.clansCount = count;
    }

    public override void write()
    {
      this.writeH((short) 1800);
      this.writeD(this.clansCount);
      this.writeC((byte) 15);
      this.writeH((ushort) Math.Ceiling((double) this.clansCount / 15.0));
      this.writeD(uint.Parse(DateTime.Now.ToString("MMddHHmmss")));
    }
  }
}
