using Mirage;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class CursorManager
{
	public static bool GetFlag(CursorFlags flag);

}
public class Pilot : MonoBehaviour, IDamageable
{
	public void SwitchState(PilotBaseState state);

	public Vector3 GetAccel();

}
public class FactionHQ : NetworkBehaviour
{
	public IEnumerable<Airbase> GetAirbases();

}
public static class GlobalPositionExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GlobalPosition GlobalPosition(this Transform transform);

}
public class LevelInfo : NetworkSceneSingleton<LevelInfo>
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float GetSpeedOfSound(float altitude);

}
public static class UnitConverter
{
	public static string AltitudeReading(float altitude);

	public static string ClimbRateReading(float speed);

	public static string SpeedReading(float speed);

	public static string DistanceReading(float distance);

}
public class DynamicMap : SceneSingleton<DynamicMap>
{
	public void CenterMap();

	public float GetZoomLevel();

	public void SetZoomLevel(float zoomLevel);

	private void UpdateMap();

	public bool TryGetCursorCoordinates(out GlobalPosition position);

	public static FactionMode GetFactionMode(FactionHQ hq = null, bool checkNoFactionBeforeSpectator = false);

}
public struct GlobalPosition : IEquatable<GlobalPosition>
{
	[FieldOffset(0)]
	public float x;
	[FieldOffset(4)]
	public float y;
	[FieldOffset(8)]
	public float z;

	public readonly Vector3 AsVector3();

}
public class ControlsFilter : MonoBehaviour
{
	public (bool, float[]) GetFlyByWireParameters();

	public void SetFlyByWireParameters(bool enabled, float[] parameters);

}
public enum CursorFlags
{
	None = 0,
	Pause = 1,
	Map = 2,
	SelectionMenu = 4,
	Dialogue = 8,
	NotInGame = 0x10,
	Chat = 0x20,
	EditorWindow = 0x40,
	Loading = 0x80,
	EmptyScene = 0x100
}
public class Aircraft : Unit, IRadarReturn, IRearmable, IRefuelable
{
	public float GetFuelLevel();

}
public enum FactionMode
{
	NoFaction = 0,
	Spectator = 1,
	Friendly = 2,
	Enemy = 4
}
public class FlightHud : SceneSingleton<FlightHud>
{
	public Transform GetHUDCenter();

	public void SetAircraft(Aircraft aircraft);

	public static void EnableCanvas(bool enable);

}
public abstract class PilotBaseState
{
}
public class AIPilotLandingState : PilotBaseState
{
	private void SearchBestAirbase();

}
public class GLOC : MonoBehaviour
{
	public void ResetGLOC();

}
public sealed class Airbase : NetworkBehaviour, IEditorSelectable, ICapturable
{
	[RateLimit(Refill = 5, MaxTokens = 30, Penalty = 2)]
	[ServerRpc(requireAuthority = false)]
	public void CmdRegisterUsage(Aircraft aircraft, bool isUsing, byte? landingRunway);

}
public class WeaponManager : MonoBehaviour
{
	public void Fire();

}
public class AIPilotShortLandingState : PilotBaseState
{
	private void SearchBestAirbase();

}
