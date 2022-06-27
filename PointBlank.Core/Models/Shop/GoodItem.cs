// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Shop.GoodItem
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using PointBlank.Core.Models.Account.Players;

namespace PointBlank.Core.Models.Shop
{
  public class GoodItem
  {
    public ItemsModel _item = new ItemsModel() { _equip = 1 };
    public int price_gold;
    public int price_cash;
    public int auth_type;
    public int buy_type2;
    public int buy_type3;
    public int id;
    public int tag;
    public int title;
    public int visibility;
  }
}
