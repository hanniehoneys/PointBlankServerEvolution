// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_ROOM_CHATTING_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_ROOM_CHATTING_ACK : SendPacket
  {
    private string msg;
    private int type;
    private int slotId;
    private bool GMColor;

    public PROTOCOL_ROOM_CHATTING_ACK(int chat_type, int slotId, bool GM, string message)
    {
      this.type = chat_type;
      this.slotId = slotId;
      this.GMColor = GM;
      this.msg = message;
    }

    public override void write()
    {
      this.writeH((short) 3862);
      this.writeH((short) this.type);
      this.writeD(this.slotId);
      this.writeC(this.GMColor);
      this.writeD(this.msg.Length + 1);
      this.writeUnicode(this.msg, true);
    }
  }
}
