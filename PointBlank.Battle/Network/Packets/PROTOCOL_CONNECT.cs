// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Network.Packets.PROTOCOL_CONNECT
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

namespace PointBlank.Battle.Network.Packets
{
  public class PROTOCOL_CONNECT
  {
    public static byte[] getCode()
    {
      using (SendPacket sendPacket = new SendPacket())
      {
        sendPacket.writeC((byte) 66);
        sendPacket.writeC((byte) 0);
        sendPacket.writeT(0.0f);
        sendPacket.writeC((byte) 0);
        sendPacket.writeH((short) 14);
        sendPacket.writeD(0);
        sendPacket.writeC((byte) 8);
        return sendPacket.mstream.ToArray();
      }
    }
  }
}
