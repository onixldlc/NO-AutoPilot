using System;

using HarmonyLib;

using JetBrains.Annotations;

using UnityEngine;

namespace NOAutopilot.Core.Map;

[HarmonyPatch(typeof(DynamicMap), "Minimize")]
internal static class MinimapZoomPatch
{
    private const float BaseScale = 2f;

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

            float zoom = Plugin.MinimapDefaultZoom?.Value ?? 1f;
            float scale = BaseScale * zoom;

            ___mapImage.transform.localScale = Vector3.one * scale;
        }
        catch (Exception ex)
        {
            Plugin.Logger.LogError($"[MinimapZoomPatch] Error: {ex}");
            Plugin.IsBroken = true;
        }
    }
}
