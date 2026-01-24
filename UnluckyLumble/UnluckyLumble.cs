using BepInEx;
using HarmonyLib;
using UnluckyLumble.Settings;

namespace UnluckyLumble;

[BepInAutoPlugin(id: "io.github.danielstegink.unluckylumble")]
[BepInDependency("org.silksong-modding.i18n")]
public partial class UnluckyLumble : BaseUnityPlugin
{
    /// <summary>
    /// Static instance for ease of reference
    /// </summary>
    internal static UnluckyLumble instance;

    private void Awake()
    {
        // Put your initialization logic here
        instance = this;

        Harmony harmony = new Harmony(Id);
        harmony.PatchAll();

        Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");
    }

    private void Start()
    {
        ConfigSettings.Initialize(Config);
    }

    /// <summary>
    /// Shared logger for external classes
    /// </summary>
    /// <param name="message"></param>
    internal void Log(string message)
    {
        Logger.LogInfo(message);
    }
}