// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ClientPacket.PROTOCOL_BASE_LOGOUT_REQ
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Network.ServerPacket;
using PointBlank.Core;
using PointBlank.Core.Network;
using System;

namespace PointBlank.Auth.Network.ClientPacket
{
  public class PROTOCOL_BASE_LOGOUT_REQ : ReceivePacket
  {
    public PROTOCOL_BASE_LOGOUT_REQ(AuthClient lc, byte[] buff)
    {
      this.makeme(lc, buff);
    }

    public override void read()
    {
    }

    public override void run()
    {
      try
      {
        this._client.SendPacket((SendPacket) new PROTOCOL_BASE_LOGOUT_ACK());
        this._client.Close(5000, true);
      }
      catch (Exception ex)
      {
        Logger.warning("PROTOCOL_BASE_LOGOUT_REQ: " + ex.ToString());
      }
    }
  }
}
