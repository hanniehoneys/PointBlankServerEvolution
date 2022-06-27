// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_BASE_URL_LIST_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_BASE_URL_LIST_ACK : SendPacket
  {
    public override void write()
    {
      string name1 = "http://pb-phoenix.com/";
      string name2 = "https://www.facebook.com/groups/2038630256436318/";
      this.writeH((short) 673);
      this.writeC((byte) 1);
      this.writeC((byte) 2);
      this.writeH((ushort) name1.Length);
      this.writeQ(4L);
      this.writeText(name1, name1.Length);
      this.writeH((ushort) name2.Length);
      this.writeQ(3L);
      this.writeText(name2, name2.Length);
    }
  }
}
