// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_MISSION_TUTORIAL_ROUND_END_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_MISSION_TUTORIAL_ROUND_END_ACK : SendPacket
  {
    private Room Room;

    public PROTOCOL_BATTLE_MISSION_TUTORIAL_ROUND_END_ACK(Room Room)
    {
      this.Room = Room;
    }

    public override void write()
    {
      this.writeH((short) 4165);
      this.writeC((byte) 3);
      this.writeH((short) (this.Room.getTimeByMask() * 60 - this.Room.getInBattleTime()));
    }
  }
}
