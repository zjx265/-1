﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.InfoCards.SafeCryptoKeyHandle
// Assembly: infocard, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: ADE0A079-11DB-4A46-8BDE-D2A592CA8DEA
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Virus.Win32.Expiro.w-67b630ead60119692b9abbdfd8717c96904ef041127c2cae033c86b718eaa61e.exe

using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.InfoCards
{
  internal class SafeCryptoKeyHandle : SafeHandle
  {
    [SuppressUnmanagedCodeSecurity]
    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern bool CryptDestroyKey([In] IntPtr hKey);

    private SafeCryptoKeyHandle()
      : base(IntPtr.Zero, true)
    {
    }

    public override bool IsInvalid => IntPtr.Zero == this.handle;

    protected override bool ReleaseHandle() => SafeCryptoKeyHandle.CryptDestroyKey(this.handle);
  }
}