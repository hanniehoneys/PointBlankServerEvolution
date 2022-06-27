// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.Event.WeaponSync
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models;
using PointBlank.Battle.Data.Models.Event;

namespace PointBlank.Battle.Network.Actions.Event
{
  public class WeaponSync
  {
    public static WeaponSyncInfo ReadInfo(
      ActionModel ac,
      ReceivePacket p,
      bool genLog,
      bool OnlyBytes = false)
    {
      return WeaponSync.BaseReadInfo(ac, p, OnlyBytes, genLog);
    }

    private static WeaponSyncInfo BaseReadInfo(
      ActionModel ac,
      ReceivePacket p,
      bool OnlyBytes,
      bool genLog)
    {
      WeaponSyncInfo weaponSyncInfo = new WeaponSyncInfo() { Extensions = p.readC(), WeaponId = p.readD() };
      if (OnlyBytes)
        ;
      if (!genLog)
        ;
      return weaponSyncInfo;
    }

    public static void WriteInfo(SendPacket s, ActionModel ac, ReceivePacket p, bool genLog)
    {
      WeaponSyncInfo info = WeaponSync.ReadInfo(ac, p, genLog, true);
      WeaponSync.WriteInfo(s, info);
    }

    public static void WriteInfo(SendPacket s, WeaponSyncInfo info)
    {
      s.writeC(info.Extensions);
      s.writeD(info.WeaponId);
    }
  }
}
