// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_BASE_PACKET_EMPTY_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_BASE_PACKET_EMPTY_REQ : ReceivePacket
  {
    public PROTOCOL_BASE_PACKET_EMPTY_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
    }

    public override void run()
    {
    }
  }
}
