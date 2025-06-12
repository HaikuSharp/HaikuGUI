using HGUI.Abstraction;
using HGUI.Elements.Base;
using HGUI.Reactive;
using UnityEngine;
namespace HGUI.Elements.Reactive;
public class TextFieldElement(string name, Rect rect, string value, int maxLength, GUIStyle style) : StyledElementBase(name, rect, style) {
 public IReactiveProperty<string> ReactiveProperty { get; } = new ReactiveProperty<string>(value);
 protected override void InternalOnGUI() {
  var property = this.ReactiveProperty;
  property.Value = GUI.TextField(this.Rect, property.Value, maxLength, this.Style);
 }
}
