using BepInEx;
using Photon.Pun;

namespace PCNeckMovement
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            GorillaTagger.OnPlayerSpawned(() => { GorillaTagger.Instance.offlineVRRig.head.overrideTarget = GorillaTagger.Instance.mainCamera.transform; });
            PhotonNetwork.LocalPlayer.SetCustomProperties(new ExitGames.Client.Photon.Hashtable()
            {
                {
                    PluginInfo.Name,
                    PluginInfo.Version
                }
            }, null, null);
            Logger.LogInfo($"Plugin {PluginInfo.GUID} is laoded!");
        }
    }
}
