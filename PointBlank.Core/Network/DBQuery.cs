// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Network.DBQuery
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System.Collections.Generic;

namespace PointBlank.Core.Network
{
  public class DBQuery
  {
    private List<string> tables;
    private List<object> values;

    public DBQuery()
    {
      this.tables = new List<string>();
      this.values = new List<object>();
    }

    public void AddQuery(string table, object value)
    {
      this.tables.Add(table);
      this.values.Add(value);
    }

    public string[] GetTables()
    {
      return this.tables.ToArray();
    }

    public object[] GetValues()
    {
      return this.values.ToArray();
    }
  }
}
