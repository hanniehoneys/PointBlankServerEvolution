// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Managers.TicketManager
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using Npgsql;
using PointBlank.Core.Models.Enums;
using PointBlank.Core.Models.Gift;
using PointBlank.Core.Sql;
using System;
using System.Collections.Generic;
using System.Data;

namespace PointBlank.Core.Managers
{
  public static class TicketManager
  {
    public static List<TicketModel> GetTickets()
    {
      List<TicketModel> ticketModelList = new List<TicketModel>();
      try
      {
        using (NpgsqlConnection npgsqlConnection = SqlConnection.getInstance().conn())
        {
          NpgsqlCommand command = npgsqlConnection.CreateCommand();
          npgsqlConnection.Open();
          command.CommandText = "SELECT * FROM tickets";
          command.CommandType = CommandType.Text;
          NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
          while (npgsqlDataReader.Read())
          {
            TicketModel ticketModel = new TicketModel((TicketType) npgsqlDataReader.GetInt32(0), npgsqlDataReader.GetString(1));
            if (ticketModel.Type.HasFlag((Enum) TicketType.ITEM))
            {
              ticketModel.ItemId = npgsqlDataReader.GetInt32(2);
              ticketModel.Count = npgsqlDataReader.GetInt32(3);
              ticketModel.Equip = npgsqlDataReader.GetInt32(4);
            }
            if (ticketModel.Type.HasFlag((Enum) TicketType.MONEY))
            {
              ticketModel.Point = npgsqlDataReader.GetInt32(5);
              ticketModel.Cash = npgsqlDataReader.GetInt32(6);
            }
            ticketModelList.Add(ticketModel);
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
      return ticketModelList;
    }
  }
}
