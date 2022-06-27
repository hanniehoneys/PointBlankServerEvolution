// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_MISSION_BOMB_INSTALL_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_MISSION_BOMB_INSTALL_ACK : SendPacket
  {
    private int _slot;
    private float _x;
    private float _y;
    private float _z;
    private byte _zone;

    public PROTOCOL_BATTLE_MISSION_BOMB_INSTALL_ACK(
      int slot,
      byte zone,
      float x,
      float y,
      float z)
    {
      this._zone = zone;
      this._slot = slot;
      this._x = x;
      this._y = y;
      this._z = z;
    }

    public override void write()
    {
      this.writeH((short) 4133);
      this.writeD(this._slot);
      this.writeC(this._zone);
      this.writeH((short) 42);
      this.writeT(this._x);
      this.writeT(this._y);
      this.writeT(this._z);
    }
  }
}
