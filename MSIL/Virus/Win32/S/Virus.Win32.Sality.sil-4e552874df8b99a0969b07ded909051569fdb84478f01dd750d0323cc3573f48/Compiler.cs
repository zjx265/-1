﻿// Decompiled with JetBrains decompiler
// Type: Compiler
// Assembly: jsc, Version=7.0.5000.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 64FE9439-6D79-4C3B-BBDD-9D73A741F992
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Virus.Win32.Sality.sil-4e552874df8b99a0969b07ded909051569fdb84478f01dd750d0323cc3573f48.exe

using System;
using System.Reflection;
using System.Security.Policy;

internal class Compiler
{
  public static int Main(string[] args)
  {
    AppDomainSetup info = new AppDomainSetup();
    info.PrivateBinPath = "";
    info.PrivateBinPathProbe = "*";
    try
    {
      return ((JScriptCompiler) AppDomain.CreateDomain(nameof (Compiler), (Evidence) null, info).CreateInstance(Assembly.GetAssembly(typeof (JScriptCompiler)).FullName, "JScriptCompiler").Unwrap()).Run(args);
    }
    catch (Exception ex)
    {
      Console.WriteLine(JScriptCompiler.Localize("INTERNAL COMPILER ERROR", ex.Message));
      return 10;
    }
  }
}