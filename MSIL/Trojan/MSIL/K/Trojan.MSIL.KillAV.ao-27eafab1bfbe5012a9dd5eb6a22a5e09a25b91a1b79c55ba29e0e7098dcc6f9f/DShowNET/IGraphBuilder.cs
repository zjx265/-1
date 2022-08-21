﻿// Decompiled with JetBrains decompiler
// Type: DShowNET.IGraphBuilder
// Assembly: p, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91D63E37-42E0-404C-97F4-07116ACD2D57
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan.MSIL.KillAV.ao-27eafab1bfbe5012a9dd5eb6a22a5e09a25b91a1b79c55ba29e0e7098dcc6f9f.exe

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DShowNET
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("56a868a9-0ad4-11ce-b03a-0020af0ba770")]
  [ComVisible(true)]
  [ComImport]
  public interface IGraphBuilder
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int AddFilter([In] IBaseFilter pFilter, [MarshalAs(UnmanagedType.LPWStr), In] string pName);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int RemoveFilter([In] IBaseFilter pFilter);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int EnumFilters(out IEnumFilters ppEnum);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int FindFilterByName([MarshalAs(UnmanagedType.LPWStr), In] string pName, out IBaseFilter ppFilter);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int ConnectDirect([In] IPin ppinOut, [In] IPin ppinIn, [MarshalAs(UnmanagedType.LPStruct), In] AMMediaType pmt);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Reconnect([In] IPin ppin);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Disconnect([In] IPin ppin);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int SetDefaultSyncSource();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Connect([In] IPin ppinOut, [In] IPin ppinIn);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Render([In] IPin ppinOut);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int RenderFile([MarshalAs(UnmanagedType.LPWStr), In] string lpcwstrFile, [MarshalAs(UnmanagedType.LPWStr), In] string lpcwstrPlayList);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int AddSourceFilter([MarshalAs(UnmanagedType.LPWStr), In] string lpcwstrFileName, [MarshalAs(UnmanagedType.LPWStr), In] string lpcwstrFilterName, out IBaseFilter ppFilter);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int SetLogFile(IntPtr hFile);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Abort();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int ShouldOperationContinue();
  }
}