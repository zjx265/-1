﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.InfoCards.SaveRecipientRequest
// Assembly: infocard, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 516D8B44-4448-4D2C-8B8E-FFBB3FFE472B
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Virus.Win32.Expiro.w-69bb73081eac86b8cf86f45e33515d0095855636967076e2b593d7a30cd80a07.exe

using Microsoft.InfoCards.Diagnostics;
using System;
using System.IO;

namespace Microsoft.InfoCards
{
  internal class SaveRecipientRequest : UIAgentRequest
  {
    private Recipient m_recipient;

    public SaveRecipientRequest(
      IntPtr rpcHandle,
      Stream inArgs,
      Stream outArgs,
      ClientUIRequest parent)
      : base(rpcHandle, inArgs, outArgs, parent)
    {
      InfoCardTrace.Assert(IntPtr.Zero != rpcHandle, "Null RPC handle");
      InfoCardTrace.Assert(null != inArgs, "Null InArgs");
      InfoCardTrace.Assert(null != outArgs, "Null outArgs");
    }

    protected override void OnInitializeAsSystem() => base.OnInitializeAsSystem();

    protected override void OnMarshalInArgs()
    {
      InfoCardTrace.Assert(null != this.InArgs, "Null inArgs");
      this.m_recipient = new Recipient(this.InArgs);
    }

    protected override void OnProcess()
    {
      StoreConnection connection = StoreConnection.GetConnection();
      try
      {
        InfoCardTrace.Assert(null != this.m_recipient, " Null Recipient");
        connection.BeginTransaction();
        try
        {
          this.m_recipient.Save(connection);
          connection.CommitTransaction();
        }
        catch
        {
          connection.RollbackTransaction();
          throw;
        }
      }
      finally
      {
        connection.Close();
      }
    }

    protected override void OnMarshalOutArgs()
    {
    }
  }
}