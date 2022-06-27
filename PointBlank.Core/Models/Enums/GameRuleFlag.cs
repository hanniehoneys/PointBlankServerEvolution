// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Enums.GameRuleFlag
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System;

namespace PointBlank.Core.Models.Enums
{
  [Flags]
  public enum GameRuleFlag
  {
    ไม่มี = 0,
    ห้ามใช้บาเรต = 1,
    ห้ามใช้ลูกซอง = 2,
    ห้ามใช้หน้ากาก = 4,
    กฎแข่ง = 8,
  }
}
