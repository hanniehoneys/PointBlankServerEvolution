// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_RANK_UP_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_RANK_UP_ACK : SendPacket
  {
    private int _rank;
    private int _allExp;

    public PROTOCOL_BASE_RANK_UP_ACK(int rank, int allExp)
    {
      this._rank = rank;
      this._allExp = allExp;
    }

    public override void write()
    {
      this.writeH((short) 551);
      this.writeD(this._rank);
      this.writeD(this._rank);
      this.writeD(this._allExp);
    }
  }
}
