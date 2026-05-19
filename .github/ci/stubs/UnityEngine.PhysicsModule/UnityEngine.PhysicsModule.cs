using UnityEngine.Internal;

public class Physics
{
	[ExcludeFromDocs]
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo);

}
public struct RaycastHit
{
	[NativeName("point")]
	internal Vector3 m_Point;
	[NativeName("normal")]
	internal Vector3 m_Normal;
	[NativeName("faceID")]
	internal uint m_FaceID;
	[NativeName("distance")]
	internal float m_Distance;
	[NativeName("uv")]
	internal Vector2 m_UV;
	[NativeName("collider")]
	internal int m_Collider;

}
