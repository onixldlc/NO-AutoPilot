// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using Rewired;
using Rewired.Utils.Classes;
using System.Collections.Generic;

public abstract class Element
{
    public ControllerElementIdentifier elementIdentifier { get; }
}

public class ControllerHelper : CodeHelper
{
    public IList<Joystick> Joysticks { get; }
    public Keyboard Keyboard { get; }
    public Mouse Mouse { get; }
}

public class Button : Element
{
}

namespace Rewired
{
    public static class ReInput
    {
        public static ControllerHelper controllers { get; }
    }

    public abstract class Controller
    {
        public int buttonCount { get; }
        public IList<Button> Buttons { get; }
        public string name { get; private set; }
        public ControllerType type { get; }
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
        public int id { get; }
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
