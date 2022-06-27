// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_AUTH_SHOP_GET_GIFTLIST_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_AUTH_SHOP_GET_GIFTLIST_ACK : SendPacket
  {
    private uint Error;

    public PROTOCOL_AUTH_SHOP_GET_GIFTLIST_ACK(uint Error)
    {
      this.Error = Error;
    }

    public override void write()
    {
      this.writeH((short) 1042);
      this.writeH((short) 0);
      if (this.Error == 0U)
        return;
      this.writeD(this.Error);
    }
  }
}
