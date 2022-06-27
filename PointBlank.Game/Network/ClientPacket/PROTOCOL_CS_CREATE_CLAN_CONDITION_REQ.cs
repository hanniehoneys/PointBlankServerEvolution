// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_CS_CREATE_CLAN_CONDITION_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Network.ServerPacket;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_CS_CREATE_CLAN_CONDITION_REQ : ReceivePacket
  {
    public PROTOCOL_CS_CREATE_CLAN_CONDITION_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
    }

    public override void run()
    {
      try
      {
        if (this._client == null)
          return;
        this._client.SendPacket((SendPacket) new PROTOCOL_CS_CREATE_CLAN_CONDITION_ACK());
      }
      catch
      {
      }
    }
  }
}
