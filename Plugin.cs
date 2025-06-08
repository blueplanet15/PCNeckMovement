using BepInEx.Logging;
using System;

namespace PCNeckMovement
{
    public class Plugin
    {
        public void Awake()
        {
            GorillaTagger.OnPlayerSpawned(Initialize);
        }
        private async void Initialize()
        {
            GorillaTagger.Instance.offlineVRRig.head.overrideTarget = GorillaTagger.Instance.mainCamera.transform;
        }
    }
}
