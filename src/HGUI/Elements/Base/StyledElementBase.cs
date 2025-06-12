using HGUI.Abstraction;
using UnityEngine;
namespace HGUI.Elements.Base;
public abstract class StyledElementBase(string name, Rect rect, GUIStyle style) : ElementBase(name), IStyledElement, IPositionElement {
 public Rect Rect { get; set; } = rect;
 public GUIStyle Style {
  get {
   return style;
  }
 }
}
