﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Build.Shared.ResourceUtilities
// Assembly: MSBuild, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: E42BAB90-704E-4C03-B5C0-D4E3A6B884E3
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Virus.Win32.Nimnul.c-d5c6463b93131b3c485115414cf5809e01323986e3d4274a4868222cbb54aa43.exe

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Microsoft.Build.Shared
{
  internal static class ResourceUtilities
  {
    private static readonly Regex msbuildMessageCodePattern = new Regex("^\\s*(?<CODE>MSB\\d\\d\\d\\d):\\s*(?<MESSAGE>.*)$", RegexOptions.Singleline);

    internal static string ExtractMessageCode(
      Regex messageCodePattern,
      string messageWithCode,
      out string code)
    {
      code = (string) null;
      string messageCode = messageWithCode;
      if (messageCodePattern == null)
        messageCodePattern = ResourceUtilities.msbuildMessageCodePattern;
      Match match = messageCodePattern.Match(messageWithCode);
      if (match.Success)
      {
        code = match.Groups["CODE"].Value;
        messageCode = match.Groups["MESSAGE"].Value;
      }
      return messageCode;
    }

    private static string GetHelpKeyword(string resourceName) => "MSBuild." + resourceName;

    internal static string FormatResourceString(
      out string code,
      out string helpKeyword,
      string resourceName,
      params object[] args)
    {
      helpKeyword = ResourceUtilities.GetHelpKeyword(resourceName);
      return ResourceUtilities.ExtractMessageCode((Regex) null, ResourceUtilities.FormatString(AssemblyResources.GetString(resourceName), args), out code);
    }

    internal static string FormatResourceString(string resourceName, params object[] args) => ResourceUtilities.FormatResourceString(out string _, out string _, resourceName, args);

    internal static string FormatString(string unformatted, params object[] args)
    {
      string str = unformatted;
      if (args != null && args.Length > 0)
        str = string.Format((IFormatProvider) CultureInfo.CurrentCulture, unformatted, args);
      return str;
    }
  }
}