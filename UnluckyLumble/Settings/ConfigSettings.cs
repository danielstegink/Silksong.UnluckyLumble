using BepInEx.Configuration;
using TeamCherry.Localization;

namespace UnluckyLumble.Settings
{
    public static class ConfigSettings
    {
        /// <summary>
        /// % chance of winning by default
        /// </summary>
        public static ConfigEntry<int> winChance;

        /// <summary>
        /// Initializes the settings
        /// </summary>
        /// <param name="config"></param>
        public static void Initialize(ConfigFile config)
        {
            // Bind set methods to Config
            LocalisedString name = new LocalisedString($"Mods.{UnluckyLumble.Id}", "NAME");
            LocalisedString description = new LocalisedString($"Mods.{UnluckyLumble.Id}", "DESC");
            int defaultValue = 25;
            if (name.Exists &&
                description.Exists)
            {
                winChance = config.Bind("Modifier", name, defaultValue, description);
            }
            else
            {
                winChance = config.Bind("Modifier", "1", defaultValue, "2");
            }
        }
    }
}