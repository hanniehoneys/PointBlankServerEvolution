// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_ROOM_REQUEST_MAIN_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_ROOM_REQUEST_MAIN_ACK : SendPacket
  {
    private uint _slot;

    public PROTOCOL_ROOM_REQUEST_MAIN_ACK(uint slot)
    {
      this._slot = slot;
    }

    public PROTOCOL_ROOM_REQUEST_MAIN_ACK(int slot)
    {
      this._slot = (uint) slot;
    }

    public override void write()
    {
      this.writeH((short) 3876);
      this.writeD(this._slot);
    }
  }
}
