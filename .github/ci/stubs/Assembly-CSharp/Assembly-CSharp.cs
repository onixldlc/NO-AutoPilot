using Mirage;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class CursorManager
{
	public static bool GetFlag(CursorFlags flag) => throw null;

}
public class Pilot : MonoBehaviour, IDamageable
{
	public void SwitchState(PilotBaseState state) => throw null;

	public Vector3 GetAccel() => throw null;

}
public class FactionHQ : NetworkBehaviour
{
	public IEnumerable<Airbase> GetAirbases() => throw null;

}
public static class GlobalPositionExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GlobalPosition GlobalPosition(this Transform transform) => throw null;

}
public class LevelInfo : NetworkSceneSingleton<LevelInfo>
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float GetSpeedOfSound(float altitude) => throw null;

}
public static class UnitConverter
{
	public static string AltitudeReading(float altitude) => throw null;

	public static string ClimbRateReading(float speed) => throw null;

	public static string SpeedReading(float speed) => throw null;

	public static string DistanceReading(float distance) => throw null;

}
public class DynamicMap : SceneSingleton<DynamicMap>
{
	public void CenterMap() => throw null;

	public float GetZoomLevel() => throw null;

	public void SetZoomLevel(float zoomLevel) => throw null;

	private void UpdateMap() => throw null;

	public bool TryGetCursorCoordinates(out GlobalPosition position) => throw null;

	public static FactionMode GetFactionMode(FactionHQ hq = null, bool checkNoFactionBeforeSpectator = false) => throw null;

}
public struct GlobalPosition : IEquatable<GlobalPosition>
{
	[FieldOffset(0)]
	public float x;
	[FieldOffset(4)]
	public float y;
	[FieldOffset(8)]
	public float z;

	public readonly Vector3 AsVector3() => throw null;

}
public class ControlsFilter : MonoBehaviour
{
	public (bool, float[]) GetFlyByWireParameters() => throw null;

	public void SetFlyByWireParameters(bool enabled, float[] parameters) => throw null;

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
	public float GetFuelLevel() => throw null;

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
	public Transform GetHUDCenter() => throw null;

	public void SetAircraft(Aircraft aircraft) => throw null;

	public static void EnableCanvas(bool enable) => throw null;

}
public abstract class PilotBaseState
{
}
public class AIPilotLandingState : PilotBaseState
{
	private void SearchBestAirbase() => throw null;

}
public class GLOC : MonoBehaviour
{
	public void ResetGLOC() => throw null;

}
public sealed class Airbase : NetworkBehaviour, IEditorSelectable, ICapturable
{
	[RateLimit(Refill = 5, MaxTokens = 30, Penalty = 2)]
	[ServerRpc(requireAuthority = false)]
	public void CmdRegisterUsage(Aircraft aircraft, bool isUsing, byte? landingRunway) => throw null;

}
public class WeaponManager : MonoBehaviour
{
	public void Fire() => throw null;

}
public class AIPilotShortLandingState : PilotBaseState
{
	private void SearchBestAirbase() => throw null;

}
public interface IDamageable { }
public class NetworkBehaviour { }
public class NetworkSceneSingleton<T> { }
public class SceneSingleton<T> { }
public interface IEquatable<T> { }
public class Unit { }
public interface IRadarReturn { }
public interface IRearmable { }
public interface IRefuelable { }
public interface IEditorSelectable { }
public interface ICapturable { }
namespace Mirage { }
