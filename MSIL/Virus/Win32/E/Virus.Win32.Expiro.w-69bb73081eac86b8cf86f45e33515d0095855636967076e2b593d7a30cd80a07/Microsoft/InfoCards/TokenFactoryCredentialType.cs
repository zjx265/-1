﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.InfoCards.TokenFactoryCredentialType
// Assembly: infocard, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 516D8B44-4448-4D2C-8B8E-FFBB3FFE472B
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Virus.Win32.Expiro.w-69bb73081eac86b8cf86f45e33515d0095855636967076e2b593d7a30cd80a07.exe

namespace Microsoft.InfoCards
{
  internal enum TokenFactoryCredentialType
  {
    LocalCredential = -1, // 0xFFFFFFFF
    Invalid = 0,
    UserNamePasswordCredential = 1,
    SelfIssuedCredential = 2,
    X509CertificateCredential = 3,
    KerberosCredential = 4,
  }
}