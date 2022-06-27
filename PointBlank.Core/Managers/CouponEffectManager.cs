// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Managers.CouponEffectManager
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using Npgsql;
using PointBlank.Core.Models.Enums;
using PointBlank.Core.Sql;
using System;
using System.Collections.Generic;
using System.Data;

namespace PointBlank.Core.Managers
{
  public static class CouponEffectManager
  {
    private static List<CouponFlag> Effects = new List<CouponFlag>();

    public static void LoadCouponFlags()
    {
      try
      {
        using (NpgsqlConnection npgsqlConnection = SqlConnection.getInstance().conn())
        {
          NpgsqlCommand command = npgsqlConnection.CreateCommand();
          npgsqlConnection.Open();
          command.CommandText = "SELECT * FROM info_cupons_flags";
          command.CommandType = CommandType.Text;
          NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
          while (npgsqlDataReader.Read())
          {
            CouponFlag couponFlag = new CouponFlag() { ItemId = npgsqlDataReader.GetInt32(0), EffectFlag = (CouponEffects) npgsqlDataReader.GetInt64(1) };
            CouponEffectManager.Effects.Add(couponFlag);
          }
          command.Dispose();
          npgsqlDataReader.Close();
          npgsqlConnection.Dispose();
          npgsqlConnection.Close();
        }
      }
      catch (Exception ex)
      {
        Logger.error(ex.ToString());
      }
    }

    public static CouponFlag getCouponEffect(int id)
    {
      for (int index = 0; index < CouponEffectManager.Effects.Count; ++index)
      {
        CouponFlag effect = CouponEffectManager.Effects[index];
        if (effect.ItemId == id)
          return effect;
      }
      return (CouponFlag) null;
    }
  }
}
