// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_ROOM_CHANGE_PASSWD_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_ROOM_CHANGE_PASSWD_ACK : SendPacket
  {
    private string _pass;

    public PROTOCOL_ROOM_CHANGE_PASSWD_ACK(string pass)
    {
      this._pass = pass;
    }

    public override void write()
    {
      this.writeH((short) 3859);
      this.writeS(this._pass, 4);
    }
  }
}
