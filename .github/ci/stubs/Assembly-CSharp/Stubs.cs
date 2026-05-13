// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using Mirage;
using System.Collections.Generic;
using UnityEngine;

public static class CursorManager
{
    public static bool GetFlag(CursorFlags flag)
        => throw new System.NotImplementedException("Stub");
}

public static class GlobalPositionExtensions
{
    public static GlobalPosition GlobalPosition(Unit unit)
        => throw new System.NotImplementedException("Stub");
    public static GlobalPosition GlobalPosition(Transform transform)
        => throw new System.NotImplementedException("Stub");
    public static float GlobalY(Vector3 position)
        => throw new System.NotImplementedException("Stub");
    public static GlobalPosition ToGlobalPosition(Vector3 position)
        => throw new System.NotImplementedException("Stub");
}

public static class UnitConverter
{
    public static string AltitudeReading(float altitude)
        => throw new System.NotImplementedException("Stub");
    public static string ClimbRateReading(float speed)
        => throw new System.NotImplementedException("Stub");
    public static string DistanceReading(float distance)
        => throw new System.NotImplementedException("Stub");
    public static string SpeedReading(float speed)
        => throw new System.NotImplementedException("Stub");
}

public abstract class SceneSingleton<T> : MonoBehaviour
    where T : SceneSingleton<T>
{
    public static T i;
}

public static class PlayerSettings
{
    public static float hudTextSize;
    public static UnitSystem unitSystem;
}

public abstract class CameraBaseState
{
    public abstract void EnterState(CameraStateManager cam);
    public abstract void FixedUpdateState(CameraStateManager cam);
    public abstract void LeaveState(CameraStateManager cam);
    public abstract void UpdateState(CameraStateManager cam);
}

public abstract class PilotBaseState
{
    public abstract void EnterState(Pilot pilot);
    public abstract void FixedUpdateState(Pilot pilot);
    public abstract void LeaveState();
    public abstract void UpdateState(Pilot pilot);
}

public abstract class NetworkSceneSingleton<T> : NetworkBehaviour
    where T : NetworkSceneSingleton<T>
{
}

public abstract class MapIcon : MonoBehaviour
{
    public abstract void ClickIcon(ClickSource clickSource);
    public abstract string GetInfoText();
    public abstract void UpdateIcon(float mapDisplayFactor, float mapInverseScale, Transform mapTransform, bool mapMaximized);
}

public class Pilot : MonoBehaviour
{
    public PilotType pilotType;
    public PilotPlayerState playerState;
    public Vector3 GetAccel()
        => throw new System.NotImplementedException("Stub");
    public void SwitchState(PilotBaseState state) { }
}

public class WeaponManager : MonoBehaviour
{
    public WeaponStation currentWeaponStation;
    public void Fire() { }
}

public class Unit : NetworkBehaviour
{
    public bool disabled;
    public float radarAlt;
    public float speed;
    public FactionHQ NetworkHQ { get; set; }
}

public class FactionHQ : NetworkBehaviour
{
    public IEnumerable<Airbase> GetAirbases()
        => throw new System.NotImplementedException("Stub");
}

public class ControlsFilter : MonoBehaviour
{
    public ValueTuple<bool, float[]> GetFlyByWireParameters()
        => throw new System.NotImplementedException("Stub");
    public void SetFlyByWireParameters(bool enabled, float[] parameters) { }
}

public class GridLabels : MonoBehaviour
{
}

public class UnitPart : MonoBehaviour
{
    public Rigidbody rb;
}

public class Airbase : NetworkBehaviour
{
    public void CmdRegisterUsage(Aircraft aircraft, bool isUsing, Nullable<byte> landingRunway) { }
}

public class GLOC : MonoBehaviour
{
}

public class ControlInputs
{
    public float pitch;
    public float roll;
    public float throttle;
}

public class LandingGear : MonoBehaviour
{
}

public class WeaponStation
{
    public List<Weapon> Weapons;
}

public class PowerSupply : MonoBehaviour
{
}

