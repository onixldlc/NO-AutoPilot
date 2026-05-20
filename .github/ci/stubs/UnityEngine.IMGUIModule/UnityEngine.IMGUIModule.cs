using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

public delegate void WindowFunction(int id);

public sealed class GUILayoutOption
{
}

public class GUISkin
{
	public GUIStyle label;
	public GUIStyle button;
	public GUIStyle textField;
	public GUIStyle toggle;
	public GUIStyle box;
	public GUIStyle window;
}

public class GUI
{
	public static GUISkin skin;
	public static Color color;
	public static Color backgroundColor;
	public static int depth;
	public static string tooltip;

	public static extern void FocusControl(string name);

	public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style) => throw null;
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string title) => throw null;

	public static void DragWindow() => throw null;
	public static void DragWindow(Rect position) => throw null;

	public static void Label(Rect position, string text) => throw null;
	public static void Label(Rect position, GUIContent content, GUIStyle style) => throw null;
	public static void Label(Rect position, string text, GUIStyle style) => throw null;

	public static void Box(Rect position, string text) => throw null;
	public static void Box(Rect position, GUIContent content, GUIStyle style) => throw null;

}
public sealed class Event
{
	public static Event current;

	public EventType type;
	public KeyCode keyCode;
	public Vector2 mousePosition;
	public Vector2 delta;

	public void Use() => throw null;

}
public class GUILayout
{
	public static void Label(string text, params GUILayoutOption[] options) => throw null;
	public static void Label(string text, GUIStyle style, params GUILayoutOption[] options) => throw null;
	public static void Label(GUIContent content, params GUILayoutOption[] options) => throw null;
	public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options) => throw null;
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options) => throw null;
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options) => throw null;

	public static void EndScrollView() => throw null;

	public static GUILayoutOption Height(float height) => throw null;

	public static void BeginVertical(params GUILayoutOption[] options) => throw null;
	public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options) => throw null;
	public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static void BeginHorizontal(params GUILayoutOption[] options) => throw null;
	public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options) => throw null;
	public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static bool Button(string text, params GUILayoutOption[] options) => throw null;
	public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options) => throw null;
	public static bool Button(GUIContent content, params GUILayoutOption[] options) => throw null;
	public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static GUILayoutOption Width(float width) => throw null;

	public static string TextField(string text, params GUILayoutOption[] options) => throw null;
	public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options) => throw null;
	public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static void EndHorizontal() => throw null;

	public static bool Toggle(bool value, string text, params GUILayoutOption[] options) => throw null;
	public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options) => throw null;
	public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options) => throw null;
	public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options) => throw null;

	public static void EndVertical() => throw null;

	public static void FlexibleSpace() => throw null;

	public static GUILayoutOption ExpandWidth(bool expand) => throw null;

	public static void Space(float pixels) => throw null;

	public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options) => throw null;
}
public sealed class GUIStyle
{
	public TextAnchor alignment;
	public bool richText;
	public RectOffset padding;
	public RectOffset margin;
	public int fontSize;
	public FontStyle fontStyle;
	public bool wordWrap;
	public GUIStyleState normal;

	public static GUIStyle none;

	public GUIStyle() { }
	public GUIStyle(GUIStyle other) => throw null;

	public Vector2 CalcSize(GUIContent content) => throw null;

}
public class GUIStyleState
{
	public Color textColor;
}
public class GUILayoutUtility
{
	public static Rect GetLastRect() => throw null;

}
public class GUIContent
{
	public string text;
	public string tooltip;

	public GUIContent() { }
	public GUIContent(string text) => throw null;
	public GUIContent(string text, string tooltip) => throw null;
}
