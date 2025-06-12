using UnityEngine;
namespace HGUI.Elements.Containers;
public class ElementGroup(string name, Rect rect, GUIContent header, ElementContainer.EElementOrientation orientation, GUIStyle style) : ElementContainer(name, rect, orientation, style) {
 public GUIContent Header {
  get {
   return header;
  }
 }
 protected override void InternalOnGUI() {
  GUI.BeginGroup(this.Rect, header, this.Style);
  base.InternalOnGUI();
  GUI.EndGroup();
 }
}
