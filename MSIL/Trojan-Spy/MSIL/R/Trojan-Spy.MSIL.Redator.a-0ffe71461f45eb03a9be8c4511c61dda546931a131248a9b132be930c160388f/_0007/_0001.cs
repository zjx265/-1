﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: Stub, Version=2.1.1.1, Culture=neutral, PublicKeyToken=null
// MVID: EC6FBD32-3576-4D40-B4A5-7808EA9CDA7F
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan-Spy.MSIL.Redator.a-0ffe71461f45eb03a9be8c4511c61dda546931a131248a9b132be930c160388f.exe

using \u0004;
using \u0005;
using \u0007;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace \u0007
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  [CompilerGenerated]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class \u0001 : ApplicationSettingsBase
  {
    private static \u0001 \u0001 = (\u0001) SettingsBase.Synchronized((SettingsBase) new \u0001());
    private static bool \u0001;
    private static object \u0001 = RuntimeHelpers.GetObjectValue(new object());

    [DebuggerNonUserCode]
    public \u0001()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerNonUserCode]
    private static void \u0003(object sender, EventArgs e)
    {
      if (!\u0002.\u0003().SaveMySettingsOnExit)
        return;
      \u0003.\u0003().Save();
    }

    public static \u0001 Default
    {
      get
      {
        if (!\u0001.\u0001)
        {
          object Expression = \u0001.\u0001;
          ObjectFlowControl.CheckForSyncLockOnValueType(Expression);
          Monitor.Enter(Expression);
          try
          {
            if (!\u0001.\u0001)
            {
              \u0002.\u0003().Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!\u0002.\u0003().SaveMySettingsOnExit)
                  return;
                \u0003.\u0003().Save();
              });
              \u0001.\u0001 = true;
            }
          }
          finally
          {
            Monitor.Exit(Expression);
          }
        }
        return \u0001.\u0001;
      }
    }
  }
}