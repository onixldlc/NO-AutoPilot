public abstract class Controller
{
	public virtual Element GetElementById(int elementIdentifierId);

	public int GetButtonIndexById(int elementIdentifierId);

	public virtual bool GetButtonDown(int index);

	public virtual bool GetButton(int index);

	public abstract class Element
	{
	}
}
