// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_SHOP_GET_SAILLIST_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using System;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_SHOP_GET_SAILLIST_ACK : SendPacket
  {
    private bool Enable;

    public PROTOCOL_SHOP_GET_SAILLIST_ACK(bool Enable)
    {
      this.Enable = Enable;
    }

    public override void write()
    {
      this.writeH((short) 1030);
      this.writeC(this.Enable);
      this.writeD(uint.Parse(DateTime.Now.ToString("yyMMddHHmm")));
    }
  }
}
