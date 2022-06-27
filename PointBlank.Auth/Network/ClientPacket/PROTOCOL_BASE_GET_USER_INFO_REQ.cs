// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ClientPacket.PROTOCOL_BASE_GET_USER_INFO_REQ
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Data.Model;
using PointBlank.Auth.Network.ServerPacket;
using PointBlank.Core;
using PointBlank.Core.Network;
using System;

namespace PointBlank.Auth.Network.ClientPacket
{
  public class PROTOCOL_BASE_GET_USER_INFO_REQ : ReceivePacket
  {
    public PROTOCOL_BASE_GET_USER_INFO_REQ(AuthClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
    }

    public override void run()
    {
      try
      {
        Account player = this._client._player;
        if (player == null || player._inventory._items.Count != 0)
          return;
        player.LoadInventory();
        player.LoadMissionList();
        player.DiscountPlayerItems();
        this._client.SendPacket((SendPacket) new PROTOCOL_BASE_GET_USER_INFO_ACK(player));
      }
      catch (Exception ex)
      {
        Logger.warning("PROTOCOL_BASE_GET_USER_INFO_REQ: " + ex.ToString());
      }
    }
  }
}
