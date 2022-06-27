// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_SHOP_PLUS_POINT_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_SHOP_PLUS_POINT_ACK : SendPacket
  {
    private int gp;
    private int _gpIncrease;
    private int type;

    public PROTOCOL_SHOP_PLUS_POINT_ACK(int increase, int gold, int type)
    {
      this._gpIncrease = increase;
      this.gp = gold;
      this.type = type;
    }

    public override void write()
    {
      this.writeH((short) 1072);
      this.writeH((short) 0);
      this.writeC((byte) this.type);
      this.writeD(this.gp);
      this.writeD(this._gpIncrease);
    }
  }
}
