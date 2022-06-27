// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_BATTLE_TIMEOUTCLIENT_REQ
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
  public class PROTOCOL_BATTLE_TIMEOUTCLIENT_REQ : ReceivePacket
  {
    private int Slot;

    public PROTOCOL_BATTLE_TIMEOUTCLIENT_REQ(GameClient Client, byte[] Buffer)
    {
      this.makeme(Client, Buffer);
    }

    public override void read()
    {
      this.Slot = this.readD();
    }

    public override void run()
    {
      try
      {
        Account player = this._client._player;
        Room room = player._room;
        if (player == null || room == null || player._slotId != this.Slot)
          return;
        player._connection.SendPacket((SendPacket) new PROTOCOL_BATTLE_TIMEOUTCLIENT_ACK());
      }
      catch (Exception ex)
      {
        Logger.error("PROTOCOL_BATTLE_TIMEOUTCLIENT_REQ: " + ex.ToString());
      }
    }
  }
}
