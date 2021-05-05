using HarmonyLib;
using Sandbox.Game.Entities.Blocks;
using System.Reflection;
using VRage.Plugins;
using VRage.Utils;

namespace SEXPath 
{
	public class Main: IPlugin
	{
		public void Dispose()
		{

		}

		public void Init(object gameInstance)
		{
			MyLog.Default.WriteLine($"SEXPath: Init begin");
			Harmony harmony = new Harmony("SEXPath");
			harmony.PatchAll();
			MyLog.Default.WriteLine($"SEXPath: Init end");
		}

		public void Update()
		{

		}
	}
}