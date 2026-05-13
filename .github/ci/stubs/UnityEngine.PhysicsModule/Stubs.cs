// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

namespace UnityEngine
{
    public class Rigidbody : Component
    {
        public Vector3 angularVelocity { get; set; }
        public Vector3 position { get; set; }
        public Vector3 velocity { get; set; }
    }

    public class Physics
    {
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Ray ray, float radius, float maxDistance)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Ray ray, float radius)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance)
            => throw new System.NotImplementedException("Stub");
        public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo)
            => throw new System.NotImplementedException("Stub");
    }

    public struct RaycastHit
    {
        public float distance { get; set; }
        public Vector3 normal { get; set; }
        public Transform transform { get; }
    }

    public enum QueryTriggerInteraction
    {
    }

}
