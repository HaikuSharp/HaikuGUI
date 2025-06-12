using HGUI.Abstraction;
using HGUI.Elements.Layout;
using UnityEngine;
namespace HGUI.Extensions;
public static class ElementExtensions {
 public static LayoutElementWrap<TElement> AsLayout<TElement>(this TElement element, params GUILayoutOption[] options) where TElement : IStyledElement, IPositionElement {
  return new LayoutElementWrap<TElement>(element, options);
 }
}
