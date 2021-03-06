using BepInEx;
using HarmonyLib;

namespace Hudini
{
    [BepInPlugin("org.bepinex.plugins.hudini", "Hudini", version)]
    public class HudiniPlugin : BaseUnityPlugin
    {
        public const string version = "0.1.0";

        // Awake is called once when both the game and the plug-in are loaded
        void Awake()
        {
            UnityEngine.Debug.Log("Hello from Hudini!");

            Harmony harmony = new Harmony("mod.hudini");
            harmony.PatchAll();
        }
    }
}
