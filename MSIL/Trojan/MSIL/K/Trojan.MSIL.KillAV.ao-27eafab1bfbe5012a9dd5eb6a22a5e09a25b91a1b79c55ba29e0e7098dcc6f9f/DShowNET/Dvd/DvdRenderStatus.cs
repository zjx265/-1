﻿// Decompiled with JetBrains decompiler
// Type: DShowNET.Dvd.DvdRenderStatus
// Assembly: p, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91D63E37-42E0-404C-97F4-07116ACD2D57
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan.MSIL.KillAV.ao-27eafab1bfbe5012a9dd5eb6a22a5e09a25b91a1b79c55ba29e0e7098dcc6f9f.exe

using System.Runtime.InteropServices;

namespace DShowNET.Dvd
{
  [ComVisible(false)]
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct DvdRenderStatus
  {
    public int vpeStatus;
    public bool volInvalid;
    public bool volUnknown;
    public bool noLine21In;
    public bool noLine21Out;
    public int numStreams;
    public int numStreamsFailed;
    public DvdStreamFlags failedStreams;
  }
}