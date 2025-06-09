using BepInEx.Logging;
using System;

namespace PCNeckMovement
{
    public class Plugin
    {
        void Start()
        {
            GorillaTagger.Instance.offlineVRRig.head.overrideTarget = GorillaTagger.Instance.mainCamera.transform;
        }
    }
}
