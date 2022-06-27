// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Account.Clan.RecordInfo
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

namespace PointBlank.Core.Models.Account.Clan
{
  public class RecordInfo
  {
    public long PlayerId;
    public int RecordValue;

    public RecordInfo(string[] split)
    {
      this.PlayerId = this.GetPlayerId(split);
      this.RecordValue = this.GetPlayerValue(split);
    }

    public long GetPlayerId(string[] split)
    {
      try
      {
        return long.Parse(split[0]);
      }
      catch
      {
        return 0;
      }
    }

    public int GetPlayerValue(string[] split)
    {
      try
      {
        return int.Parse(split[1]);
      }
      catch
      {
        return 0;
      }
    }

    public string GetSplit()
    {
      return this.PlayerId.ToString() + "-" + (object) this.RecordValue;
    }
  }
}
