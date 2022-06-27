// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Account.VisitItem
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

namespace PointBlank.Core.Models.Account
{
  public class VisitItem
  {
    public int good_id;
    public long count;
    public bool IsReward;

    public void SetCount(string text)
    {
      this.count = long.Parse(text);
      if (this.count <= 0L)
        return;
      this.IsReward = true;
    }
  }
}
