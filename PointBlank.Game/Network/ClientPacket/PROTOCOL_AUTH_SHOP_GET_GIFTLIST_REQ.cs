// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_AUTH_SHOP_GET_GIFTLIST_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Network.ServerPacket;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_AUTH_SHOP_GET_GIFTLIST_REQ : ReceivePacket
  {
    public PROTOCOL_AUTH_SHOP_GET_GIFTLIST_REQ(GameClient Client, byte[] Buffer)
    {
      this.makeme(Client, Buffer);
    }

    public override void read()
    {
    }

    public override void run()
    {
      try
      {
        this._client.SendPacket((SendPacket) new PROTOCOL_AUTH_SHOP_GET_GIFTLIST_ACK(2148110592U));
      }
      catch
      {
      }
    }
  }
}
