// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Data.Sync.Update.ClanInfo
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Data.Model;

namespace PointBlank.Auth.Data.Sync.Update
{
  public class ClanInfo
  {
    public static void AddMember(Account player, Account member)
    {
      lock (player._clanPlayers)
        player._clanPlayers.Add(member);
    }

    public static void RemoveMember(Account player, long id)
    {
      lock (player._clanPlayers)
      {
        for (int index = 0; index < player._clanPlayers.Count; ++index)
        {
          if (player._clanPlayers[index].player_id == id)
          {
            player._clanPlayers.RemoveAt(index);
            break;
          }
        }
      }
    }

    public static void ClearList(Account p)
    {
      lock (p._clanPlayers)
      {
        p.clan_id = 0;
        p.clanAccess = 0;
        p._clanPlayers.Clear();
      }
    }
  }
}
