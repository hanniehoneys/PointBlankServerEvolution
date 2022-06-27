// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_AUTH_GET_POINT_CASH_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_AUTH_GET_POINT_CASH_ACK : SendPacket
  {
    private int erro;
    private int gold;
    private int cash;

    public PROTOCOL_AUTH_GET_POINT_CASH_ACK(int erro, int gold = 0, int cash = 0)
    {
      this.erro = erro;
      this.gold = gold;
      this.cash = cash;
    }

    public override void write()
    {
      this.writeH((short) 1058);
      this.writeD(this.erro);
      if (this.erro >= 0)
      {
        this.writeD(this.gold);
        this.writeD(this.cash);
      }
      this.writeD(0);
    }
  }
}
