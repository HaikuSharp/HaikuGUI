using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Containers;
public class ElementGroup(string name, Rect rect, GUIContent header, ElementContainerBase.EElementOrientation orientation, GUIStyle style) : ElementContainerBase(name, rect, orientation, style) {
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
