// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_ROOM_CHANGE_COSTUME_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Room;
using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_ROOM_CHANGE_COSTUME_ACK : SendPacket
  {
    private Slot Slot;

    public PROTOCOL_ROOM_CHANGE_COSTUME_ACK(Slot Slot)
    {
      this.Slot = Slot;
    }

    public override void write()
    {
      this.writeH((short) 3932);
      this.writeD(this.Slot._id);
      this.writeC((byte) this.Slot.Costume);
    }
  }
}
