// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_ROOM_GET_RANK_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_ROOM_GET_RANK_ACK : SendPacket
  {
    private int Slot;
    private int Rank;

    public PROTOCOL_ROOM_GET_RANK_ACK(int Slot, int Rank)
    {
      this.Slot = Slot;
      this.Rank = Rank;
    }

    public override void write()
    {
      this.writeH((short) 3890);
      this.writeD(this.Slot);
      this.writeD(this.Rank);
    }
  }
}
