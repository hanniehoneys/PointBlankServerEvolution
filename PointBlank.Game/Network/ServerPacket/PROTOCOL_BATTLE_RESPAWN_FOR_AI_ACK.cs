// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_RESPAWN_FOR_AI_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_RESPAWN_FOR_AI_ACK : SendPacket
  {
    private int _slot;

    public PROTOCOL_BATTLE_RESPAWN_FOR_AI_ACK(int slot)
    {
      this._slot = slot;
    }

    public override void write()
    {
      this.writeH((short) 4151);
      this.writeD(this._slot);
    }
  }
}
