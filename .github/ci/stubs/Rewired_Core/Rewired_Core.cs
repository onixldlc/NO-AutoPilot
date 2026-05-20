using System.Collections.Generic;

namespace Rewired
{
	public abstract class Controller
	{
		public string name;
		public ControllerType type;
		public int buttonCount;
		public Button[] Buttons;

		public virtual Element GetElementById(int elementIdentifierId) => throw null;

		public int GetButtonIndexById(int elementIdentifierId) => throw null;

		public virtual bool GetButtonDown(int index) => throw null;

		public virtual bool GetButton(int index) => throw null;

		public abstract class Element
		{
		}

		public class Button : Element
		{
			public ElementIdentifier elementIdentifier;
		}
	}

	public class ElementIdentifier
	{
		public string name;
		public int id;
	}

	public enum ControllerType
	{
		Keyboard,
		Mouse,
		Joystick,
		Custom
	}

	public class Joystick : Controller
	{
	}

	public class Mouse : Controller
	{
	}

	public class Keyboard : Controller
	{
	}

	public static class ReInput
	{
		public static ControllerHelper controllers;
	}

	public class ControllerHelper
	{
		public IEnumerable<Joystick> Joysticks;
		public Mouse Mouse;
		public Keyboard Keyboard;
	}
}
