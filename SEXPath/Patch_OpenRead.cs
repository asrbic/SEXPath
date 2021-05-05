using System;
using System.IO;
using HarmonyLib;
using VRage.Utils;
using VRage.FileSystem;

namespace SEXPath
{
	public static class Patch_OpenRead
	{
		[HarmonyPatch(typeof(MyFileSystem), "OpenRead", new Type[] {typeof(string)})]
		public static void Postfix(string path, Stream __result)
		{
			path = "" + path;
			//MyLog.Default.WriteLine($"SEXPath: OpenRead PostFix Hook for path: "); //{path} stream: (len:{__result.Length}/pos:{__result.Position})");
		}
	}
}