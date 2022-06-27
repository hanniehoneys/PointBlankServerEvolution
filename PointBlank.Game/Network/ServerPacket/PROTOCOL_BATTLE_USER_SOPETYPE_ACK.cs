// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_USER_SOPETYPE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_USER_SOPETYPE_ACK : SendPacket
  {
    private Account Player;

    public PROTOCOL_BATTLE_USER_SOPETYPE_ACK(Account Player)
    {
      this.Player = Player;
    }

    public override void write()
    {
      this.writeH((short) 4253);
      this.writeD(this.Player._slotId);
      this.writeC((byte) this.Player.Sight);
    }
  }
}
