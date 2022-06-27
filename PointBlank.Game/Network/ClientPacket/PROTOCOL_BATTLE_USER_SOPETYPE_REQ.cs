// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_BATTLE_USER_SOPETYPE_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_BATTLE_USER_SOPETYPE_REQ : ReceivePacket
  {
    private int Sight;

    public PROTOCOL_BATTLE_USER_SOPETYPE_REQ(GameClient Client, byte[] Buffer)
    {
      this.makeme(Client, Buffer);
    }

    public override void read()
    {
      this.Sight = (int) this.readC();
    }

    public override void run()
    {
      Account player = this._client._player;
      Room room = player._room;
      if (player == null)
        return;
      player.Sight = this.Sight;
    }
  }
}
