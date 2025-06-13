using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements;
public class LabelElement(string name, Rect rect, GUIContent content, GUIStyle style) : ContentElementBase(name, rect, content, style) {
 protected override void InternalOnGUI() {
  GUI.Label(this.Rect, this.Content, this.Style);
 }
}
