// Decompiled with JetBrains decompiler
// Type: PointBlank.Auth.Data.Sync.Client.ServerWarning
// Assembly: PointBlank.Auth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B9C9165-8F50-4DCC-865F-1E7839C59B41
// Assembly location: D:\Servers\Debug\PointBlank.Auth.exe

using PointBlank.Auth.Data.Managers;
using PointBlank.Auth.Data.Model;
using PointBlank.Auth.Network.ServerPacket;
using PointBlank.Core;
using PointBlank.Core.Managers;
using PointBlank.Core.Network;
using PointBlank.Core.Xml;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;

namespace PointBlank.Auth.Data.Sync.Client
{
  public static class ServerWarning
  {
    public static void LoadGMWarning(ReceiveGPacket p)
    {
      string str1 = p.readS((int) p.readC());
      string text = p.readS((int) p.readC());
      string msg = p.readS((int) p.readH());
      string str2 = ComDiv.gen5(text);
      Account accountDb = AccountManager.getInstance().getAccountDB((object) str1, (object) str2, 2, 0);
      if (accountDb == null || accountDb.access <= 3)
        return;
      int num = 0;
      using (PROTOCOL_SERVER_MESSAGE_ANNOUNCE_ACK messageAnnounceAck = new PROTOCOL_SERVER_MESSAGE_ANNOUNCE_ACK(msg))
        num = AuthManager.SendPacketToAllClients((SendPacket) messageAnnounceAck);
      object[] objArray1 = new object[9]{ (object) "[SM] Mensagem enviada a ", (object) num, (object) " jogadores: ", (object) msg, (object) "; by Login: '", (object) str1, (object) "'; Date: '", null, null };
      DateTime now = DateTime.Now;
      objArray1[7] = (object) now.ToString("dd/MM/yy HH:mm");
      objArray1[8] = (object) "'";
      Logger.warning(string.Concat(objArray1));
      object[] objArray2 = new object[9]{ (object) "[Via SM] Mensagem enviada a ", (object) num, (object) " jogadores: ", (object) msg, (object) "; by Login: '", (object) str1, (object) "'; Date: '", null, null };
      now = DateTime.Now;
      objArray2[7] = (object) now.ToString("dd/MM/yy HH:mm");
      objArray2[8] = (object) "'";
      Logger.LogCMD(string.Concat(objArray2));
    }

    public static void LoadShopRestart(ReceiveGPacket p)
    {
      int type = (int) p.readC();
      ShopManager.Reset();
      ShopManager.Load(type);
      Logger.warning("[SM] Shop reiniciada. (Type: " + (object) type + ")");
      Logger.LogCMD("[Via SM] Shop reiniciada. (Type: " + (object) type + "); Date: '" + DateTime.Now.ToString("dd/MM/yy HH:mm") + "'");
    }

    public static void LoadServerUpdate(ReceiveGPacket p)
    {
      int serverId = (int) p.readC();
      ServersXml.UpdateServer(serverId);
      Logger.warning("[SM] Servidor " + (object) serverId + " atualizado.");
      Logger.LogCMD("[Via SM] Servidor " + (object) serverId + " atualizado.; Date: '" + DateTime.Now.ToString("dd/MM/yy HH:mm") + "'");
    }

    public static void LoadShutdown(ReceiveGPacket p)
    {
      string str1 = p.readS((int) p.readC());
      string str2 = ComDiv.gen5(p.readS((int) p.readC()));
      Account accountDb = AccountManager.getInstance().getAccountDB((object) str1, (object) str2, 2, 0);
      if (accountDb == null || !(accountDb.password == str2) || accountDb.access < 4)
        return;
      int num = 0;
      foreach (AuthClient authClient in (IEnumerable<AuthClient>) AuthManager._socketList.Values)
      {
        authClient._client.Shutdown(SocketShutdown.Both);
        authClient._client.Close(10000);
        ++num;
      }
      Logger.warning("[SM] Jogadores Desconectados: " + (object) num + ". (By: " + str1 + ")");
      AuthManager.ServerIsClosed = true;
      AuthManager.mainSocket.Close(5000);
      Logger.warning("[SM] 1/2 Step");
      Thread.Sleep(5000);
      AuthSync.udp.Close();
      Logger.warning("[SM] 2/2 Step.");
      foreach (AuthClient authClient in (IEnumerable<AuthClient>) AuthManager._socketList.Values)
        authClient.Close(0, true);
      Logger.warning("[SM] Servidor foi completamente desligado.");
      Logger.LogCMD("[Via SM] Shutdowned Server: " + (object) num + " jogadores desconectados; by Login: '" + str1 + "'; Date: '" + DateTime.Now.ToString("dd/MM/yy HH:mm") + "'");
    }
  }
}
