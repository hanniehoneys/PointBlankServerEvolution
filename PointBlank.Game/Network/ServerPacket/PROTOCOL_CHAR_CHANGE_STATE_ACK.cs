// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CHAR_CHANGE_STATE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Account.Players;
using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CHAR_CHANGE_STATE_ACK : SendPacket
  {
    private Character Character;

    public PROTOCOL_CHAR_CHANGE_STATE_ACK(Character Character)
    {
      this.Character = Character;
    }

    public override void write()
    {
      this.writeH((short) 6153);
      this.writeH((short) 0);
      this.writeD(0);
      this.writeC((byte) 20);
      this.writeC((byte) this.Character.Slot);
    }
  }
}
