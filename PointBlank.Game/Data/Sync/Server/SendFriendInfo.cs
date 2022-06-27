// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Sync.Server.SendFriendInfo
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Account;
using PointBlank.Core.Models.Servers;
using PointBlank.Core.Network;

namespace PointBlank.Game.Data.Sync.Server
{
  public class SendFriendInfo
  {
    public static void Load(PointBlank.Game.Data.Model.Account player, Friend friend, int type)
    {
      if (player == null)
        return;
      GameServerModel server = GameSync.GetServer(player._status);
      if (server == null)
        return;
      using (SendGPacket sendGpacket = new SendGPacket())
      {
        sendGpacket.writeH((short) 17);
        sendGpacket.writeQ(player.player_id);
        sendGpacket.writeC((byte) type);
        sendGpacket.writeQ(friend.player_id);
        if (type != 2)
        {
          sendGpacket.writeC((byte) friend.state);
          sendGpacket.writeC(friend.removed);
        }
        GameSync.SendPacket(sendGpacket.mstream.ToArray(), server.Connection);
      }
    }
  }
}
