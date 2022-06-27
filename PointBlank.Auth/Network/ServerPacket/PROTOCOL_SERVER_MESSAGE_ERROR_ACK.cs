// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_SERVER_MESSAGE_ERROR_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_SERVER_MESSAGE_ERROR_ACK : SendPacket
  {
    private uint _er;

    public PROTOCOL_SERVER_MESSAGE_ERROR_ACK(uint er)
    {
      this._er = er;
    }

    public override void write()
    {
      this.writeH((short) 2566);
      this.writeD(this._er);
    }
  }
}
