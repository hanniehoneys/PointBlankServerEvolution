// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_ROOM_GET_PLAYERINFO_REQ
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
  public class PROTOCOL_ROOM_GET_PLAYERINFO_REQ : ReceivePacket
  {
    private int slotId;

    public PROTOCOL_ROOM_GET_PLAYERINFO_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.slotId = this.readD();
    }

    public override void run()
    {
      Account player = this._client._player;
      if (player == null)
        return;
      Room room = player._room;
      try
      {
        this._client.SendPacket((SendPacket) new PROTOCOL_ROOM_GET_PLAYERINFO_ACK(room?.getPlayerBySlot(this.slotId)));
      }
      catch (Exception ex)
      {
        Logger.info(ex.ToString());
      }
    }
  }
}
