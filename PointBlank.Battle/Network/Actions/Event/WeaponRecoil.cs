﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.Event.WeaponRecoil
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models;
using PointBlank.Battle.Data.Models.Event;

namespace PointBlank.Battle.Network.Actions.Event
{
  public class WeaponRecoil
  {
    public static WeaponRecoilInfo ReadInfo(
      ActionModel ac,
      ReceivePacket p,
      bool genLog)
    {
      WeaponRecoilInfo weaponRecoilInfo = new WeaponRecoilInfo() { RecoilHorzAngle = p.readT(), RecoilHorzMax = p.readT(), RecoilVertAngle = p.readT(), RecoilVertMax = p.readT(), Deviation = p.readT(), Extensions = p.readC(), WeaponId = p.readD(), Unk = p.readC(), RecoilHorzCount = p.readC() };
      if (genLog)
        Logger.warning("Slot: " + (object) ac.Slot + " WeaponId: " + (object) weaponRecoilInfo.WeaponId);
      return weaponRecoilInfo;
    }

    public static void ReadInfo(ReceivePacket p)
    {
      p.Advance(27);
    }

    public static void WriteInfo(SendPacket s, ActionModel ac, ReceivePacket p, bool genLog)
    {
      WeaponRecoilInfo weaponRecoilInfo = WeaponRecoil.ReadInfo(ac, p, genLog);
      s.writeT(weaponRecoilInfo.RecoilHorzAngle);
      s.writeT(weaponRecoilInfo.RecoilHorzMax);
      s.writeT(weaponRecoilInfo.RecoilVertAngle);
      s.writeT(weaponRecoilInfo.RecoilVertMax);
      s.writeT(weaponRecoilInfo.Deviation);
      s.writeC(weaponRecoilInfo.Extensions);
      s.writeD(weaponRecoilInfo.WeaponId);
      s.writeC(weaponRecoilInfo.Unk);
      s.writeC(weaponRecoilInfo.RecoilHorzCount);
    }
  }
}
