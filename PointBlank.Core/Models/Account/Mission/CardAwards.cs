// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Account.Mission.CardAwards
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

namespace PointBlank.Core.Models.Account.Mission
{
  public class CardAwards
  {
    public int _id;
    public int _card;
    public int _insignia;
    public int _medal;
    public int _brooch;
    public int _exp;
    public int _gp;

    public bool Unusable()
    {
      return this._insignia == 0 && this._medal == 0 && (this._brooch == 0 && this._exp == 0) && this._gp == 0;
    }
  }
}
