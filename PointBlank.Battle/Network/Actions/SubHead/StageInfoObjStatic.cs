// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Actions.SubHead.StageInfoObjStatic
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models.SubHead;

namespace PointBlank.Battle.Network.Actions.SubHead
{
  public class StageInfoObjStatic
  {
    public static StageStaticInfo ReadSyncInfo(ReceivePacket p, bool genLog)
    {
      StageStaticInfo stageStaticInfo = new StageStaticInfo() { _isDestroyed = p.readC() };
      if (genLog)
        Logger.warning("[StageInfoObjStatic] Destroyed: " + (object) stageStaticInfo._isDestroyed);
      return stageStaticInfo;
    }

    public static void WriteInfo(SendPacket s, ReceivePacket p, bool genLog)
    {
      StageStaticInfo stageStaticInfo = StageInfoObjStatic.ReadSyncInfo(p, genLog);
      s.writeC(stageStaticInfo._isDestroyed);
    }
  }
}
