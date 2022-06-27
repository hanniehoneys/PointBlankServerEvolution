// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_BASE_USER_LEAVE_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_BASE_USER_LEAVE_ACK : SendPacket
  {
    private int erro;

    public PROTOCOL_BASE_USER_LEAVE_ACK(int erro)
    {
      this.erro = erro;
    }

    public override void write()
    {
      this.writeH((short) 537);
      this.writeH((short) 0);
      this.writeD(this.erro);
    }
  }
}
