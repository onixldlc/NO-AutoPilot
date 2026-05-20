using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

public class GUI
{
	public static extern void FocusControl(string name);

	public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style) => throw null;

	public static void DragWindow() => throw null;

	public static void Label(Rect position, GUIContent content, GUIStyle style) => throw null;

	public static void Box(Rect position, GUIContent content, GUIStyle style) => throw null;

}
public sealed class Event
{
	public void Use() => throw null;

}
public class GUILayout
{
	public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options) => throw null;

	public static GUILayoutOption Height(float height) => throw null;

	public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static GUILayoutOption Width(float width) => throw null;

	public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static void EndHorizontal() => throw null;

	public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static void EndVertical() => throw null;

	internal static void EndScrollView(bool handleScrollWheel) => throw null;

	public static void FlexibleSpace() => throw null;

	public static GUILayoutOption ExpandWidth(bool expand) => throw null;

}
public sealed class GUIStyle
{
	public Vector2 CalcSize(GUIContent content) => throw null;

}
public class GUILayoutUtility
{
	public static Rect GetLastRect() => throw null;

}
public class GUIContent
{
}
