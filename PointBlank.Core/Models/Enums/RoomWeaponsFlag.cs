﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Enums.RoomWeaponsFlag
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System;

namespace PointBlank.Core.Models.Enums
{
  [Flags]
  public enum RoomWeaponsFlag
  {
    Barefist = 128, // 0x00000080
    Shotgun = 64, // 0x00000040
    Sniper = 32, // 0x00000020
    RPG7 = 16, // 0x00000010
    Primary = 8,
    Secondary = 4,
    Melee = 2,
    Grenade = 1,
    None = 0,
  }
}
