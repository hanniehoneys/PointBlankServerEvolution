// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Room.Frag
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using PointBlank.Core.Models.Enums;

namespace PointBlank.Core.Models.Room
{
  public class Frag
  {
    public byte victimWeaponClass;
    public byte hitspotInfo;
    public byte flag;
    public KillingMessage killFlag;
    public float x;
    public float y;
    public float z;
    public int VictimSlot;
    public int AssistSlot;

    public Frag()
    {
    }

    public Frag(byte hitspotInfo)
    {
      this.SetHitspotInfo(hitspotInfo);
    }

    public void SetHitspotInfo(byte value)
    {
      this.hitspotInfo = value;
      this.VictimSlot = (int) value & 15;
    }
  }
}
