// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_LOBBY_ENTER_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_LOBBY_ENTER_ACK : SendPacket
  {
    public override void write()
    {
      this.writeH((short) 3074);
      this.writeH((short) 0);
      this.writeD(0);
      this.writeC((byte) 1);
      this.writeQ(0L);
    }
  }
}
