﻿// Decompiled with JetBrains decompiler
// Type: YRYD
// Assembly: sostextreme, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C2765AC-1F5A-4984-8CF4-C8C51F8C1439
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan.MSIL.Petun.a-03018237b1ac03e3be8783295f9ca585bdb16a023493e1738684f62fc83b999e.exe

using System;
using System.Threading;

internal class YRYD : IDisposable
{
  private readonly Mutex mMutex;
  private bool _mMutexOwned;

  public YRYD(string name)
  {
    this.mMutex = new Mutex(false, name);
    this._mMutexOwned = false;
  }

  public bool IsRunning()
  {
    this._mMutexOwned = this.mMutex.WaitOne(0, true);
    return !this._mMutexOwned;
  }

  public void Dispose()
  {
    if (!this._mMutexOwned)
      return;
    this.mMutex.ReleaseMutex();
  }
}