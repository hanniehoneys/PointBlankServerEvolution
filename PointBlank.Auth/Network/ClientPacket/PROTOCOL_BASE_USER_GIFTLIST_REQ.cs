// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ClientPacket.PROTOCOL_BASE_USER_GIFTLIST_REQ
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Network.ServerPacket;
using PointBlank.Core;
using PointBlank.Core.Managers;
using PointBlank.Core.Models.Account;
using PointBlank.Core.Network;
using System;
using System.Collections.Generic;

namespace PointBlank.Auth.Network.ClientPacket
{
  public class PROTOCOL_BASE_USER_GIFTLIST_REQ : ReceivePacket
  {
    public PROTOCOL_BASE_USER_GIFTLIST_REQ(AuthClient lc, byte[] buff)
    {
      this.makeme(lc, buff);
    }

    public override void read()
    {
    }

    public override void run()
    {
      try
      {
        PointBlank.Auth.Data.Model.Account player = this._client._player;
        if (player == null || !AuthManager.Config.GiftSystem)
          return;
        List<Message> gifts = MessageManager.getGifts(player.player_id);
        if (gifts.Count <= 0)
          return;
        MessageManager.RecicleMessages(player.player_id, gifts);
        if (gifts.Count <= 0)
          return;
        this._client.SendPacket((SendPacket) new PROTOCOL_BASE_USER_GIFTLIST_ACK(0, gifts));
      }
      catch (Exception ex)
      {
        Logger.warning(ex.ToString());
      }
    }
  }
}
