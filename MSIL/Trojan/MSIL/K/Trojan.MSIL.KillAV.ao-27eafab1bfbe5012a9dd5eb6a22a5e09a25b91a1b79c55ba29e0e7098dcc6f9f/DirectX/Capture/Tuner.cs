﻿// Decompiled with JetBrains decompiler
// Type: DirectX.Capture.Tuner
// Assembly: p, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91D63E37-42E0-404C-97F4-07116ACD2D57
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan.MSIL.KillAV.ao-27eafab1bfbe5012a9dd5eb6a22a5e09a25b91a1b79c55ba29e0e7098dcc6f9f.exe

using DShowNET;
using System;
using System.Runtime.InteropServices;

namespace DirectX.Capture
{
  public class Tuner : IDisposable
  {
    protected IAMTVTuner tvTuner = (IAMTVTuner) null;

    public Tuner(IAMTVTuner tuner) => this.tvTuner = tuner;

    public int Channel
    {
      get
      {
        int plChannel;
        this.tvTuner.get_Channel(out plChannel, out int _, out int _);
        return plChannel;
      }
      set => this.tvTuner.put_Channel(value, AMTunerSubChannel.Default, AMTunerSubChannel.Default);
    }

    public TunerInputType InputType
    {
      get
      {
        DShowNET.TunerInputType inputType;
        this.tvTuner.get_InputType(0, out inputType);
        return (TunerInputType) inputType;
      }
      set => this.tvTuner.put_InputType(0, (DShowNET.TunerInputType) value);
    }

    public bool SignalPresent
    {
      get
      {
        AMTunerSignalStrength plSignalStrength;
        int errorCode = this.tvTuner.SignalPresent(out plSignalStrength);
        if (errorCode != 0)
          Marshal.ThrowExceptionForHR(errorCode);
        return plSignalStrength == AMTunerSignalStrength.SignalPresent;
      }
    }

    public void Dispose()
    {
      if (this.tvTuner != null)
        Marshal.ReleaseComObject((object) this.tvTuner);
      this.tvTuner = (IAMTVTuner) null;
    }
  }
}