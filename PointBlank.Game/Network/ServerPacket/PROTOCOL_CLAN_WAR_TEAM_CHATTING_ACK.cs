// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CLAN_WAR_TEAM_CHATTING_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CLAN_WAR_TEAM_CHATTING_ACK : SendPacket
  {
    private int type;
    private int bantime;
    private string message;
    private string sender;

    public PROTOCOL_CLAN_WAR_TEAM_CHATTING_ACK(string sender, string text)
    {
      this.sender = sender;
      this.message = text;
    }

    public PROTOCOL_CLAN_WAR_TEAM_CHATTING_ACK(int type, int bantime)
    {
      this.type = type;
      this.bantime = bantime;
    }

    public override void write()
    {
      this.writeH((short) 1577);
      this.writeC((byte) this.type);
      if (this.type == 0)
      {
        this.writeC((byte) (this.sender.Length + 1));
        this.writeS(this.sender, this.sender.Length + 1);
        this.writeC((byte) this.message.Length);
        this.writeS(this.message, this.message.Length);
      }
      else
        this.writeD(this.bantime);
    }
  }
}
