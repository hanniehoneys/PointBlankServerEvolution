// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_SELECT_AGE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_SELECT_AGE_ACK : SendPacket
  {
    private int Error;
    private int Age;

    public PROTOCOL_BASE_SELECT_AGE_ACK(int Error, int Age)
    {
      this.Error = Error;
      this.Age = Age;
    }

    public override void write()
    {
      this.writeH((short) 3096);
      this.writeD(this.Error);
      if (this.Error != 0)
        return;
      this.writeC((byte) this.Age);
    }
  }
}
