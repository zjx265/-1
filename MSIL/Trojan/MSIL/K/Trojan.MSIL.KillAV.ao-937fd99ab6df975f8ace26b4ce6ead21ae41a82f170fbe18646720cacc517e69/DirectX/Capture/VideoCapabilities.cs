﻿// Decompiled with JetBrains decompiler
// Type: DirectX.Capture.VideoCapabilities
// Assembly: yes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83EB8C5F-168C-47FA-93FE-E25AA6C64B02
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan.MSIL.KillAV.ao-937fd99ab6df975f8ace26b4ce6ead21ae41a82f170fbe18646720cacc517e69.exe

using DShowNET;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DirectX.Capture
{
  public class VideoCapabilities
  {
    public Size InputSize;
    public Size MinFrameSize;
    public Size MaxFrameSize;
    public int FrameSizeGranularityX;
    public int FrameSizeGranularityY;
    public double MinFrameRate;
    public double MaxFrameRate;

    internal VideoCapabilities(IAMStreamConfig videoStreamConfig)
    {
      AMMediaType mediaType = (AMMediaType) null;
      IntPtr num = IntPtr.Zero;
      try
      {
        int piCount;
        int numberOfCapabilities = videoStreamConfig.GetNumberOfCapabilities(out piCount, out int _);
        if (numberOfCapabilities != 0)
          Marshal.ThrowExceptionForHR(numberOfCapabilities);
        if (piCount <= 1)
          ;
        num = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof (VideoStreamConfigCaps)));
        IntPtr pmt;
        int streamCaps = videoStreamConfig.GetStreamCaps(0, out pmt, num);
        if (streamCaps != 0)
          Marshal.ThrowExceptionForHR(streamCaps);
        mediaType = (AMMediaType) Marshal.PtrToStructure(pmt, typeof (AMMediaType));
        VideoStreamConfigCaps structure = (VideoStreamConfigCaps) Marshal.PtrToStructure(num, typeof (VideoStreamConfigCaps));
        this.InputSize = structure.InputSize;
        this.MinFrameSize = structure.MinOutputSize;
        this.MaxFrameSize = structure.MaxOutputSize;
        this.FrameSizeGranularityX = structure.OutputGranularityX;
        this.FrameSizeGranularityY = structure.OutputGranularityY;
        this.MinFrameRate = 10000000.0 / (double) structure.MaxFrameInterval;
        this.MaxFrameRate = 10000000.0 / (double) structure.MinFrameInterval;
      }
      finally
      {
        if (num != IntPtr.Zero)
          Marshal.FreeCoTaskMem(num);
        IntPtr zero = IntPtr.Zero;
        if (mediaType != null)
          DsUtils.FreeAMMediaType(mediaType);
      }
    }
  }
}