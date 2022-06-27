// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_ACCEPT_REQUEST_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_ACCEPT_REQUEST_ACK : SendPacket
  {
    private uint result;

    public PROTOCOL_CS_ACCEPT_REQUEST_ACK(uint result)
    {
      this.result = result;
    }

    public override void write()
    {
      this.writeH((short) 1847);
      this.writeD(this.result);
    }
  }
}
