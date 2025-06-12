using HGUI.Abstraction;
using HGUI.Elements.Base;
using HGUI.Reactive;
using UnityEngine;
namespace HGUI.Elements.Reactive;
public class ToggleElement(string name, Rect rect, GUIContent content, bool value, GUIStyle style) : ContentElementBase(name, rect, content, style) {
 public IReactiveProperty<bool> ReactiveProperty { get; } = new ReactiveProperty<bool>(value);
 protected override void InternalOnGUI() {
  var property = this.ReactiveProperty;
  property.Value = GUI.Toggle(this.Rect, property.Value, this.Content, this.Style);
 }
}
