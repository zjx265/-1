﻿// Decompiled with JetBrains decompiler
// Type: SevenZip.Compression.LZ.IInWindowStream
// Assembly: actmp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50C41484-D1A9-4872-9CEC-A8081495D24E
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan-Dropper.MSIL.Late.iv-ca1bc7f9d82b3530e22d7ae6728ebded4829bf8ebc63ceb2e8d24ac8e3f7cf57.exe

using System.IO;

namespace SevenZip.Compression.LZ
{
  internal interface IInWindowStream
  {
    void SetStream(Stream inStream);

    void Init();

    void ReleaseStream();

    byte GetIndexByte(int index);

    uint GetMatchLen(int index, uint distance, uint limit);

    uint GetNumAvailableBytes();
  }
}