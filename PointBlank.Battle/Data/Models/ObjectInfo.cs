// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Data.Models.ObjectInfo
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using System;

namespace PointBlank.Battle.Data.Models
{
  public class ObjectInfo
  {
    public int Life = 100;
    public int Id;
    public int DestroyState;
    public AnimModel Animation;
    public DateTime UseDate;
    public ObjectModel Model;

    public ObjectInfo()
    {
    }

    public ObjectInfo(int Id)
    {
      this.Id = Id;
    }
  }
}
