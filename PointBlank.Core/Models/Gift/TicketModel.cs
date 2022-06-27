// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Gift.TicketModel
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using PointBlank.Core.Models.Enums;

namespace PointBlank.Core.Models.Gift
{
  public class TicketModel
  {
    public string Ticket;
    public int ItemId;
    public int Count;
    public int Equip;
    public int Point;
    public int Cash;
    public TicketType Type;

    public TicketModel(TicketType Type, string Ticket)
    {
      this.Type = Type;
      this.Ticket = Ticket;
    }
  }
}
