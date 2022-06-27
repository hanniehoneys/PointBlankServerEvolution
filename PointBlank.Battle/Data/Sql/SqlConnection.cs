// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Data.Sql.SqlConnection
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using Npgsql;
using PointBlank.Battle.Data.Configs;
using System.Runtime.Remoting.Contexts;

namespace PointBlank.Battle.Data.Sql
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
        Database = BattleConfig.dbName,
        Host = BattleConfig.dbHost,
        Username = BattleConfig.dbUser,
        Password = BattleConfig.dbPass,
        Port = BattleConfig.dbPort
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
