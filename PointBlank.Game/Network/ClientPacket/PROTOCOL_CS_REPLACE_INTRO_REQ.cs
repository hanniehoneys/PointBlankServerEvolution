// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_CS_REPLACE_INTRO_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Managers;
using PointBlank.Game.Network.ServerPacket;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_CS_REPLACE_INTRO_REQ : ReceivePacket
  {
    private string clan_info;
    private uint erro;

    public PROTOCOL_CS_REPLACE_INTRO_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.clan_info = this.readUnicode((int) this.readC() * 2);
    }

    public override void run()
    {
      try
      {
        PointBlank.Game.Data.Model.Account player = this._client._player;
        if (player != null)
        {
          PointBlank.Core.Models.Account.Clan.Clan clan = ClanManager.getClan(player.clanId);
          if (clan._id > 0 && clan._info != this.clan_info && (clan.owner_id == this._client.player_id || player.clanAccess >= 1 && player.clanAccess <= 2))
          {
            if (ComDiv.updateDB("clan_data", "clan_info", (object) this.clan_info, "clan_id", (object) clan._id))
              clan._info = this.clan_info;
            else
              this.erro = 2147487860U;
          }
          else
            this.erro = 2147487835U;
        }
        else
          this.erro = 2147487835U;
      }
      catch
      {
        this.erro = 2147487860U;
      }
      this._client.SendPacket((SendPacket) new PROTOCOL_CS_REPLACE_INTRO_ACK(this.erro));
    }
  }
}
