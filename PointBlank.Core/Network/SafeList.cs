// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Network.SafeList`1
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System.Collections.Generic;

namespace PointBlank.Core.Network
{
  public class SafeList<T>
  {
    private List<T> _list = new List<T>();
    private object _sync = new object();

    public void Add(T value)
    {
      lock (this._sync)
        this._list.Add(value);
    }

    public void Clear()
    {
      lock (this._sync)
        this._list.Clear();
    }

    public bool Contains(T value)
    {
      lock (this._sync)
        return this._list.Contains(value);
    }

    public int Count()
    {
      lock (this._sync)
        return this._list.Count;
    }

    public bool Remove(T value)
    {
      lock (this._sync)
        return this._list.Remove(value);
    }
  }
}
