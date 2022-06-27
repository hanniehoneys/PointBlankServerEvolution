// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_LEAVEP2PSERVER_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_LEAVEP2PSERVER_ACK : SendPacket
  {
    private Room _r;

    public PROTOCOL_BATTLE_LEAVEP2PSERVER_ACK(Room room)
    {
      this._r = room;
    }

    public override void write()
    {
      this.writeH((short) 4125);
      this.writeD(this._r._leader);
    }
  }
}
