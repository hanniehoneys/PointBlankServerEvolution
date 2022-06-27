// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_MISSION_TOUCHDOWN_COUNT_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_MISSION_TOUCHDOWN_COUNT_ACK : SendPacket
  {
    private Room _r;

    public PROTOCOL_BATTLE_MISSION_TOUCHDOWN_COUNT_ACK(Room r)
    {
      this._r = r;
    }

    public override void write()
    {
      this.writeH((short) 4159);
      this.writeH((ushort) this._r.red_dino);
      this.writeH((ushort) this._r.blue_dino);
    }
  }
}
