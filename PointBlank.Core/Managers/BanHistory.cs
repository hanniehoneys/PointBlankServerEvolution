// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Managers.BanHistory
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System;

namespace PointBlank.Core.Managers
{
  public class BanHistory
  {
    public long object_id;
    public long provider_id;
    public string type;
    public string value;
    public string reason;
    public DateTime startDate;
    public DateTime endDate;

    public BanHistory()
    {
      this.startDate = DateTime.Now;
      this.type = "";
      this.value = "";
      this.reason = "";
    }
  }
}
