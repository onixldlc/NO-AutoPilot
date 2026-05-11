using System;

using HarmonyLib;

using JetBrains.Annotations;

// using Rewired;

using UnityEngine;

namespace NOAutopilot.Core.Map;

[HarmonyPatch(typeof(DynamicMap), "CenterMinimizedMap")]
internal static class MinimapZoomPatch
{
    private static float s_minimapZoom = 1f;
    // private static Player s_player;

    // private static float MinZoom => Plugin.MinimapMinZoom?.Value ?? 0.01f;
    // private static float MaxZoom => Plugin.MinimapMaxZoom?.Value ?? 100f;
    // private const float ZoomSpeed = 0.05f;
    private const float BaseScale = 2f;

    public static void Reset()
    {
        s_minimapZoom = Plugin.MinimapDefaultZoom?.Value ?? 1f;
    }

    [UsedImplicitly]
    private static void Postfix(Transform ___mapScaleCenter)
    {
        if (Plugin.IsBroken && Plugin.UnpatchIfBroken.Value)
        {
            return;
        }

        try
        {
            if (___mapScaleCenter == null)
            {
                return;
            }

            if (DynamicMap.mapMaximized)
            {
                return;
            }

            CombatHUD hud = SceneSingleton<CombatHUD>.i;
            if (hud == null || hud.aircraft?.disabled != false)
            {
                return;
            }

            // s_player ??= ReInput.players.GetPlayer(0);

            // if (s_player == null)
            // {
            //     return;
            // }

            // float zoomInput = s_player.GetAxis("Zoom View");
            // if (zoomInput != 0f)
            // {
            //     s_minimapZoom *= 1f + (zoomInput * ZoomSpeed);
            //     s_minimapZoom = Mathf.Clamp(s_minimapZoom, MinZoom, MaxZoom);
            // }

            float scale = BaseScale * s_minimapZoom;
            ___mapScaleCenter.localScale = Vector3.one * scale;
        }
        catch (Exception ex)
        {
            Plugin.Logger.LogError($"[MinimapZoomPatch] Error: {ex}");
            Plugin.IsBroken = true;
        }
    }
}
