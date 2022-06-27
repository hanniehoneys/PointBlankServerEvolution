// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_BASE_GET_CHANNELLIST_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Data.Configs;
using PointBlank.Auth.Data.Model;
using PointBlank.Core.Network;
using System.Collections.Generic;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_BASE_GET_CHANNELLIST_ACK : SendPacket
  {
    private List<Channel> Channels;

    public PROTOCOL_BASE_GET_CHANNELLIST_ACK(List<Channel> Channels)
    {
      this.Channels = Channels;
    }

    public override void write()
    {
      this.writeH((short) 541);
      this.writeH((short) 0);
      this.writeC((byte) 0);
      this.writeC((byte) this.Channels.Count);
      for (int index = 0; index < this.Channels.Count; ++index)
        this.writeH((ushort) this.Channels[index]._players);
      this.writeH((ushort) AuthConfig.maxChannelPlayers);
      this.writeC((byte) this.Channels.Count);
    }
  }
}
