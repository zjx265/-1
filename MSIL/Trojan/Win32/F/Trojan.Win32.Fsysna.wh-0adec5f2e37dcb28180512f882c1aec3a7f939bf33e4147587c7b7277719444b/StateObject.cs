﻿// Decompiled with JetBrains decompiler
// Type: n.StateObject
// Assembly: n, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BFCF94BC-F711-4A63-941E-52FC7F306AC7
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan.Win32.Fsysna.wh-0adec5f2e37dcb28180512f882c1aec3a7f939bf33e4147587c7b7277719444b.exe

using System.Net.Sockets;
using System.Text;

namespace n
{
  public class StateObject
  {
    public Socket workSocket;
    public int BufferSize;
    public byte[] buffer;
    public StringBuilder sb;

    public StateObject()
    {
      this.workSocket = (Socket) null;
      this.BufferSize = 1999998;
      this.buffer = new byte[1999999];
      this.sb = new StringBuilder();
    }
  }
}