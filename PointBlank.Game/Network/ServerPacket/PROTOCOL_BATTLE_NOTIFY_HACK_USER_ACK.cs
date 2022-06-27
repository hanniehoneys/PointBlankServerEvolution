// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BATTLE_NOTIFY_HACK_USER_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_NOTIFY_HACK_USER_ACK : SendPacket
  {
    private int slotId;

    public PROTOCOL_BATTLE_NOTIFY_HACK_USER_ACK(int slot)
    {
      this.slotId = slot;
    }

    public override void write()
    {
      this.writeH((short) 3413);
      this.writeC((byte) this.slotId);
      this.writeC((byte) 1);
      this.writeD(1);
    }
  }
}
