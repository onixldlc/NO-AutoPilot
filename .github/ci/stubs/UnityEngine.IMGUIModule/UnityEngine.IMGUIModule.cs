using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

public class GUI
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[FreeFunction("GetGUIState().FocusKeyboardControl")]
	public static extern void FocusControl(string name);

	public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style);

	public static void DragWindow();

	public static void Label(Rect position, GUIContent content, GUIStyle style);

	public static void Box(Rect position, GUIContent content, GUIStyle style);

}
public sealed class Event
{
	public void Use();

}
public class GUILayout
{
	public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options);

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options);

	public static GUILayoutOption Height(float height);

	public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options);

	public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options);

	public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options);

	public static GUILayoutOption Width(float width);

	public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options);

	public static void EndHorizontal();

	public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options);

	public static void EndVertical();

	internal static void EndScrollView(bool handleScrollWheel);

	public static void FlexibleSpace();

	public static GUILayoutOption ExpandWidth(bool expand);

}
public sealed class GUIStyle
{
	public Vector2 CalcSize(GUIContent content);

}
public class GUILayoutUtility
{
	public static Rect GetLastRect();

}
public class GUIContent
{
}
