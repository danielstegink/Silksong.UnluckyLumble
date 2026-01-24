using HarmonyLib;
using HutongGames.PlayMaker.Actions;
using UnityEngine;
using UnluckyLumble.Settings;

namespace UnluckyLumble.Helpers
{
    [HarmonyPatch(typeof(BoolTest), "OnEnter")]
    public static class BoolTest_OnEnter
    {
        [HarmonyPrefix]
        public static void Prefix(BoolTest __instance)
        {
            if (__instance.fsm.name.Equals("Play Control") &&
                __instance.State.name.Equals("Who Won?") &&
                __instance.boolVariable.Name.Equals("Perfect Roll"))
            {
                if (Random.Range(1, 101) <= ConfigSettings.winChance.Value)
                {
                    __instance.boolVariable.Value = true;
                }
            }
        }
    }
}