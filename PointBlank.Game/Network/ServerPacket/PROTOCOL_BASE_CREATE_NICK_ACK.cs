// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_CREATE_NICK_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_CREATE_NICK_ACK : SendPacket
  {
    private uint _erro;
    private string _name;

    public PROTOCOL_BASE_CREATE_NICK_ACK(uint erro, string name)
    {
      this._erro = erro;
      this._name = name;
    }

    public override void write()
    {
      this.writeH((short) 535);
      this.writeH((short) 0);
      this.writeD(1500511);
      this.writeD(1075242335);
      this.writeC((byte) this._name.Length);
      this.writeUnicode(this._name, this._name.Length * 2);
      this.writeD(this._erro);
    }
  }
}
