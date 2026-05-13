// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mirage
{
    public interface INetworkPlayer
    {
    }

    public abstract class NetworkBehaviour : MonoBehaviour
    {
        public bool IsClientOnly
            => throw new System.NotImplementedException("Stub");
    }

    public class NetworkServer : MonoBehaviour
    {
        public bool Active { get; private set; }
        public IReadOnlyCollection<INetworkPlayer> AllPlayers
            => throw new System.NotImplementedException("Stub");
    }

    public class NetworkClient : MonoBehaviour
    {
        public bool Active
            => throw new System.NotImplementedException("Stub");
        public bool IsHost { get; private set; }
    }

}
