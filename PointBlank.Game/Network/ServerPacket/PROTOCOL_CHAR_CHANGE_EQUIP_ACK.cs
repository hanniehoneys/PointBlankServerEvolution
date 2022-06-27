// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CHAR_CHANGE_EQUIP_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CHAR_CHANGE_EQUIP_ACK : SendPacket
  {
    private uint Error;

    public PROTOCOL_CHAR_CHANGE_EQUIP_ACK(uint Error)
    {
      this.Error = Error;
    }

    public override void write()
    {
      this.writeH((short) 6150);
      this.writeH((short) 0);
      this.writeD(this.Error);
    }
  }
}
