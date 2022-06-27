// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_MISSION_TOUCHDOWN_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Room;
using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_MISSION_TOUCHDOWN_ACK : SendPacket
  {
    private PointBlank.Game.Data.Model.Room r;
    private Slot slot;

    public PROTOCOL_BATTLE_MISSION_TOUCHDOWN_ACK(PointBlank.Game.Data.Model.Room room, Slot slot)
    {
      this.r = room;
      this.slot = slot;
    }

    public override void write()
    {
      this.writeH((short) 4155);
      this.writeH((ushort) this.r.red_dino);
      this.writeH((ushort) this.r.blue_dino);
      this.writeD(this.slot._id);
      this.writeH((short) this.slot.passSequence);
    }
  }
}
