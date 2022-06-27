// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_INVENTORY_LEAVE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_INVENTORY_LEAVE_ACK : SendPacket
  {
    private int erro;

    public PROTOCOL_INVENTORY_LEAVE_ACK(int erro)
    {
      this.erro = erro;
    }

    public override void write()
    {
      this.writeH((short) 3332);
      this.writeH((short) 0);
      this.writeD(this.erro);
    }
  }
}
