// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Sql.SqlConnection
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using Npgsql;
using System.Runtime.Remoting.Contexts;

namespace PointBlank.Core.Sql
{
  [Synchronization]
  public class SqlConnection
  {
    private static SqlConnection sql = new SqlConnection();
    protected NpgsqlConnectionStringBuilder connBuilder;

    public SqlConnection()
    {
      this.connBuilder = new NpgsqlConnectionStringBuilder()
      {
        Database = Config.dbName,
        Host = Config.dbHost,
        Username = Config.dbUser,
        Password = Config.dbPass,
        Port = Config.dbPort
      };
    }

    public static SqlConnection getInstance()
    {
      return SqlConnection.sql;
    }

    public NpgsqlConnection conn()
    {
      return new NpgsqlConnection(this.connBuilder.ConnectionString);
    }
  }
}
