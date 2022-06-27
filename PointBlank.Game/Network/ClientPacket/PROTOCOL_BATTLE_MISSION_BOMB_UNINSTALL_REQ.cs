// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_BATTLE_MISSION_BOMB_UNINSTALL_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Enums;
using PointBlank.Core.Models.Room;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Data.Sync.Client;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_BATTLE_MISSION_BOMB_UNINSTALL_REQ : ReceivePacket
  {
    private int slotIdx;

    public PROTOCOL_BATTLE_MISSION_BOMB_UNINSTALL_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.slotIdx = this.readD();
    }

    public override void run()
    {
      Account player = this._client._player;
      PointBlank.Game.Data.Model.Room room = player == null ? (PointBlank.Game.Data.Model.Room) null : player._room;
      if (room == null || room.round.Timer != null || (room._state != RoomState.Battle || !room.C4_actived))
        return;
      Slot slot = room.getSlot(this.slotIdx);
      if (slot == null || slot.state != SlotState.BATTLE)
        return;
      RoomC4.UninstallBomb(room, slot);
    }
  }
}
