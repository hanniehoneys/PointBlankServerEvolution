// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CLAN_WAR_INVITE_MERCENARY_RECEIVER_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CLAN_WAR_INVITE_MERCENARY_RECEIVER_ACK : SendPacket
  {
    private int _f;
    private uint _erro;

    public PROTOCOL_CLAN_WAR_INVITE_MERCENARY_RECEIVER_ACK(uint erro, int formacao = 0)
    {
      this._erro = erro;
      this._f = formacao;
    }

    public override void write()
    {
      this.writeH((short) 1572);
      this.writeD(this._erro);
      if (this._erro != 0U)
        return;
      this.writeC((byte) this._f);
    }
  }
}
