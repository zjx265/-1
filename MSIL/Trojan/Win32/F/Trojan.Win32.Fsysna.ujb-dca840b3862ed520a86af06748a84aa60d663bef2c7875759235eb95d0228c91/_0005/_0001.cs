﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: csrss, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57F4D4CE-643E-4C92-9C47-86B837B59593
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan.Win32.Fsysna.ujb-dca840b3862ed520a86af06748a84aa60d663bef2c7875759235eb95d0228c91.exe

using \u0001;
using \u0004;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0005
{
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  internal sealed class \u0001
  {
    private static readonly \u0005.\u0001.\u0003<\u0004.\u0004> \u0001 = new \u0005.\u0001.\u0003<\u0004.\u0004>();
    private static readonly \u0005.\u0001.\u0003<\u0003> \u0001 = new \u0005.\u0001.\u0003<\u0003>();
    private static readonly \u0005.\u0001.\u0003<User> \u0001 = new \u0005.\u0001.\u0003<User>();
    private static \u0005.\u0001.\u0003<\u0005.\u0001.\u0001> \u0001 = new \u0005.\u0001.\u0003<\u0005.\u0001.\u0001>();
    private static readonly \u0005.\u0001.\u0003<\u0005.\u0001.\u0002> \u0001 = new \u0005.\u0001.\u0003<\u0005.\u0001.\u0002>();

    [SpecialName]
    internal static \u0004.\u0004 \u0002() => \u0005.\u0001.\u0001.\u0002();

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class \u0001
    {
      [NonSerialized]
      internal static \u0002 \u0001;

      [EditorBrowsable(EditorBrowsableState.Never)]
      public \u0001()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals([In] object obj0) => \u008A\u0002.\u0083\u0002((object) this, \u000E\u0002.\u0014\u0006(obj0));

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => \u001D\u0002.\u0084\u0002((object) this);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => \u0014\u0002.\u0082\u0002((object) this);

      static \u0001() => \u0001.\u0004.\u0002(typeof (\u0005.\u0001.\u0001));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class \u0002
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals([In] object obj0) => \u008A\u0002.\u0083\u0002((object) this, \u000E\u0002.\u0014\u0006(obj0));

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => \u001D\u0002.\u0084\u0002((object) this);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => \u0014\u0002.\u0082\u0002((object) this);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public \u0002()
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class \u0003<T> where T : new()
    {
      [SpecialName]
      internal T \u0002()
      {
        // ISSUE: reference to a compiler-generated field
        if ((object) \u0005.\u0001.\u0003<T>.\u0001 == null)
          goto label_2;
label_1:
        // ISSUE: reference to a compiler-generated field
        return \u0005.\u0001.\u0003<T>.\u0001;
label_2:
        // ISSUE: reference to a compiler-generated field
        \u0005.\u0001.\u0003<T>.\u0001 = new T();
        goto label_1;
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public \u0003()
      {
      }
    }
  }
}