// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_QUEST_CHANGE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Core.Xml;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_QUEST_CHANGE_ACK : SendPacket
  {
    private int missionId;
    private int value;

    public PROTOCOL_BASE_QUEST_CHANGE_ACK(int progress, Card card)
    {
      this.missionId = card._missionBasicId;
      if (card._missionLimit == progress)
        this.missionId += 240;
      this.value = progress;
    }

    public override void write()
    {
      this.writeH((short) 567);
      this.writeC((byte) this.missionId);
      this.writeC((byte) this.value);
    }
  }
}
