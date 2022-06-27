// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_BASE_NOTICE_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Managers.Server;
using PointBlank.Core.Network;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_BASE_NOTICE_ACK : SendPacket
  {
    public override void write()
    {
      ServerConfig config = AuthManager.Config;
      this.writeH((short) 662);
      this.writeH((short) 0);
      this.writeD(config.ChatColor);
      this.writeD(config.AnnouceColor);
      this.writeH((ushort) config.Chat.Length);
      this.writeText(config.Chat, config.Chat.Length);
      this.writeH((ushort) config.Annouce.Length);
      this.writeText(config.Annouce, config.Annouce.Length);
    }
  }
}
