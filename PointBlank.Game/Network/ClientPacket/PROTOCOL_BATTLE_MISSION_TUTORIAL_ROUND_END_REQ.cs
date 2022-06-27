// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_BATTLE_MISSION_TUTORIAL_ROUND_END_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Enums;
using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Data.Utils;
using PointBlank.Game.Network.ServerPacket;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_BATTLE_MISSION_TUTORIAL_ROUND_END_REQ : ReceivePacket
  {
    public PROTOCOL_BATTLE_MISSION_TUTORIAL_ROUND_END_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
    }

    public override void run()
    {
      if (this._client == null || this._client._player == null)
        return;
      Room room = this._client._player._room;
      room._state = RoomState.BattleEnd;
      this._client.SendPacket((SendPacket) new PROTOCOL_BATTLE_MISSION_TUTORIAL_ROUND_END_ACK(room));
      this._client.SendPacket((SendPacket) new PROTOCOL_BATTLE_MISSION_ROUND_END_ACK(this._client._player._room, 0, RoundEndType.Tutorial));
      this._client.SendPacket((SendPacket) new PROTOCOL_ROOM_CHANGE_ROOMINFO_ACK(room));
      if (room._state == RoomState.BattleEnd)
      {
        room._state = RoomState.Ready;
        this._client.SendPacket((SendPacket) new PROTOCOL_BATTLE_ENDBATTLE_ACK(this._client._player));
        this._client.SendPacket((SendPacket) new PROTOCOL_ROOM_CHANGE_ROOMINFO_ACK(room));
      }
      AllUtils.resetBattleInfo(room);
      this._client.SendPacket((SendPacket) new PROTOCOL_ROOM_GET_SLOTINFO_ACK(room));
    }
  }
}
