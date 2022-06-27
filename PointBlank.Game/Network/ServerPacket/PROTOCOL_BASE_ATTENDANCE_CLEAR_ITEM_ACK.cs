// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_ATTENDANCE_CLEAR_ITEM_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Enums;
using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_ATTENDANCE_CLEAR_ITEM_ACK : SendPacket
  {
    private uint _erro;

    public PROTOCOL_BASE_ATTENDANCE_CLEAR_ITEM_ACK(EventErrorEnum erro)
    {
      this._erro = (uint) erro;
    }

    public override void write()
    {
      this.writeH((short) 2664);
      this.writeD(this._erro);
    }
  }
}
