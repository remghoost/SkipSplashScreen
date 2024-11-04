using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

using PerfectRandom.Sulfur.Gameplay;

using BepInEx.Logging;
using BepInEx.Unity.Mono;
using BepInEx;


namespace SkipSplashScreen;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class SkipSplashScreen : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
    private Harmony harmony;
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        // Initialize Harmony and patch methods
        harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();
    }
    [HarmonyPatch(typeof(PerfectRandom.Sulfur.Gameplay.Cinematics.SplashScreen))]
    [HarmonyPatch("Start")]
    public class SplashScreenPatch
    {
        static bool Prefix(PerfectRandom.Sulfur.Gameplay.Cinematics.SplashScreen __instance)
        {
            Logger.LogInfo("Splash screen patch hit!");
            // Use Addressables to load the main menu
            UnityEngine.AddressableAssets.Addressables.LoadSceneAsync(
                "Scenes/MainMenu.unity", 
                LoadSceneMode.Single,
                true,
                100
            );
            return false;
        }
    }
}