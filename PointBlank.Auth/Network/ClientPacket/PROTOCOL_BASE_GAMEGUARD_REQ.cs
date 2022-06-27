// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ClientPacket.PROTOCOL_BASE_GAMEGUARD_REQ
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Network.ServerPacket;
using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ClientPacket
{
  public class PROTOCOL_BASE_GAMEGUARD_REQ : ReceivePacket
  {
    private string ClientVersion;

    public PROTOCOL_BASE_GAMEGUARD_REQ(AuthClient Client, byte[] Buffer)
    {
      this.makeme(Client, Buffer);
    }

    public override void read()
    {
      this.readB(48);
      this.ClientVersion = ((int) this.readC()).ToString() + "." + (object) this.readH();
    }

    public override void run()
    {
      this._client.SendPacket((SendPacket) new PROTOCOL_BASE_GAMEGUARD_ACK());
    }
  }
}
