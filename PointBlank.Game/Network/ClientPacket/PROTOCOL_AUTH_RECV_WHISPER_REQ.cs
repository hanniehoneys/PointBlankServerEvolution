﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_AUTH_RECV_WHISPER_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Network;
using PointBlank.Game.Data.Managers;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Network.ServerPacket;
using System;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_AUTH_RECV_WHISPER_REQ : ReceivePacket
  {
    private string receiverName;
    private string text;

    public PROTOCOL_AUTH_RECV_WHISPER_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.receiverName = this.readUnicode(66);
      this.text = this.readUnicode((int) this.readH() * 2);
    }

    public override void run()
    {
      try
      {
        Account player = this._client._player;
        if (player == null || player.player_name == this.receiverName)
          return;
        Account account = AccountManager.getAccount(this.receiverName, 1, 0);
        if (account == null || account.player_name != this.receiverName || !account._isOnline)
          this._client.SendPacket((SendPacket) new PROTOCOL_AUTH_SEND_WHISPER_ACK(this.receiverName, this.text, 2147483648U));
        else
          account.SendPacket((SendPacket) new PROTOCOL_AUTH_RECV_WHISPER_ACK(player.player_name, this.text, player.UseChatGM()), false);
      }
      catch (Exception ex)
      {
        Logger.info(ex.ToString());
      }
    }
  }
}
