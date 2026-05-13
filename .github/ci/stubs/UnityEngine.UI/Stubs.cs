// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityEngine.EventSystems
{
    public abstract class UIBehaviour : MonoBehaviour
    {
    }

}
namespace UnityEngine.UI
{
    public abstract class Graphic : UIBehaviour
    {
        public Color color { get; set; }
    }

    public abstract class MaskableGraphic : Graphic
    {
    }

    public class Mask : UIBehaviour
    {
    }

    public class RectMask2D : UIBehaviour
    {
    }

    public class Image : MaskableGraphic
    {
    }

    public class Text : MaskableGraphic
    {
        public TextAnchor alignment { get; set; }
        public int fontSize { get; set; }
        public FontStyle fontStyle { get; set; }
        public HorizontalWrapMode horizontalOverflow { get; set; }
        public bool resizeTextForBestFit { get; set; }
        public bool supportRichText { get; set; }
        public string text { get; set; }
        public VerticalWrapMode verticalOverflow { get; set; }
    }

}
