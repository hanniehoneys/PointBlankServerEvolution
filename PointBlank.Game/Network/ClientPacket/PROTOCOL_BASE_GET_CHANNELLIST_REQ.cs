// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_BASE_GET_CHANNELLIST_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Data.Xml;
using PointBlank.Game.Network.ServerPacket;
using System.Collections.Generic;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_BASE_GET_CHANNELLIST_REQ : ReceivePacket
  {
    private int ServerId;

    public PROTOCOL_BASE_GET_CHANNELLIST_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.ServerId = this.readD();
    }

    public override void run()
    {
      List<Channel> channels = ChannelsXml.getChannels(this.ServerId);
      if (this._client._player == null)
        return;
      this._client.SendPacket((SendPacket) new PROTOCOL_BASE_GET_CHANNELLIST_ACK(channels));
    }
  }
}
