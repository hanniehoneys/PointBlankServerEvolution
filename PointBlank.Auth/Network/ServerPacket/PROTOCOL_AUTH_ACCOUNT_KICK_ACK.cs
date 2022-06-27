// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_AUTH_ACCOUNT_KICK_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_AUTH_ACCOUNT_KICK_ACK : SendPacket
  {
    private int _type;

    public PROTOCOL_AUTH_ACCOUNT_KICK_ACK(int type)
    {
      this._type = type;
    }

    public override void write()
    {
      this.writeH((short) 998);
      this.writeC((byte) this._type);
    }
  }
}
