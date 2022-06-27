// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Network.IdFactory
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

namespace PointBlank.Core.Network
{
  public class IdFactory
  {
    private BitSet IdList = new BitSet();
    private BitSet SeedList = new BitSet();
    private int NextMinId = 0;
    private int NextMinSeed = 1;
    private static IdFactory Instance;

    public int NextId()
    {
      int pos = 0;
      if (this.NextMinId != int.MinValue)
        pos = this.IdList.NextClearBit(this.NextMinId);
      this.IdList.Set(pos);
      this.NextMinId = pos + 1;
      return pos;
    }

    public ushort NextSeed()
    {
      ushort num = 0;
      if (this.NextMinSeed != 0)
        num = (ushort) this.SeedList.NextClearBit(this.NextMinSeed);
      this.SeedList.Set((int) num);
      this.NextMinSeed = (int) num + 1;
      return num;
    }

    public static IdFactory GetInstance()
    {
      if (IdFactory.Instance == null)
        IdFactory.Instance = new IdFactory();
      return IdFactory.Instance;
    }
  }
}
