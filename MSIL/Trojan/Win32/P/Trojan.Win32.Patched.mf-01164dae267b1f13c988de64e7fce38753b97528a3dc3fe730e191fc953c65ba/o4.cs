﻿// Decompiled with JetBrains decompiler
// Type: o4
// Assembly: XobniService, Version=1.8.3.7917, Culture=neutral, PublicKeyToken=6298d2d1fcfb5d85
// MVID: EA9F7D71-4A8D-4739-A320-5F01FC76E972
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan.Win32.Patched.mf-01164dae267b1f13c988de64e7fce38753b97528a3dc3fe730e191fc953c65ba.exe

using Microsoft.Win32;
using System;
using System.Net;
using XobniLogging;

internal static class o4
{
  private const int a = 3;
  private const string b = "LoadBehavior";
  private const string c = "XobniDisable";
  private const string d = "SoftDisableWatcher";
  private const string e = "Software\\Microsoft\\Office\\Outlook\\Addins\\XobniMainConnectorShim.Connect";
  private static readonly string f = "http://client." + u5.a() + "/recordping?pingType=resetLoadBehavior&xmid={0}";

  internal static void a(bool? A_0)
  {
    try
    {
      if (A_0.GetValueOrDefault(false))
        return;
      using (RegistryKey A_0_1 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Office\\Outlook\\Addins\\XobniMainConnectorShim.Connect", true))
      {
        if (!o4.a(A_0_1))
          return;
        A_0_1.SetValue("LoadBehavior", (object) 3);
        if (!rx.e())
          return;
        o4.a();
      }
    }
    catch (Exception ex)
    {
      ady.a(Level.Exception, "Exception checking soft disable", ex);
    }
  }

  private static bool a(RegistryKey A_0)
  {
    if (A_0 == null || A_0.GetValue("XobniDisable", (object) null) != null)
      return false;
    int? nullable1 = gs.a<int>(A_0.GetValue("LoadBehavior"));
    if (!nullable1.HasValue)
      return false;
    int? nullable2 = nullable1;
    return (nullable2.GetValueOrDefault() != 3 ? 0 : (nullable2.HasValue ? 1 : 0)) == 0;
  }

  private static void a()
  {
    HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(string.Format(o4.f, (object) jf.a()));
    httpWebRequest.KeepAlive = false;
    try
    {
      httpWebRequest.GetResponse();
    }
    catch (WebException ex)
    {
      ady.a(Level.Debug, "Could not ping disable Url: " + ex.Message);
    }
  }
}