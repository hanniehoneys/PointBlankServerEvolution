// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_CHATTING_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_CHATTING_ACK : SendPacket
  {
    private int erro;
    private int banTime;

    public PROTOCOL_BASE_CHATTING_ACK(int erro, int time = 0)
    {
      this.erro = erro;
      this.banTime = time;
    }

    public override void write()
    {
      this.writeH((short) 2628);
      this.writeC((byte) this.erro);
      if (this.erro <= 0)
        return;
      this.writeD(this.banTime);
    }
  }
}
