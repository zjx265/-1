﻿// Decompiled with JetBrains decompiler
// Type: AHSJKHwyIUYUIYIYI8sOIioOID.My.MyApplication
// Assembly: Publicloggerversionztub, Version=2.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 02BBAAFD-61B0-4722-9D55-257F48A7F005
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan-Spy.MSIL.KeyLogger.ajb-34132edf41a9fe3359ebc67aedcf2dca594b4e5145bfa81e9a8b1d0fa57c1b2f.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace AHSJKHwyIUYUIYIYI8sOIioOID.My
{
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerHidden]
    [STAThread]
    internal static void Main(string[] Args)
    {
      try
      {
        Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
      }
      finally
      {
      }
      MyProject.Application.Run(Args);
    }

    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      this.IsSingleInstance = false;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = true;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.Form1;
  }
}