// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using System;
using Rewired;
using Rewired.Utils.Classes;
using System.Collections.Generic;

public abstract class Element
{
    public ControllerElementIdentifier elementIdentifier
        => throw new System.NotImplementedException("Stub");
}

public class ControllerHelper : CodeHelper
{
    public IList<Joystick> Joysticks
        => throw new System.NotImplementedException("Stub");
    public Keyboard Keyboard
        => throw new System.NotImplementedException("Stub");
    public Mouse Mouse
        => throw new System.NotImplementedException("Stub");
}

public class Button : Element
{
}

namespace Rewired
{
    public static class ReInput
    {
        public static ControllerHelper controllers
            => throw new System.NotImplementedException("Stub");
    }

    public abstract class Controller
    {
        public int buttonCount
            => throw new System.NotImplementedException("Stub");
        public IList<Button> Buttons
            => throw new System.NotImplementedException("Stub");
        public string name { get; private set; }
        public ControllerType type
            => throw new System.NotImplementedException("Stub");
        public virtual bool GetButton(int index)
            => throw new System.NotImplementedException("Stub");
        public virtual bool GetButtonDown(int index)
            => throw new System.NotImplementedException("Stub");
        public int GetButtonIndexById(int elementIdentifierId)
            => throw new System.NotImplementedException("Stub");
        public virtual Element GetElementById(int elementIdentifierId)
            => throw new System.NotImplementedException("Stub");
    }

    public abstract class ControllerWithMap : Controller
    {
    }

    public abstract class ControllerWithAxes : ControllerWithMap
    {
    }

    public class ControllerElementIdentifier
    {
        public int id
            => throw new System.NotImplementedException("Stub");
        public string name { get; private set; }
    }

    public class Keyboard : ControllerWithMap
    {
    }

    public enum ControllerType
    {
        Mouse
    }

    public class Joystick : ControllerWithAxes
    {
    }

    public class Mouse : ControllerWithAxes
    {
    }

}
namespace Rewired.Utils.Classes
{
    public abstract class CodeHelper
    {
    }

}
