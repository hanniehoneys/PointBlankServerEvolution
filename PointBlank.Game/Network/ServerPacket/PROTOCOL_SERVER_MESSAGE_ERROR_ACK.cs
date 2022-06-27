// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_SERVER_MESSAGE_ERROR_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using System;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_SERVER_MESSAGE_ERROR_ACK : SendPacket
  {
    private uint _erro;

    public PROTOCOL_SERVER_MESSAGE_ERROR_ACK(uint err)
    {
      this._erro = err;
    }

    public override void write()
    {
      this.writeH((short) 2566);
      this.writeD(uint.Parse(DateTime.Now.ToString("MMddHHmmss")));
      this.writeD(this._erro);
    }
  }
}
