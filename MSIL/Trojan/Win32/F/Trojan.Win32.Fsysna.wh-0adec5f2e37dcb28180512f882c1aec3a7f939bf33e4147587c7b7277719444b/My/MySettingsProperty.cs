﻿// Decompiled with JetBrains decompiler
// Type: n.My.MySettingsProperty
// Assembly: n, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BFCF94BC-F711-4A63-941E-52FC7F306AC7
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan.Win32.Fsysna.wh-0adec5f2e37dcb28180512f882c1aec3a7f939bf33e4147587c7b7277719444b.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace n.My
{
  [DebuggerNonUserCode]
  [HideModuleName]
  [CompilerGenerated]
  [StandardModule]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        MySettings settings = MySettings.Default;
        return settings;
      }
    }
  }
}