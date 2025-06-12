using HGUI.Abstraction;
using HGUI.Elements.Base;
using HGUI.Reactive;
using UnityEngine;
namespace HGUI.Elements.Reactive;
public class SliderElement(string name, Rect rect, float value, float size, float leftValue, float rigthValue, SliderElement.ESliderType type, int id, GUIStyle sliderStyle, GUIStyle thumbStyle, GUIStyle thumbExtentStyle) : StyledElementBase(name, rect, sliderStyle) {
 public IReactiveProperty<float> ReactiveProperty { get; } = new ReactiveProperty<float>(value);
 public GUIStyle ThumbStyle {
  get {
   return thumbStyle;
  }
 }
 public GUIStyle ThumbExtentStyle {
  get {
   return thumbExtentStyle;
  }
 }
 protected override void InternalOnGUI() {
  var property = this.ReactiveProperty;
  property.Value = GUI.Slider(this.Rect, property.Value, size, leftValue, rigthValue, this.Style, thumbStyle, type == ESliderType.Horizontal, id, this.ThumbExtentStyle);
 }
 public enum ESliderType {
  Horizontal,
  Vertical
 }
}
