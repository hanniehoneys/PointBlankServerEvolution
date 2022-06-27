// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_CLAN_WAR_RESULT_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_CLAN_WAR_RESULT_REQ : ReceivePacket
  {
    private int ClanId;

    public PROTOCOL_CLAN_WAR_RESULT_REQ(GameClient Client, byte[] Buffer)
    {
      this.makeme(Client, Buffer);
    }

    public override void read()
    {
      this.ClanId = this.readD();
    }

    public override void run()
    {
    }
  }
}
