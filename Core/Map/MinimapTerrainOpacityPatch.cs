using System;

using HarmonyLib;

using JetBrains.Annotations;

using UnityEngine;
using UnityEngine.UI;

namespace NOAutopilot.Core.Map;

internal static class MinimapTerrainOpacityPatch
{
    private static Image s_terrainImage;

    public static void Reset()
    {
        s_terrainImage = null;
    }

    private static bool TryCacheTerrainImage(GameObject mapImage)
    {
        if (s_terrainImage != null)
        {
            return true;
        }

        s_terrainImage = mapImage.GetComponent<Image>();

        if (s_terrainImage == null)
        {
            Plugin.Logger.LogWarning("[MinimapTerrainOpacityPatch] Could not find Image on mapImage GameObject");
            return false;
        }

        return true;
    }

    private static void SetOpacity(float opacity)
    {
        if (s_terrainImage == null)
        {
            return;
        }

        Color c = s_terrainImage.color;
        c.a = Mathf.Clamp01(opacity);
        s_terrainImage.color = c;
    }

    [HarmonyPatch(typeof(DynamicMap), "CenterMinimizedMap")]
    internal static class ApplyOnMinimizedUpdate
    {
        [UsedImplicitly]
        private static void Postfix(GameObject ___mapImage)
        {
            if (Plugin.IsBroken && Plugin.UnpatchIfBroken.Value)
            {
                return;
            }

            try
            {
                if (DynamicMap.mapMaximized || ___mapImage == null)
                {
                    return;
                }

                if (!TryCacheTerrainImage(___mapImage))
                {
                    return;
                }

                SetOpacity(Plugin.MinimapTerrainOpacity?.Value ?? 1f);
            }
            catch (Exception ex)
            {
                Plugin.Logger.LogError($"[MinimapTerrainOpacityPatch] CenterMinimizedMap error: {ex}");
                Plugin.IsBroken = true;
            }
        }
    }

    [HarmonyPatch(typeof(DynamicMap), "Maximize")]
    internal static class RestoreOnMaximize
    {
        [UsedImplicitly]
        private static void Postfix(GameObject ___mapImage)
        {
            if (Plugin.IsBroken && Plugin.UnpatchIfBroken.Value)
            {
                return;
            }

            try
            {
                if (___mapImage == null)
                {
                    return;
                }

                if (!TryCacheTerrainImage(___mapImage))
                {
                    return;
                }

                SetOpacity(1f);
            }
            catch (Exception ex)
            {
                Plugin.Logger.LogError($"[MinimapTerrainOpacityPatch] Maximize error: {ex}");
                Plugin.IsBroken = true;
            }
        }
    }

    [HarmonyPatch(typeof(DynamicMap), "Minimize")]
    internal static class ApplyOnMinimize
    {
        [UsedImplicitly]
        private static void Postfix(GameObject ___mapImage)
        {
            if (Plugin.IsBroken && Plugin.UnpatchIfBroken.Value)
            {
                return;
            }

            try
            {
                if (___mapImage == null)
                {
                    return;
                }

                if (!TryCacheTerrainImage(___mapImage))
                {
                    return;
                }

                SetOpacity(Plugin.MinimapTerrainOpacity?.Value ?? 1f);
            }
            catch (Exception ex)
            {
                Plugin.Logger.LogError($"[MinimapTerrainOpacityPatch] Minimize error: {ex}");
                Plugin.IsBroken = true;
            }
        }
    }
}
