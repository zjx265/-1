﻿// Decompiled with JetBrains decompiler
// Type: accs.My.MyApplication
// Assembly: accs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 73B358C3-AEDD-4A5C-BAAE-891ED21EE1ED
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan.MSIL.Qhost.aul-fc4130dca4dee96e50bdf367eb6e9fecd635163b144402047bcb978d056f5043.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace accs.My
{
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    [STAThread]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerHidden]
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
    protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.accs;
  }
}