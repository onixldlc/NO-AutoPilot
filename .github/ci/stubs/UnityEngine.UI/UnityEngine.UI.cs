using UnityEngine;

namespace UnityEngine.UI
{
	public class Graphic : MonoBehaviour
	{
		public Color color;
		public bool enabled;
	}

	public class MaskableGraphic : Graphic
	{
	}

	public class Text : MaskableGraphic
	{
		public string text;
		public int fontSize;
		public FontStyle fontStyle;
		public bool supportRichText;
		public bool resizeTextForBestFit;
		public TextAnchor alignment;
		public HorizontalWrapMode horizontalOverflow;
		public VerticalWrapMode verticalOverflow;
		public bool richText;
	}

	public class Image : MaskableGraphic
	{
	}

	public class RawImage : MaskableGraphic
	{
	}

	public class Mask : MonoBehaviour
	{
		public bool enabled;
	}

	public class RectMask2D : MonoBehaviour
	{
		public bool enabled;
	}
}
