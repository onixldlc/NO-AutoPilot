// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using UnityEngine;

namespace Mirage
{
    public interface INetworkPlayer
    {
    }

    public abstract class NetworkBehaviour : MonoBehaviour
    {
        public bool IsClientOnly { get; }
    }

    public class NetworkServer : MonoBehaviour
    {
        public bool Active { get; private set; }
        public IReadOnlyCollection<INetworkPlayer> AllPlayers { get; }
    }

    public class NetworkClient : MonoBehaviour
    {
        public bool Active { get; }
        public bool IsHost { get; private set; }
    }

}
