using BepInEx;

namespace MyFirstPlugin
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            GorillaTagger.OnPlayerSpawned(() => { GorillaTagger.Instance.offlineVRRig.head.overrideTarget = GorillaTagger.Instance.mainCamera.transform; });
            Logger.LogInfo($"Plugin {PluginInfo.GUID} is laoded!");
        }
        internal class PluginInfo
        {
            public const string GUID = "com.BP15.PCNeckMovement";
            public const string Name = "PCNeckMovement";
            public const string Version = "1.0.0";
        }
    }
}
