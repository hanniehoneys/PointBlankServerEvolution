// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_GIVEUPBATTLE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_GIVEUPBATTLE_ACK : SendPacket
  {
    private Account p;
    private int type;

    public PROTOCOL_BATTLE_GIVEUPBATTLE_ACK(Account p, int type)
    {
      this.p = p;
      this.type = type;
    }

    public override void write()
    {
      if (this.p == null)
        return;
      this.writeH((short) 4110);
      this.writeD(this.p._slotId);
      this.writeC((byte) this.type);
      this.writeD(this.p._exp);
      this.writeD(this.p._rank);
      this.writeD(this.p._gp);
      this.writeD(this.p._statistic.escapes);
      this.writeD(this.p._statistic.escapes);
      this.writeD(0);
      this.writeC((byte) 0);
    }
  }
}
