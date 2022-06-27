// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Data.Chat.KickAllPlayers
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Models.Enums;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Network.ServerPacket;
using System.Collections.Generic;

namespace PointBlank.Game.Data.Chat
{
  public static class KickAllPlayers
  {
    public static string KickPlayers()
    {
      int num = 0;
      using (PROTOCOL_AUTH_ACCOUNT_KICK_ACK authAccountKickAck = new PROTOCOL_AUTH_ACCOUNT_KICK_ACK(0))
      {
        if (GameManager._socketList.Count > 0)
        {
          byte[] completeBytes = authAccountKickAck.GetCompleteBytes("KickAllPlayers.genCode");
          foreach (GameClient gameClient in (IEnumerable<GameClient>) GameManager._socketList.Values)
          {
            Account player = gameClient._player;
            if (player != null && player._isOnline && player.access <= AccessLevel.Streamer)
            {
              player.SendCompletePacket(completeBytes);
              player.Close(1000, true);
              ++num;
            }
          }
        }
      }
      return Translation.GetLabel("KickAllWarn", (object) num);
    }
  }
}
