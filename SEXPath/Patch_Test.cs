using System;
using System.IO;
using HarmonyLib;
using VRage.Utils;
using VRage.FileSystem;

namespace SEXPath
{
	public static class Patch_OpenTest
	{
		[HarmonyPatch(typeof(MyFileSystem), "CheckFileWriteAccess")]
		public static void Postfix()
		{
			//MyLog.Default.WriteLine("SEXPath: Test");
		}
	}
}