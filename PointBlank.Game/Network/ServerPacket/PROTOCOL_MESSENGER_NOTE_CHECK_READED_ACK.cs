// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_MESSENGER_NOTE_CHECK_READED_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using System.Collections.Generic;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_MESSENGER_NOTE_CHECK_READED_ACK : SendPacket
  {
    private List<int> msgs;

    public PROTOCOL_MESSENGER_NOTE_CHECK_READED_ACK(List<int> msgs)
    {
      this.msgs = msgs;
    }

    public override void write()
    {
      this.writeH((short) 935);
      this.writeC((byte) this.msgs.Count);
      for (int index = 0; index < this.msgs.Count; ++index)
        this.writeD(this.msgs[index]);
    }
  }
}
