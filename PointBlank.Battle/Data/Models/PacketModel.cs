// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Data.Models.PacketModel
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using System;

namespace PointBlank.Battle.Data.Models
{
  public class PacketModel
  {
    public int Opcode;
    public int Slot;
    public int Round;
    public int Length;
    public int AccountId;
    public int Unk;
    public int Respawn;
    public int RoundNumber;
    public float Time;
    public byte[] Data;
    public byte[] withEndData;
    public byte[] noEndData;
    public DateTime ReceiveDate;
  }
}
