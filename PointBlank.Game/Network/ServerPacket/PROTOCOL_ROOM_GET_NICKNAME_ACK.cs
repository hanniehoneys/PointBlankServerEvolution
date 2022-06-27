// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_ROOM_GET_NICKNAME_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_ROOM_GET_NICKNAME_ACK : SendPacket
  {
    private int slotIdx;
    private int color;
    private string name;

    public PROTOCOL_ROOM_GET_NICKNAME_ACK(int slot, string name, int color)
    {
      this.slotIdx = slot;
      this.name = name;
      this.color = color;
    }

    public override void write()
    {
      this.writeH((short) 3855);
      this.writeD(this.slotIdx);
      if (this.slotIdx < 0)
        return;
      this.writeUnicode(this.name, 33);
      this.writeC((byte) this.color);
    }
  }
}
