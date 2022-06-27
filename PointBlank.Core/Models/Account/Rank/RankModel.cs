// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Account.Rank.RankModel
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

namespace PointBlank.Core.Models.Account.Rank
{
  public class RankModel
  {
    public int _onNextLevel;
    public int _id;
    public int _onGPUp;
    public int _onAllExp;

    public RankModel(int rank, int onNextLevel, int onGPUp, int onAllExp)
    {
      this._id = rank;
      this._onNextLevel = onNextLevel;
      this._onGPUp = onGPUp;
      this._onAllExp = onAllExp;
    }
  }
}
