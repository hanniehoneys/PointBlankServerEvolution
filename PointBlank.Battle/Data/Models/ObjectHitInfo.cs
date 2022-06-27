// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Data.Models.ObjectHitInfo
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Enums;
using SharpDX;

namespace PointBlank.Battle.Data.Models
{
  public class ObjectHitInfo
  {
    public CHARA_DEATH DeathType = CHARA_DEATH.DEFAULT;
    public int Type;
    public int ObjSyncId;
    public int ObjId;
    public int ObjLife;
    public int WeaponId;
    public int KillerId;
    public int AnimId1;
    public int AnimId2;
    public int DestroyState;
    public int HitPart;
    public byte Extensions;
    public Half3 Position;
    public float SpecialUse;

    public ObjectHitInfo(int Type)
    {
      this.Type = Type;
    }
  }
}
