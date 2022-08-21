﻿// Decompiled with JetBrains decompiler
// Type: DShowNET.IPin
// Assembly: yes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83EB8C5F-168C-47FA-93FE-E25AA6C64B02
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan.MSIL.KillAV.ao-937fd99ab6df975f8ace26b4ce6ead21ae41a82f170fbe18646720cacc517e69.exe

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DShowNET
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComVisible(true)]
  [Guid("56a86891-0ad4-11ce-b03a-0020af0ba770")]
  [ComImport]
  public interface IPin
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Connect([In] IPin pReceivePin, [MarshalAs(UnmanagedType.LPStruct), In] AMMediaType pmt);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int ReceiveConnection([In] IPin pReceivePin, [MarshalAs(UnmanagedType.LPStruct), In] AMMediaType pmt);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Disconnect();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int ConnectedTo(out IPin ppPin);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int ConnectionMediaType([MarshalAs(UnmanagedType.LPStruct), Out] AMMediaType pmt);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int QueryPinInfo(out PinInfo pInfo);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int QueryDirection(out PinDirection pPinDir);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int QueryId([MarshalAs(UnmanagedType.LPWStr)] out string Id);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int QueryAccept([MarshalAs(UnmanagedType.LPStruct), In] AMMediaType pmt);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int EnumMediaTypes(IntPtr ppEnum);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int QueryInternalConnections(IntPtr apPin, [In, Out] ref int nPin);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int EndOfStream();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int BeginFlush();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int EndFlush();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int NewSegment(long tStart, long tStop, double dRate);
  }
}