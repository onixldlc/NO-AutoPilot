// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace JetBrains.Annotations
{
    public class UsedImplicitlyAttribute : Attribute
    {
    }

}
namespace UnityEngine
{
    public static class Random
    {
        public static float Range(float minInclusive, float maxInclusive)
            => throw new System.NotImplementedException("Stub");
        public static int Range(int minInclusive, int maxExclusive)
            => throw new System.NotImplementedException("Stub");
    }

    public class Object
    {
        public string name { get; set; }
        public static void Destroy(Object obj, float t) { }
        public static void Destroy(Object obj) { }
        public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
            => throw new System.NotImplementedException("Stub");
        public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
            => throw new System.NotImplementedException("Stub");
        public static Object Instantiate(Object original)
            => throw new System.NotImplementedException("Stub");
        public static Object Instantiate(Object original, Scene scene)
            => throw new System.NotImplementedException("Stub");
        public static T Instantiate<T>(T original, InstantiateParameters parameters)
            => throw new System.NotImplementedException("Stub");
        public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters)
            => throw new System.NotImplementedException("Stub");
        public static Object Instantiate(Object original, Transform parent)
            => throw new System.NotImplementedException("Stub");
        public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
            => throw new System.NotImplementedException("Stub");
        public static T Instantiate<T>(T original)
            => throw new System.NotImplementedException("Stub");
        public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation)
            => throw new System.NotImplementedException("Stub");
        public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent)
            => throw new System.NotImplementedException("Stub");
        public static T Instantiate<T>(T original, Transform parent)
            => throw new System.NotImplementedException("Stub");
        public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays)
            => throw new System.NotImplementedException("Stub");
    }

    public class Time
    {
        public static float deltaTime { get; }
        public static float fixedDeltaTime { get; set; }
        public static float realtimeSinceStartup { get; }
        public static float time { get; }
    }

    public class Screen
    {
        public static int height { get; }
        public static int width { get; }
    }

    public class RectOffset
    {
    }

    public class ColorUtility
    {
        public static string ToHtmlStringRGBA(Color color)
            => throw new System.NotImplementedException("Stub");
        public static bool TryParseHtmlString(string htmlString, out Color color)
            => throw new System.NotImplementedException("Stub");
    }

    public struct Vector2
    {
        public float x;
        public float y;
        public static Vector2 one { get; }
        public float sqrMagnitude { get; }
        public static Vector2 zero { get; }
        public static float Distance(Vector2 a, Vector2 b)
            => throw new System.NotImplementedException("Stub");
    }

    public struct Color
    {
        public float a;
        public float b;
        public float g;
        public float r;
        public static Color cyan { get; }
        public static Color gray { get; }
        public static Color green { get; }
        public static Color red { get; }
        public static Color white { get; }
        public static Color yellow { get; }
    }

    public struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public float magnitude { get; }
        public Vector3 normalized { get; }
        public static Vector3 one { get; }
        public float sqrMagnitude { get; }
        public static Vector3 up { get; }
        public static Vector3 zero { get; }
        public static float Angle(Vector3 from, Vector3 to)
            => throw new System.NotImplementedException("Stub");
        public static float Distance(Vector3 a, Vector3 b)
            => throw new System.NotImplementedException("Stub");
        public static float Dot(Vector3 lhs, Vector3 rhs)
            => throw new System.NotImplementedException("Stub");
        public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
            => throw new System.NotImplementedException("Stub");
    }

    public class GameObject : Object
    {
        public bool activeSelf { get; }
        public Transform transform { get; }
        public T GetComponent<T>()
            => throw new System.NotImplementedException("Stub");
        public Component GetComponent(Type type)
            => throw new System.NotImplementedException("Stub");
        public Component GetComponent(string type)
            => throw new System.NotImplementedException("Stub");
        public Component GetComponentInParent(Type type, bool includeInactive)
            => throw new System.NotImplementedException("Stub");
        public Component GetComponentInParent(Type type)
            => throw new System.NotImplementedException("Stub");
        public T GetComponentInParent<T>()
            => throw new System.NotImplementedException("Stub");
        public T GetComponentInParent<T>(bool includeInactive)
            => throw new System.NotImplementedException("Stub");
        public Component[] GetComponentsInChildren(Type type)
            => throw new System.NotImplementedException("Stub");
        public Component[] GetComponentsInChildren(Type type, bool includeInactive)
            => throw new System.NotImplementedException("Stub");
        public T[] GetComponentsInChildren<T>(bool includeInactive)
            => throw new System.NotImplementedException("Stub");
        public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
        public T[] GetComponentsInChildren<T>()
            => throw new System.NotImplementedException("Stub");
        public void GetComponentsInChildren<T>(List<T> results) { }
        public void SetActive(bool value) { }
        public bool TryGetComponent<T>(out T component)
            => throw new System.NotImplementedException("Stub");
        public bool TryGetComponent(Type type, out Component component)
            => throw new System.NotImplementedException("Stub");
    }

    public struct Mathf
    {
        public static float Deg2Rad;
        public static float Rad2Deg;
        public static float Abs(float f)
            => throw new System.NotImplementedException("Stub");
        public static int Abs(int value)
            => throw new System.NotImplementedException("Stub");
        public static float Acos(float f)
            => throw new System.NotImplementedException("Stub");
        public static bool Approximately(float a, float b)
            => throw new System.NotImplementedException("Stub");
        public static float Asin(float f)
            => throw new System.NotImplementedException("Stub");
        public static float Atan(float f)
            => throw new System.NotImplementedException("Stub");
        public static float Atan2(float y, float x)
            => throw new System.NotImplementedException("Stub");
        public static float Clamp(float value, float min, float max)
            => throw new System.NotImplementedException("Stub");
        public static int Clamp(int value, int min, int max)
            => throw new System.NotImplementedException("Stub");
        public static float Clamp01(float value)
            => throw new System.NotImplementedException("Stub");
        public static float Cos(float f)
            => throw new System.NotImplementedException("Stub");
        public static float DeltaAngle(float current, float target)
            => throw new System.NotImplementedException("Stub");
        public static float Exp(float power)
            => throw new System.NotImplementedException("Stub");
        public static float Lerp(float a, float b, float t)
            => throw new System.NotImplementedException("Stub");
        public static float Max(float a, float b)
            => throw new System.NotImplementedException("Stub");
        public static float Max(float[] values)
            => throw new System.NotImplementedException("Stub");
        public static int Max(int a, int b)
            => throw new System.NotImplementedException("Stub");
        public static int Max(int[] values)
            => throw new System.NotImplementedException("Stub");
        public static float Min(float a, float b)
            => throw new System.NotImplementedException("Stub");
        public static float Min(float[] values)
            => throw new System.NotImplementedException("Stub");
        public static int Min(int a, int b)
            => throw new System.NotImplementedException("Stub");
        public static int Min(int[] values)
            => throw new System.NotImplementedException("Stub");
        public static float PerlinNoise(float x, float y)
            => throw new System.NotImplementedException("Stub");
        public static float Pow(float f, float p)
            => throw new System.NotImplementedException("Stub");
        public static float Repeat(float t, float length)
            => throw new System.NotImplementedException("Stub");
        public static float Sqrt(float f)
            => throw new System.NotImplementedException("Stub");
    }

    public struct Rect
    {
        public float height { get; set; }
        public float width { get; set; }
        public float x { get; set; }
        public float xMax { get; set; }
        public float y { get; set; }
        public float yMax { get; set; }
        public bool Contains(Vector2 point)
            => throw new System.NotImplementedException("Stub");
        public bool Contains(Vector3 point)
            => throw new System.NotImplementedException("Stub");
        public bool Contains(Vector3 point, bool allowInverse)
            => throw new System.NotImplementedException("Stub");
    }

    public struct Quaternion
    {
        public Vector3 eulerAngles { get; set; }
        public static Quaternion identity { get; }
        public static Quaternion LookRotation(Vector3 forward, Vector3 upwards)
            => throw new System.NotImplementedException("Stub");
        public static Quaternion LookRotation(Vector3 forward)
            => throw new System.NotImplementedException("Stub");
    }

    public class Component : Object
    {
        public GameObject gameObject { get; }
        public Transform transform { get; }
        public Component GetComponent(Type type)
            => throw new System.NotImplementedException("Stub");
        public T GetComponent<T>()
            => throw new System.NotImplementedException("Stub");
        public Component GetComponent(string type)
            => throw new System.NotImplementedException("Stub");
        public Component GetComponentInChildren(Type t, bool includeInactive)
            => throw new System.NotImplementedException("Stub");
        public Component GetComponentInChildren(Type t)
            => throw new System.NotImplementedException("Stub");
        public T GetComponentInChildren<T>(bool includeInactive)
            => throw new System.NotImplementedException("Stub");
        public T GetComponentInChildren<T>()
            => throw new System.NotImplementedException("Stub");
    }

    public struct InstantiateParameters
    {
    }

    public class Texture : Object
    {
    }

    public class ScriptableObject : Object
    {
    }

    public struct Ray
    {
    }

    public class Transform : Component
    {
        public Vector3 eulerAngles { get; set; }
        public Vector3 forward { get; set; }
        public Vector3 localEulerAngles { get; set; }
        public Vector3 localPosition { get; set; }
        public Quaternion localRotation { get; set; }
        public Vector3 localScale { get; set; }
        public Transform parent { get; set; }
        public Vector3 position { get; set; }
        public Transform root { get; }
        public Vector3 up { get; set; }
        public Transform Find(string n)
            => throw new System.NotImplementedException("Stub");
        public Vector3 InverseTransformDirection(Vector3 direction)
            => throw new System.NotImplementedException("Stub");
        public Vector3 InverseTransformDirection(float x, float y, float z)
            => throw new System.NotImplementedException("Stub");
        public Vector3 InverseTransformPoint(Vector3 position)
            => throw new System.NotImplementedException("Stub");
        public Vector3 InverseTransformPoint(float x, float y, float z)
            => throw new System.NotImplementedException("Stub");
        public void SetParent(Transform p) { }
        public void SetParent(Transform parent, bool worldPositionStays) { }
    }

    public enum KeyCode
    {
        Backslash,
        Delete,
        DownArrow,
        End,
        Equals,
        F8,
        Home,
        LeftArrow,
        LeftBracket,
        LeftControl,
        LeftShift,
        None,
        PageDown,
        PageUp,
        Quote,
        RightArrow,
        RightBracket,
        RightShift,
        Semicolon,
        Slash,
        UpArrow
    }

    public class Behaviour : Component
    {
        public bool enabled { get; set; }
    }

    public class RectTransform : Transform
    {
        public Vector2 anchoredPosition { get; set; }
        public Vector2 anchorMax { get; set; }
        public Vector2 anchorMin { get; set; }
        public Vector2 pivot { get; set; }
        public Vector2 sizeDelta { get; set; }
        public void GetWorldCorners(Vector3[] fourCornersArray) { }
    }

    public class MonoBehaviour : Behaviour
    {
    }

}
namespace UnityEngine.Events
{
    public class UnityAction : MulticastDelegate
    {
    }

}
namespace UnityEngine.SceneManagement
{
    public class SceneManager
    {
    }

    public struct Scene
    {
        public string name { get; set; }
    }

}
