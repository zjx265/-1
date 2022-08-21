﻿// Decompiled with JetBrains decompiler
// Type: DShowNET.DsROT
// Assembly: yes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83EB8C5F-168C-47FA-93FE-E25AA6C64B02
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare.00004-msil\Trojan.MSIL.KillAV.ao-937fd99ab6df975f8ace26b4ce6ead21ae41a82f170fbe18646720cacc517e69.exe

using System;
using System.Runtime.InteropServices;

namespace DShowNET
{
  [ComVisible(false)]
  public class DsROT
  {
    private const int ROTFLAGS_REGISTRATIONKEEPSALIVE = 1;

    public static bool AddGraphToRot(object graph, out int cookie)
    {
      cookie = 0;
      UCOMIRunningObjectTable pprot = (UCOMIRunningObjectTable) null;
      UCOMIMoniker ppmk = (UCOMIMoniker) null;
      try
      {
        int runningObjectTable = DsROT.GetRunningObjectTable(0, out pprot);
        if (runningObjectTable < 0)
          Marshal.ThrowExceptionForHR(runningObjectTable);
        int currentProcessId = DsROT.GetCurrentProcessId();
        IntPtr iunknownForObject = Marshal.GetIUnknownForObject(graph);
        int num = (int) iunknownForObject;
        Marshal.Release(iunknownForObject);
        int itemMoniker = DsROT.CreateItemMoniker("!", string.Format("FilterGraph {0} pid {1}", (object) num.ToString("x8"), (object) currentProcessId.ToString("x8")), out ppmk);
        if (itemMoniker < 0)
          Marshal.ThrowExceptionForHR(itemMoniker);
        pprot.Register(1, graph, ppmk, out cookie);
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
      finally
      {
        if (ppmk != null)
          Marshal.ReleaseComObject((object) ppmk);
        if (pprot != null)
          Marshal.ReleaseComObject((object) pprot);
      }
    }

    public static bool RemoveGraphFromRot(ref int cookie)
    {
      UCOMIRunningObjectTable pprot = (UCOMIRunningObjectTable) null;
      try
      {
        DsROT.GetRunningObjectTable(0, out pprot);
        pprot.Revoke(cookie);
        cookie = 0;
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
      finally
      {
        if (pprot != null)
          Marshal.ReleaseComObject((object) pprot);
      }
    }

    [DllImport("ole32.dll")]
    private static extern int GetRunningObjectTable(int r, out UCOMIRunningObjectTable pprot);

    [DllImport("ole32.dll", CharSet = CharSet.Unicode)]
    private static extern int CreateItemMoniker(string delim, string item, out UCOMIMoniker ppmk);

    [DllImport("kernel32.dll")]
    private static extern int GetCurrentProcessId();
  }
}