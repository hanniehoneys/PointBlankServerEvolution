// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_REPLACE_PERSONMAX_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_REPLACE_PERSONMAX_ACK : SendPacket
  {
    private int _max;

    public PROTOCOL_CS_REPLACE_PERSONMAX_ACK(int max)
    {
      this._max = max;
    }

    public override void write()
    {
      this.writeH((short) 1897);
      this.writeD(0);
      this.writeC((byte) this._max);
    }
  }
}
