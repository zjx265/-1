﻿// Decompiled with JetBrains decompiler
// Type: nv.My.Resources.Resources
// Assembly: nv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D9D26A5E-13B6-4DC4-B014-052E2F5FE723
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan.MSIL.KillAV.ao-71e232c7af7ac92395beadd9c8a364c7e48a0978a010598a9978211f4ebd3b5a.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace nv.My.Resources
{
  [DebuggerNonUserCode]
  [StandardModule]
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [HideModuleName]
  public sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) nv.My.Resources.Resources.resourceMan, (object) null))
          nv.My.Resources.Resources.resourceMan = new ResourceManager("nv.Resources", typeof (nv.My.Resources.Resources).Assembly);
        return nv.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static CultureInfo Culture
    {
      get => nv.My.Resources.Resources.resourceCulture;
      set => nv.My.Resources.Resources.resourceCulture = value;
    }

    public static byte[] P => (byte[]) RuntimeHelpers.GetObjectValue(nv.My.Resources.Resources.ResourceManager.GetObject(nameof (P), nv.My.Resources.Resources.resourceCulture));

    public static string Q => nv.My.Resources.Resources.ResourceManager.GetString(nameof (Q), nv.My.Resources.Resources.resourceCulture);
  }
}