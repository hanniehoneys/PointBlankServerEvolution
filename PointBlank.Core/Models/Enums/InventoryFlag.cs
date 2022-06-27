// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Enums.InventoryFlag
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System;

namespace PointBlank.Core.Models.Enums
{
  [Flags]
  public enum InventoryFlag
  {
    Character = 1,
    Weapon = 2,
    Item = 4,
  }
}
