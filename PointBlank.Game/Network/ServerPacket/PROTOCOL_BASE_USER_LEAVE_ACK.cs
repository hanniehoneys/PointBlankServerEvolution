// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_USER_LEAVE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_USER_LEAVE_ACK : SendPacket
  {
    private int error;

    public PROTOCOL_BASE_USER_LEAVE_ACK(int error)
    {
      this.error = error;
    }

    public override void write()
    {
      this.writeH((short) 537);
      this.writeD(this.error);
    }
  }
}
