// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_CS_PAGE_CHATTING_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Enums;
using PointBlank.Core.Network;
using PointBlank.Game.Data.Managers;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Network.ServerPacket;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_CS_PAGE_CHATTING_REQ : ReceivePacket
  {
    private ChattingType type;
    private string text;

    public PROTOCOL_CS_PAGE_CHATTING_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.type = (ChattingType) this.readH();
      this.text = this.readUnicode((int) this.readH() * 2);
    }

    public override void run()
    {
      try
      {
        Account player = this._client._player;
        if (player == null || this.type != ChattingType.Clan_Member_Page)
          return;
        using (PROTOCOL_CS_PAGE_CHATTING_ACK csPageChattingAck = new PROTOCOL_CS_PAGE_CHATTING_ACK(player, this.text))
          ClanManager.SendPacket((SendPacket) csPageChattingAck, player.clanId, -1L, true, true);
      }
      catch
      {
      }
    }
  }
}
