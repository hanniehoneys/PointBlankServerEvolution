// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_CS_CANCEL_REQUEST_REQ
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
  public class PROTOCOL_CS_CANCEL_REQUEST_REQ : ReceivePacket
  {
    private uint erro;

    public PROTOCOL_CS_CANCEL_REQUEST_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void run()
    {
      try
      {
        if (this._client == null || !PlayerManager.DeleteInviteDb(this._client.player_id))
          this.erro = 2147487835U;
        this._client.SendPacket((SendPacket) new PROTOCOL_CS_CANCEL_REQUEST_ACK(this.erro));
      }
      catch (Exception ex)
      {
        Logger.info(ex.ToString());
      }
    }

    public override void read()
    {
    }
  }
}
