// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_BASE_MAP_MATCHINGLIST_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Models.Map;
using PointBlank.Core.Network;
using System.Collections.Generic;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_BASE_MAP_MATCHINGLIST_ACK : SendPacket
  {
    private List<MapMatch> Matchs;
    private int Total;

    public PROTOCOL_BASE_MAP_MATCHINGLIST_ACK(List<MapMatch> Matchs, int Total)
    {
      this.Matchs = Matchs;
      this.Total = Total;
    }

    public override void write()
    {
      this.writeH((short) 671);
      this.writeH((short) 0);
      this.writeC((byte) this.Matchs.Count);
      for (int index = 0; index < this.Matchs.Count; ++index)
      {
        MapMatch match = this.Matchs[index];
        this.writeD(match.Mode);
        this.writeC((byte) match.Id);
        this.writeC((byte) MapModel.getRule(match.Mode).Rule);
        this.writeC((byte) MapModel.getRule(match.Mode).StageOptions);
        this.writeC((byte) MapModel.getRule(match.Mode).Conditions);
        this.writeC((byte) match.Limit);
        this.writeC((byte) match.Tag);
        this.writeC((byte) 0);
        this.writeC((byte) 0);
      }
      if (this.Matchs.Count != 100)
        this.writeD(1);
      else
        this.writeD(0);
      this.writeH((short) (this.Total - 100));
      this.writeH((short) MapModel.Matchs.Count);
    }
  }
}