public class HUDApp : MonoBehaviour
{
}

public class Weapon : MonoBehaviour
{
}

public class Aircraft : Unit
{
    public UnitPart cockpit;
    public GearState gearState;
    public Pilot[] pilots;
    public WeaponManager weaponManager;
    public float GetFuelLevel()
        => throw new System.NotImplementedException("Stub");
}

public struct GlobalPosition
{
    public float y;
    public Vector3 AsVector3()
        => throw new System.NotImplementedException("Stub");
}

public class LevelInfo : NetworkSceneSingleton<LevelInfo>
{
    public static float GetSpeedOfSound(float altitude)
        => throw new System.NotImplementedException("Stub");
}

public class DynamicMap : SceneSingleton<DynamicMap>
{
    public float mapDimension;
    public GameObject mapImage;
    public float mapScaleCurrent;
    public float mapScaleMinimized;
    public GameObject mapWaypoint;
    public GameObject mapWaypointVector;
    public List<MapIcon> selectedIcons;
    public static bool mapMaximized { get; private set; }
    public void CenterMap() { }
    public static FactionMode GetFactionMode(FactionHQ hq, bool checkNoFactionBeforeSpectator)
        => throw new System.NotImplementedException("Stub");
    public float GetZoomLevel()
        => throw new System.NotImplementedException("Stub");
    public void Maximize() { }
    public void Minimize() { }
    public void SetZoomLevel(float zoomLevel) { }
    public bool TryGetCursorCoordinates(out GlobalPosition position)
        => throw new System.NotImplementedException("Stub");
}

public class PilotPlayerState : PilotBaseState
{
    public override void EnterState(Pilot pilot) { }
    public override void FixedUpdateState(Pilot pilot) { }
    public override void LeaveState() { }
    public override void UpdateState(Pilot pilot) { }
}

public class CombatHUD : SceneSingleton<CombatHUD>
{
    public Aircraft aircraft;
    public void SetAircraft(Aircraft aircraft) { }
}

public class UnitMapIcon : MapIcon
{
    public Unit unit { get; private set; }
    public override void ClickIcon(ClickSource clickSource) { }
    public override string GetInfoText()
        => throw new System.NotImplementedException("Stub");
    public override void UpdateIcon(float mapDisplayFactor, float mapInverseScale, Transform mapTransform, bool mapMaximized) { }
}

public class Building : Unit
{
}

public class FlightHud : SceneSingleton<FlightHud>
{
    public static void EnableCanvas(bool enable) { }
    public Transform GetHUDCenter()
        => throw new System.NotImplementedException("Stub");
    public void SetAircraft(Aircraft aircraft) { }
}

public class FuelGauge : HUDApp
{
}

public class CameraStateManager : SceneSingleton<CameraStateManager>
{
    public CameraCockpitState cockpitState;
    public CameraBaseState currentState { get; private set; }
}

public class CameraCockpitState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
}

public class AIPilotLandingState : PilotBaseState
{
    public override void EnterState(Pilot pilot) { }
    public override void FixedUpdateState(Pilot pilot) { }
    public override void LeaveState() { }
    public override void UpdateState(Pilot pilot) { }
}

public class AIPilotShortLandingState : PilotBaseState
{
    public override void EnterState(Pilot pilot) { }
    public override void FixedUpdateState(Pilot pilot) { }
    public override void LeaveState() { }
    public override void UpdateState(Pilot pilot) { }
}

public class AIPilotTaxiState : PilotBaseState
{
    public override void EnterState(Pilot pilot) { }
    public override void FixedUpdateState(Pilot pilot) { }
    public override void LeaveState() { }
    public override void UpdateState(Pilot pilot) { }
}

public class JammingPod : Weapon
{
}

public enum CursorFlags
{
    Chat
}

public enum UnitSystem
{
    Imperial
}

public enum FactionMode
{
    Friendly
}

public enum PilotType
{
    Helo,
    Tiltwing
}

public enum GearState
{
    LockedRetracted
}

