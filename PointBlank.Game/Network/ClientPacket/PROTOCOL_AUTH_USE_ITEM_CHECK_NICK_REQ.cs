// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_AUTH_USE_ITEM_CHECK_NICK_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Managers;
using PointBlank.Core.Network;
using PointBlank.Game.Network.ServerPacket;
using System;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_AUTH_USE_ITEM_CHECK_NICK_REQ : ReceivePacket
  {
    private string name;

    public PROTOCOL_AUTH_USE_ITEM_CHECK_NICK_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.name = this.readUnicode(66);
    }

    public override void run()
    {
      try
      {
        if (this._client == null || this._client._player == null)
          return;
        this._client.SendPacket((SendPacket) new PROTOCOL_AUTH_USE_ITEM_CHECK_NICK_ACK(!PlayerManager.isPlayerNameExist(this.name) ? 0U : 2147483923U));
      }
      catch (Exception ex)
      {
        Logger.info(ex.ToString());
      }
    }
  }
}
