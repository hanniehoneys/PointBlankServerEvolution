﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_BASE_DAILY_RECORD_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Network.ServerPacket;
using System;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_BASE_DAILY_RECORD_REQ : ReceivePacket
  {
    public PROTOCOL_BASE_DAILY_RECORD_REQ(GameClient Client, byte[] Buffer)
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
        Account player = this._client._player;
        if (player.Daily == null)
          return;
        this._client.SendPacket((SendPacket) new PROTOCOL_BASE_DAILY_RECORD_ACK(player.Daily));
      }
      catch (Exception ex)
      {
        Logger.error("PROTOCOL_BASE_DAILY_RECORD_REQ: " + ex.ToString());
      }
    }
  }
}
