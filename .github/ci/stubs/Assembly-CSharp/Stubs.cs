// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using System;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp
{
    public class AIPilotLandingState
    {
        public void SearchBestAirbase() { throw new System.NotImplementedException(); }
    }

    public class AIPilotShortLandingState
    {
        public void SearchBestAirbase() { throw new System.NotImplementedException(); }
    }

    public class Airbase
    {
        public void CmdRegisterUsage(Aircraft aircraft, bool isUsing, byte? landingRunway) { throw new System.NotImplementedException(); }
    }

    public class Aircraft
    {
        public GlobalPosition GlobalPosition() { throw new System.NotImplementedException(); }
        public UnityEngine.Rigidbody GetComponent() { throw new System.NotImplementedException(); }
        public float GetFuelLevel() { throw new System.NotImplementedException(); }
    }

    public class ControlsFilter
    {
        public (bool, float[]) GetFlyByWireParameters() { throw new System.NotImplementedException(); }
        public void SetFlyByWireParameters(bool enabled, float[] parameters) { throw new System.NotImplementedException(); }
    }

    public class CursorManager
    {
        public static bool GetFlag(CursorFlags flag) { throw new System.NotImplementedException(); }
    }

    public class DynamicMap
    {
        public static FactionMode GetFactionMode(FactionHQ hq, bool checkNoFactionBeforeSpectator) { throw new System.NotImplementedException(); }
        public float GetZoomLevel() { throw new System.NotImplementedException(); }
        public void SetZoomLevel(float zoomLevel) { throw new System.NotImplementedException(); }
        public bool TryGetCursorCoordinates(out GlobalPosition position) { throw new System.NotImplementedException(); }
        public void UpdateMap() { throw new System.NotImplementedException(); }
        public void CenterMap() { throw new System.NotImplementedException(); }
    }

    public class FactionHQ
    {
        public System.Collections.Generic.IEnumerable<Airbase> GetAirbases() { throw new System.NotImplementedException(); }
    }

    public class FlightHud
    {
        public static void EnableCanvas(bool enable) { throw new System.NotImplementedException(); }
        public FuelGauge GetComponentInChildren(bool includeInactive) { throw new System.NotImplementedException(); }
        public UnityEngine.Transform GetHUDCenter() { throw new System.NotImplementedException(); }
        public void SetAircraft(Aircraft aircraft) { throw new System.NotImplementedException(); }
    }

    public class GLOC
    {
        public void ResetGLOC() { throw new System.NotImplementedException(); }
    }

    public class GlobalPosition
    {
        public UnityEngine.Vector3 AsVector3() { throw new System.NotImplementedException(); }
        public UnityEngine.Vector3 AsVector3() { throw new System.NotImplementedException(); }
    }

    public class GlobalPositionExtensions
    {
        public GlobalPosition GlobalPosition() { throw new System.NotImplementedException(); }
    }

    public class LevelInfo
    {
        public static float GetSpeedOfSound(float altitude) { throw new System.NotImplementedException(); }
    }

    public class Pilot
    {
        public UnityEngine.Vector3 GetAccel() { throw new System.NotImplementedException(); }
        public void SwitchState(PilotBaseState state) { throw new System.NotImplementedException(); }
    }

    public class UnitConverter
    {
        public static string AltitudeReading(float altitude) { throw new System.NotImplementedException(); }
        public static string ClimbRateReading(float speed) { throw new System.NotImplementedException(); }
        public static string DistanceReading(float distance) { throw new System.NotImplementedException(); }
        public static string SpeedReading(float speed) { throw new System.NotImplementedException(); }
    }

    public class WeaponManager
    {
        public void Fire() { throw new System.NotImplementedException(); }
    }

}
