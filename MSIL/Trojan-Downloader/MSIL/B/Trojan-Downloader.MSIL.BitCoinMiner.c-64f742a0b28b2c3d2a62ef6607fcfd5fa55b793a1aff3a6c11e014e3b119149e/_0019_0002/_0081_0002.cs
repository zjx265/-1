﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: WindowsBC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9909ee17073e3364
// MVID: 658BFC85-36E1-493D-98E6-AE9127D73D60
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan-Downloader.MSIL.BitCoinMiner.c-64f742a0b28b2c3d2a62ef6607fcfd5fa55b793a1aff3a6c11e014e3b119149e.exe

using \u000E;
using \u0019\u0002;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0019\u0002
{
  internal sealed class \u0081\u0002 : ICloneable
  {
    private \u0081\u0002.\u0082\u0002 \u0001;
    private int \u0002 = -1;
    private ushort \u0003;
    private string \u0004;
    private ulong \u0005;
    private ulong \u0006;
    private ushort \u0007;
    private uint \u0008;
    private uint \u000E;
    private \u007F\u0002 \u000F = \u007F\u0002.\u0002;
    private byte[] \u0010;
    private string \u0011;
    private int \u0012;
    private long \u0013 = -1;
    private long \u0014;
    private bool \u0015;
    private byte \u0016;
    private int \u0017;
    private int \u0018;

    internal \u0081\u0002([In] string obj0, [In] int obj1, [In] int obj2, [In] \u007F\u0002 obj3)
    {
      switch (obj0)
      {
        case null:
          throw new ArgumentNullException(\u0008.\u000E\u0003(3886));
        default:
          if (\u0011\u0003.\u007E\u0004\u0002((object) obj0) > (int) ushort.MaxValue)
            throw new ArgumentException(\u0008.\u000E\u0003(3905), \u0008.\u000E\u0003(3886));
          if (obj1 != 0 && obj1 < 10)
            throw new ArgumentOutOfRangeException(\u0008.\u000E\u0003(3930));
          this.\u0015\u0005(\u0017\u0004.\u0094\u0002());
          this.\u0004 = obj0;
          this.\u0003 = (ushort) obj2;
          this.\u0007 = (ushort) obj1;
          this.\u000F = obj3;
          break;
      }
    }

    [SpecialName]
    public bool \u009D\u0004() => (this.\u0012 & 1) != 0;

    [SpecialName]
    internal byte \u009E\u0004() => this.\u0016;

    [SpecialName]
    internal void \u009F\u0004([In] byte obj0) => this.\u0016 = obj0;

    [SpecialName]
    public int \u0001\u0005() => this.\u0012;

    [SpecialName]
    public void \u0002\u0005([In] int obj0) => this.\u0012 = obj0;

    [SpecialName]
    public long \u0003\u0005() => this.\u0013;

    [SpecialName]
    public void \u0004\u0005([In] long obj0) => this.\u0013 = obj0;

    [SpecialName]
    public long \u0005\u0005() => this.\u0014;

    [SpecialName]
    public void \u0006\u0005([In] long obj0) => this.\u0014 = obj0;

    [SpecialName]
    public int \u0007\u0005() => (this.\u0001 & \u0081\u0002.\u0082\u0002.\u0006) == \u0081\u0002.\u0082\u0002.\u0001 ? -1 : this.\u0002;

    [SpecialName]
    public void \u0008\u0005([In] int obj0)
    {
      this.\u0002 = obj0;
      this.\u0001 |= \u0081\u0002.\u0082\u0002.\u0006;
    }

    [SpecialName]
    public bool \u000E\u0005() => this.\u0010\u0005() == 0 || this.\u0010\u0005() == 10;

    private bool \u000F\u0005([In] int obj0)
    {
      bool flag = false;
      if ((this.\u0001 & \u0081\u0002.\u0082\u0002.\u0006) != \u0081\u0002.\u0082\u0002.\u0001 && (this.\u0010\u0005() == 0 || this.\u0010\u0005() == 10) && (this.\u0007\u0005() & obj0) == obj0)
        flag = true;
      return flag;
    }

    [SpecialName]
    public int \u0010\u0005() => (int) this.\u0003 >> 8 & (int) byte.MaxValue;

    [SpecialName]
    public int \u0019\u0004()
    {
      if (this.\u0007 != (ushort) 0)
        return (int) this.\u0007;
      int num = 10;
      if (this.\u001C\u0005() > 0)
        num = 51;
      else if (this.\u0012\u0005())
        num = 45;
      else if (\u007F\u0002.\u0002 == this.\u000F)
        num = 20;
      else if (this.\u0080\u0005())
        num = 20;
      else if (this.\u009D\u0004())
        num = 20;
      else if (this.\u000F\u0005(8))
        num = 11;
      return num;
    }

    [SpecialName]
    public bool \u0011\u0005()
    {
      bool flag = this.\u0015;
      if (!flag)
      {
        ulong num = this.\u0006;
        if (this.\u0007 == (ushort) 0 && this.\u009D\u0004())
          num += 12UL;
        flag = (this.\u0005 >= (ulong) uint.MaxValue || num >= (ulong) uint.MaxValue) && (this.\u0007 == (ushort) 0 || this.\u0007 >= (ushort) 45);
      }
      return flag;
    }

    [SpecialName]
    public bool \u0012\u0005() => this.\u0011\u0005() || this.\u0014 >= (long) uint.MaxValue;

    [SpecialName]
    public void \u0013\u0005([In] long obj0)
    {
      this.\u000E = (uint) obj0;
      this.\u0001 |= \u0081\u0002.\u0082\u0002.\u0005;
    }

    [SpecialName]
    public DateTime \u0014\u0005()
    {
      uint second = \u009E\u0003.\u0088\u0003(59U, (uint) (2 * ((int) this.\u000E & 31)));
      uint minute = \u009E\u0003.\u0088\u0003(59U, this.\u000E >> 5 & 63U);
      uint hour = \u009E\u0003.\u0088\u0003(23U, this.\u000E >> 11 & 31U);
      uint month = \u009E\u0003.\u0084\u0003(1U, \u009E\u0003.\u0088\u0003(12U, this.\u000E >> 21 & 15U));
      uint year = (uint) (((int) (this.\u000E >> 25) & (int) sbyte.MaxValue) + 1980);
      int day = \u0013\u0005.\u0083\u0003(1, \u0013\u0005.\u0087\u0003(\u0013\u0005.\u008E\u0002((int) year, (int) month), (int) (this.\u000E >> 16) & 31));
      return new DateTime((int) year, (int) month, day, (int) hour, (int) minute, (int) second);
    }

    [SpecialName]
    public void \u0015\u0005([In] DateTime obj0)
    {
      uint num1 = (uint) obj0.Year;
      uint num2 = (uint) obj0.Month;
      uint num3 = (uint) obj0.Day;
      uint num4 = (uint) obj0.Hour;
      uint num5 = (uint) obj0.Minute;
      uint num6 = (uint) obj0.Second;
      if (num1 < 1980U)
      {
        num1 = 1980U;
        num2 = 1U;
        num3 = 1U;
        num4 = 0U;
        num5 = 0U;
        num6 = 0U;
      }
      else if (num1 > 2107U)
      {
        num1 = 2107U;
        num2 = 12U;
        num3 = 31U;
        num4 = 23U;
        num5 = 59U;
        num6 = 59U;
      }
      this.\u0013\u0005((long) ((uint) (((int) num1 - 1980 & (int) sbyte.MaxValue) << 25 | (int) num2 << 21 | (int) num3 << 16 | (int) num4 << 11 | (int) num5 << 5) | num6 >> 1));
    }

    [SpecialName]
    public string \u0005\u0004() => this.\u0004;

    [SpecialName]
    public long \u0010\u0004() => (this.\u0001 & \u0081\u0002.\u0082\u0002.\u0002) == \u0081\u0002.\u0082\u0002.\u0001 ? -1L : (long) this.\u0005;

    [SpecialName]
    public void \u0011\u0004([In] long obj0)
    {
      this.\u0005 = (ulong) obj0;
      this.\u0001 |= \u0081\u0002.\u0082\u0002.\u0002;
    }

    [SpecialName]
    public long \u0016\u0005() => (this.\u0001 & \u0081\u0002.\u0082\u0002.\u0003) == \u0081\u0002.\u0082\u0002.\u0001 ? -1L : (long) this.\u0006;

    [SpecialName]
    public void \u0017\u0005([In] long obj0)
    {
      this.\u0006 = (ulong) obj0;
      this.\u0001 |= \u0081\u0002.\u0082\u0002.\u0003;
    }

    [SpecialName]
    public long \u0018\u0005() => (this.\u0001 & \u0081\u0002.\u0082\u0002.\u0004) == \u0081\u0002.\u0082\u0002.\u0001 ? -1L : (long) this.\u0008 & (long) uint.MaxValue;

    [SpecialName]
    public void \u0019\u0005([In] long obj0)
    {
      this.\u0008 = ((long) this.\u0008 & -4294967296L) == 0L ? (uint) obj0 : throw new ArgumentOutOfRangeException(\u0008.\u000E\u0003(943));
      this.\u0001 |= \u0081\u0002.\u0082\u0002.\u0004;
    }

    [SpecialName]
    public \u007F\u0002 \u001A\u0005() => this.\u000F;

    [SpecialName]
    public void \u001B\u0005([In] byte[] obj0)
    {
      if (obj0 == null)
      {
        this.\u0010 = (byte[]) null;
      }
      else
      {
        this.\u0010 = obj0.Length <= (int) ushort.MaxValue ? new byte[obj0.Length] : throw new ArgumentOutOfRangeException(\u0008.\u000E\u0003(943));
        \u008F\u0003.\u0098((Array) obj0, 0, (Array) this.\u0010, 0, obj0.Length);
      }
    }

    [SpecialName]
    public int \u001C\u0005()
    {
      switch (this.\u0018)
      {
        case 0:
          return 0;
        case 1:
          return 128;
        case 2:
          return 192;
        case 3:
          return 256;
        default:
          throw new ZipException(\u0002\u0005.\u001C\u0002((object) \u0008.\u000E\u0003(3963), (object) this.\u0018));
      }
    }

    [SpecialName]
    internal int \u001D\u0005() => this.\u001C\u0005() / 16;

    internal void \u001E\u0005([In] bool obj0)
    {
      \u0084\u0002 obj = new \u0084\u0002(this.\u0010);
      if (obj.\u0087\u0005(1))
      {
        this.\u0015 = true;
        if (obj.\u0084\u0005() < 4)
          throw new ZipException(\u0008.\u000E\u0003(4004));
        if (obj0 || this.\u0005 == (ulong) uint.MaxValue)
          this.\u0005 = (ulong) obj.\u0088\u0005();
        if (obj0 || this.\u0006 == (ulong) uint.MaxValue)
          this.\u0006 = (ulong) obj.\u0088\u0005();
        if (!obj0 && this.\u0014 == (long) uint.MaxValue)
          this.\u0014 = obj.\u0088\u0005();
      }
      else if (((int) this.\u0007 & (int) byte.MaxValue) >= 45 && (this.\u0005 == (ulong) uint.MaxValue || this.\u0006 == (ulong) uint.MaxValue))
        throw new ZipException(\u0008.\u000E\u0003(4081));
      if (obj.\u0087\u0005(10))
      {
        if (obj.\u0084\u0005() < 4)
          throw new ZipException(\u0008.\u000E\u0003(4150));
        obj.\u0087\u0003();
        while (obj.\u0086\u0005() >= 4)
        {
          int num1 = obj.\u0086\u0003();
          int num2 = obj.\u0086\u0003();
          if (num1 == 1)
          {
            if (num2 >= 24)
            {
              long num3 = obj.\u0088\u0005();
              obj.\u0088\u0005();
              obj.\u0088\u0005();
              this.\u0015\u0005(\u0084\u0003.\u008F\u0002(num3));
              break;
            }
            break;
          }
          obj.\u0089\u0005(num2);
        }
      }
      else if (obj.\u0087\u0005(21589))
      {
        int num = obj.\u0084\u0005();
        if ((obj.ReadByte() & 1) != 0 && num >= 5)
        {
          int seconds = obj.\u0087\u0003();
          DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0);
          this.\u0015\u0005(\u009B\u0004.\u009A\u0002(dateTime.ToUniversalTime(), new TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime());
        }
      }
      if (this.\u000F != \u007F\u0002.\u0005)
        return;
      this.\u001F\u0005(obj);
    }

    private void \u001F\u0005([In] \u0084\u0002 obj0)
    {
      if (!obj0.\u0087\u0005(39169))
        throw new ZipException(\u0008.\u000E\u0003(4229));
      this.\u0007 = (ushort) 51;
      this.\u0002\u0005(this.\u0001\u0005() | 64);
      int num1 = obj0.\u0084\u0005();
      if (num1 < 7)
        throw new ZipException(\u0097\u0003.\u001D\u0002((object) \u0008.\u000E\u0003(4183), (object) num1, (object) \u0008.\u000E\u0003(4216)));
      int num2 = obj0.\u0086\u0003();
      obj0.\u0086\u0003();
      int num3 = obj0.ReadByte();
      int num4 = obj0.\u0086\u0003();
      this.\u0017 = num2;
      this.\u0018 = num3;
      this.\u000F = (\u007F\u0002) num4;
    }

    [SpecialName]
    public void \u007F\u0005([In] string obj0)
    {
      switch (obj0)
      {
        case null:
          this.\u0011 = obj0;
          break;
        default:
          if (\u0011\u0003.\u007E\u0004\u0002((object) obj0) > (int) ushort.MaxValue)
            throw new ArgumentOutOfRangeException(\u0008.\u000E\u0003(943), \u0008.\u000E\u0003(4262));
          goto case null;
      }
    }

    [SpecialName]
    public bool \u0080\u0005()
    {
      int num = \u0011\u0003.\u007E\u0004\u0002((object) this.\u0004);
      return num > 0 && (\u0089\u0003.\u007E\u0003\u0002((object) this.\u0004, num - 1) == '/' || \u0089\u0003.\u007E\u0003\u0002((object) this.\u0004, num - 1) == '\\') || this.\u000F\u0005(16);
    }

    [SpecialName]
    public bool \u0081\u0005() => !this.\u0080\u0005() && !this.\u000F\u0005(8);

    public bool \u0082\u0005() => \u0081\u0002.\u0082\u0005(this.\u001A\u0005());

    public object Clone()
    {
      \u0081\u0002 obj = (\u0081\u0002) \u001B\u0005.\u0097((object) this);
      if (this.\u0010 != null)
      {
        obj.\u0010 = new byte[this.\u0010.Length];
        \u008F\u0003.\u0098((Array) this.\u0010, 0, (Array) obj.\u0010, 0, this.\u0010.Length);
      }
      return (object) obj;
    }

    public override string ToString() => this.\u0004;

    public static bool \u0082\u0005([In] \u007F\u0002 obj0) => obj0 == \u007F\u0002.\u0002 || obj0 == \u007F\u0002.\u0001;

    [Flags]
    private enum \u0082\u0002 : byte
    {
      \u0001 = 0,
      \u0002 = 1,
      \u0003 = 2,
      \u0004 = 4,
      \u0005 = 8,
      \u0006 = 16, // 0x10
    }
  }
}