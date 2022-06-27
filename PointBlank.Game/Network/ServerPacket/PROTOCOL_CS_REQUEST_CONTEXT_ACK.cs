// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_REQUEST_CONTEXT_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Managers;
using PointBlank.Core.Network;
using System;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_REQUEST_CONTEXT_ACK : SendPacket
  {
    private uint _erro;
    private int invites;

    public PROTOCOL_CS_REQUEST_CONTEXT_ACK(int clanId)
    {
      if (clanId > 0)
        this.invites = PlayerManager.getRequestCount(clanId);
      else
        this._erro = uint.MaxValue;
    }

    public override void write()
    {
      this.writeH((short) 1841);
      this.writeD(this._erro);
      if (this._erro != 0U)
        return;
      this.writeC((byte) this.invites);
      this.writeC((byte) 13);
      this.writeC((byte) Math.Ceiling((double) this.invites / 13.0));
      this.writeD(uint.Parse(DateTime.Now.ToString("MMddHHmmss")));
    }
  }
}
