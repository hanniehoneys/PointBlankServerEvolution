// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Network.ServerPacket.PROTOCOL_BASE_USER_GIFTLIST_ACK
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Core.Models.Account;
using PointBlank.Core.Network;
using System;
using System.Collections.Generic;

namespace PointBlank.Auth.Network.ServerPacket
{
  public class PROTOCOL_BASE_USER_GIFTLIST_ACK : SendPacket
  {
    private int erro;
    private List<Message> gifts;

    public PROTOCOL_BASE_USER_GIFTLIST_ACK(int erro, List<Message> gifts)
    {
      this.erro = erro;
      this.gifts = gifts;
    }

    public override void write()
    {
      this.writeH((short) 684);
      this.writeH((short) 0);
      this.writeC((byte) this.gifts.Count);
      for (int index = 0; index < this.gifts.Count; ++index)
      {
        Message gift = this.gifts[index];
      }
      this.writeD(uint.Parse(DateTime.Now.ToString("yyMMddHHmm")));
    }
  }
}
