// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_SERVER_MESSAGE_ANNOUNCE_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_SERVER_MESSAGE_ANNOUNCE_ACK : SendPacket
  {
    private string _message;

    public PROTOCOL_SERVER_MESSAGE_ANNOUNCE_ACK(string msg)
    {
      this._message = msg;
    }

    public override void write()
    {
      this.writeH((short) 2567);
      this.writeH((short) 0);
      this.writeD(0);
      this.writeH((ushort) this._message.Length);
      this.writeUnicode(this._message, false);
      this.writeD(2);
    }
  }
}
