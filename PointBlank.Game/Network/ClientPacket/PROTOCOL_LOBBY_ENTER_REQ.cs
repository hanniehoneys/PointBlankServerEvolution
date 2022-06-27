// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_LOBBY_ENTER_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Models.Enums;
using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Data.Utils;
using PointBlank.Game.Network.ServerPacket;
using System;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_LOBBY_ENTER_REQ : ReceivePacket
  {
    public PROTOCOL_LOBBY_ENTER_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      int num = (int) this.readC();
    }

    public override void run()
    {
      try
      {
        if (this._client == null)
          return;
        Account player = this._client._player;
        if (player == null)
          return;
        player.LastLobbyEnter = DateTime.Now;
        if (player.channelId >= 0)
          player.getChannel()?.AddPlayer(player.Session);
        Room room = player._room;
        if (room != null)
        {
          if (player._slotId < 0 || room._state < RoomState.Loading || room._slots[player._slotId].state < SlotState.LOAD)
            room.RemovePlayer(player, false, 0);
          else
            goto label_9;
        }
        AllUtils.syncPlayerToFriends(player, false);
        AllUtils.syncPlayerToClanMembers(player);
        AllUtils.GetXmasReward(player);
label_9:
        this._client.SendPacket((SendPacket) new PROTOCOL_LOBBY_ENTER_ACK());
      }
      catch (Exception ex)
      {
        Logger.warning("PROTOCOL_LOBBY_ENTER_REQ: " + ex.ToString());
      }
    }
  }
}
