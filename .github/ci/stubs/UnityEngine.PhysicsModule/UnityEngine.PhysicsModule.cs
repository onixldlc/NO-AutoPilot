using UnityEngine;
using UnityEngine.Internal;

public class Physics
{
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo) => throw null;

	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => throw null;

	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) => throw null;

}
public struct RaycastHit
{
	public float distance;
	public Vector3 normal;
	public Transform transform;
	public Vector3 point;
}
