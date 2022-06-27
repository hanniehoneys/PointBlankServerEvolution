// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_CREATE_CLAN_CONDITION_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Configs;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_CREATE_CLAN_CONDITION_ACK : SendPacket
  {
    public override void write()
    {
      this.writeH((short) 1937);
      this.writeC((byte) GameConfig.minCreateRank);
      this.writeD(GameConfig.minCreateGold);
    }
  }
}
