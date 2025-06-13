using HGUI.Abstraction;
using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Layout;
public class LayoutElementWrap<TInner>(TInner inner, params GUILayoutOption[] options) : ElementBase(inner.Name) where TInner : IStyledElement, IPositionElement {
 public TInner Inner {
  get {
   return inner;
  }
 }
 protected override void InternalOnGUI() {
  var layoutRect = this.GetLayoutInnerRect(inner);
  if(Event.current.type is EventType.Repaint) {
   inner.Rect = layoutRect;
  }
  inner.OnGUI();
 }
 protected virtual Rect GetLayoutInnerRect(TInner inner) {
  return GUILayoutUtility.GetRect(GUIContent.none, inner.Style, options);
 }
 public static explicit operator TInner(LayoutElementWrap<TInner> layoutElement) {
  return layoutElement.Inner;
 }
}
