﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.InfoCards.CheckStoreFileValidityRequest
// Assembly: infocard, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: ADE0A079-11DB-4A46-8BDE-D2A592CA8DEA
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Virus.Win32.Expiro.w-67b630ead60119692b9abbdfd8717c96904ef041127c2cae033c86b718eaa61e.exe

using Microsoft.InfoCards.Diagnostics;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Microsoft.InfoCards
{
  internal class CheckStoreFileValidityRequest : UIAgentRequest
  {
    private string m_filename;
    private bool m_valid = true;

    public CheckStoreFileValidityRequest(
      IntPtr rpcHandle,
      Stream inArgs,
      Stream outArgs,
      ClientUIRequest parent)
      : base(rpcHandle, inArgs, outArgs, parent)
    {
    }

    protected override void OnInitializeAsSystem() => base.OnInitializeAsSystem();

    protected override void OnMarshalInArgs() => this.m_filename = Utility.DeserializeString((BinaryReader) new InfoCardBinaryReader(this.InArgs, Encoding.Unicode));

    protected override void OnProcess()
    {
      try
      {
        try
        {
          using (FileStream fileStream = File.OpenRead(this.m_filename))
          {
            XmlReaderSettings defaultReaderSettings = InfoCardSchemas.CreateDefaultReaderSettings();
            defaultReaderSettings.IgnoreWhitespace = false;
            using (XmlReader reader = InfoCardSchemas.CreateReader((Stream) fileStream, defaultReaderSettings))
            {
              if (reader.IsStartElement("EncryptedStore", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
                return;
              this.m_valid = false;
            }
          }
        }
        catch (XmlSchemaValidationException ex)
        {
          throw InfoCardTrace.ThrowHelperError((Exception) new ImportException(SR.GetString("SchemaValidationFailed"), (Exception) ex));
        }
        catch (UnauthorizedAccessException ex)
        {
          throw InfoCardTrace.ThrowHelperError((Exception) new ImportException(SR.GetString("ImportInaccesibleFile"), (Exception) ex));
        }
        catch (IOException ex)
        {
          throw InfoCardTrace.ThrowHelperError((Exception) new ImportException(SR.GetString("InvalidImportFile"), (Exception) ex));
        }
        catch (XmlException ex)
        {
          throw InfoCardTrace.ThrowHelperError((Exception) new ImportException(SR.GetString("InvalidImportFile"), (Exception) ex));
        }
      }
      catch (ImportException ex)
      {
        this.m_valid = false;
      }
    }

    protected override void OnMarshalOutArgs() => new BinaryWriter(this.OutArgs).Write(this.m_valid);
  }
}