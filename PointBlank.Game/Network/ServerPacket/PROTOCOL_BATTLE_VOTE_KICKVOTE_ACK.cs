// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_VOTE_KICKVOTE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_VOTE_KICKVOTE_ACK : SendPacket
  {
    private uint erro;

    public PROTOCOL_BATTLE_VOTE_KICKVOTE_ACK(uint erro)
    {
      this.erro = erro;
    }

    public override void write()
    {
      this.writeH((short) 3401);
      this.writeD(this.erro);
    }
  }
}
