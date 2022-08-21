﻿// Decompiled with JetBrains decompiler
// Type: Net.LShift.Utilities.ThreadWrapper
// Assembly: updateservice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6A1FC23-14F7-4CCE-B702-0F9FFD2CD5AC
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan.Win32.Patched.mf-9c4f7eb57e580673b883e57f31931bcbce8bd5d8de1a509a25b8b5a175335d9f.exe

using System;
using System.Threading;

namespace Net.LShift.Utilities
{
  public class ThreadWrapper
  {
    public ThreadStart inner;
    public Exception _Exception;

    public ThreadWrapper(ThreadStart inner) => this.inner = inner;

    public void Run()
    {
      this._Exception = (Exception) null;
      try
      {
        this.inner();
      }
      catch (Exception ex)
      {
        this._Exception = ex;
      }
    }

    public Exception Exception => this._Exception;

    public Thread GetThread() => new Thread(new ThreadStart(this.Run));

    public void Start() => this.GetThread().Start();

    public void End()
    {
      if (this.Exception != null)
        throw this.Exception;
    }
  }
}