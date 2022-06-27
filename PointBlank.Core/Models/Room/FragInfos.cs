// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Room.FragInfos
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using PointBlank.Core.Models.Enums;
using System;
using System.Collections.Generic;

namespace PointBlank.Core.Models.Room
{
  public class FragInfos
  {
    public List<Frag> frags = new List<Frag>();
    public byte killerIdx;
    public byte killsCount;
    public byte flag;
    public CharaKillType killingType;
    public int weapon;
    public int Score;
    public float x;
    public float y;
    public float z;

    public KillingMessage GetAllKillFlags()
    {
      KillingMessage killingMessage = (KillingMessage) 0;
      for (int index = 0; index < this.frags.Count; ++index)
      {
        Frag frag = this.frags[index];
        if (!killingMessage.HasFlag((Enum) frag.killFlag))
          killingMessage |= frag.killFlag;
      }
      return killingMessage;
    }
  }
}
