// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

public class WindowFunction : MulticastDelegate
{
}

namespace UnityEngine
{
    public class GUI
    {
        public static Color backgroundColor { get; set; }
        public static Color color { get; set; }
        public static int depth { get; set; }
        public static GUISkin skin { get; set; }
        public static string tooltip { get; set; }
        public static void Box(Rect position, string text) { }
        public static void Box(Rect position, Texture image) { }
        public static void Box(Rect position, GUIContent content) { }
        public static void Box(Rect position, string text, GUIStyle style) { }
        public static void Box(Rect position, Texture image, GUIStyle style) { }
        public static void Box(Rect position, GUIContent content, GUIStyle style) { }
        public static void DragWindow(Rect position) { }
        public static void DragWindow() { }
        public static void FocusControl(string name) { }
        public static void Label(Rect position, string text) { }
        public static void Label(Rect position, Texture image) { }
        public static void Label(Rect position, GUIContent content) { }
        public static void Label(Rect position, string text, GUIStyle style) { }
        public static void Label(Rect position, Texture image, GUIStyle style) { }
        public static void Label(Rect position, GUIContent content, GUIStyle style) { }
        public static Rect Window(int id, Rect clientRect, WindowFunction func, string text)
            => throw new System.NotImplementedException("Stub");
        public static Rect Window(int id, Rect clientRect, WindowFunction func, Texture image)
            => throw new System.NotImplementedException("Stub");
        public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent content)
            => throw new System.NotImplementedException("Stub");
        public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style)
            => throw new System.NotImplementedException("Stub");
        public static Rect Window(int id, Rect clientRect, WindowFunction func, Texture image, GUIStyle style)
            => throw new System.NotImplementedException("Stub");
        public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style)
            => throw new System.NotImplementedException("Stub");
    }

    public class Event
    {
        public static Event current { get; set; }
        public Vector2 delta { get; set; }
        public Vector2 mousePosition { get; set; }
        public EventType type { get; set; }
        public void Use() { }
    }

    public class GUISkin : ScriptableObject
    {
        public GUIStyle box { get; set; }
        public GUIStyle button { get; set; }
        public GUIStyle label { get; set; }
        public GUIStyle window { get; set; }
    }

    public class GUILayout
    {
        public static void BeginHorizontal(GUILayoutOption[] options) { }
        public static void BeginHorizontal(GUIStyle style, GUILayoutOption[] options) { }
        public static void BeginHorizontal(string text, GUIStyle style, GUILayoutOption[] options) { }
        public static void BeginHorizontal(Texture image, GUIStyle style, GUILayoutOption[] options) { }
        public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style)
            => throw new System.NotImplementedException("Stub");
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static void BeginVertical(GUILayoutOption[] options) { }
        public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }
        public static void BeginVertical(string text, GUIStyle style, GUILayoutOption[] options) { }
        public static void BeginVertical(Texture image, GUIStyle style, GUILayoutOption[] options) { }
        public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }
        public static bool Button(Texture image, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Button(string text, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Button(GUIContent content, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Button(Texture image, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Button(string text, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Button(GUIContent content, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static void EndHorizontal() { }
        public static void EndScrollView() { }
        public static void EndVertical() { }
        public static GUILayoutOption ExpandWidth(bool expand)
            => throw new System.NotImplementedException("Stub");
        public static void FlexibleSpace() { }
        public static GUILayoutOption Height(float height)
            => throw new System.NotImplementedException("Stub");
        public static void Label(Texture image, GUILayoutOption[] options) { }
        public static void Label(string text, GUILayoutOption[] options) { }
        public static void Label(GUIContent content, GUILayoutOption[] options) { }
        public static void Label(Texture image, GUIStyle style, GUILayoutOption[] options) { }
        public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }
        public static void Label(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }
        public static string TextField(string text, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static string TextField(string text, int maxLength, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static string TextField(string text, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static string TextField(string text, int maxLength, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Toggle(bool value, Texture image, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Toggle(bool value, string text, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Toggle(bool value, GUIContent content, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Toggle(bool value, Texture image, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static bool Toggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options)
            => throw new System.NotImplementedException("Stub");
        public static GUILayoutOption Width(float width)
            => throw new System.NotImplementedException("Stub");
    }

    public class GUIStyle
    {
        public static GUIStyle none { get; }
        public Vector2 CalcSize(GUIContent content)
            => throw new System.NotImplementedException("Stub");
    }

    public class GUIContent
    {
        public string text { get; set; }
    }

    public class GUILayoutUtility
    {
        public static Rect GetLastRect()
            => throw new System.NotImplementedException("Stub");
    }

    public class GUILayoutOption
    {
    }

    public enum EventType
    {
        MouseDown,
        MouseDrag,
        MouseUp,
        Repaint
    }

}
