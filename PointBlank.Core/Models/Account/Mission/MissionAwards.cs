// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Account.Mission.MissionAwards
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

namespace PointBlank.Core.Models.Account.Mission
{
  public class MissionAwards
  {
    public int _id;
    public int _blueOrder;
    public int _exp;
    public int _gp;

    public MissionAwards(int id, int blueOrder, int exp, int gp)
    {
      this._id = id;
      this._blueOrder = blueOrder;
      this._exp = exp;
      this._gp = gp;
    }
  }
}
