public abstract class Controller
{
	public virtual Element GetElementById(int elementIdentifierId) => throw null;

	public int GetButtonIndexById(int elementIdentifierId) => throw null;

	public virtual bool GetButtonDown(int index) => throw null;

	public virtual bool GetButton(int index) => throw null;

	public abstract class Element
	{
	}
}
