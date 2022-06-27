// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ClientPacket.PROTOCOL_BASE_GET_CHANNELLIST_REQ
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Data.Model;
using PointBlank.Auth.Data.Xml;
using PointBlank.Auth.Network.ServerPacket;
using PointBlank.Core.Network;
using System.Collections.Generic;

namespace PointBlank.Auth.Network.ClientPacket
{
  public class PROTOCOL_BASE_GET_CHANNELLIST_REQ : ReceivePacket
  {
    private int ServerId;

    public PROTOCOL_BASE_GET_CHANNELLIST_REQ(AuthClient Client, byte[] Buffer)
    {
      this.makeme(Client, Buffer);
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
