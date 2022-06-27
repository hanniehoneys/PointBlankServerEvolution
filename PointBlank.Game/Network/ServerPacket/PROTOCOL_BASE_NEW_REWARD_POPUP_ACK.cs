// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_NEW_REWARD_POPUP_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Models.Account.Players;
using PointBlank.Core.Network;
using System.Collections.Generic;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_NEW_REWARD_POPUP_ACK : SendPacket
  {
    private List<ItemsModel> Items;

    public PROTOCOL_BASE_NEW_REWARD_POPUP_ACK(List<ItemsModel> Items)
    {
      this.Items = Items;
    }

    public override void write()
    {
      this.writeH((short) 637);
      this.writeD(0);
      this.writeC((byte) this.Items.Count);
      for (int index = 0; index < this.Items.Count; ++index)
      {
        ItemsModel itemsModel = this.Items[index];
        this.writeD(itemsModel._id);
        this.writeD((int) itemsModel._count);
      }
    }
  }
}
