using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

public class Input
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[NativeThrows]
	public static extern bool GetMouseButtonDown(int button);

	public static bool GetKey(string name) => throw null;

}
