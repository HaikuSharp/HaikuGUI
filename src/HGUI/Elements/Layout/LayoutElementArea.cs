using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Layout;
public class LayoutElementArea(string name, Rect rect, GUIContent header, ElementContainerBase.EElementOrientation orientation, GUIStyle style) : ElementContainerBase(name, rect, orientation, style) {
 public GUIContent Header {
  get {
   return header;
  }
 }
 protected override void InternalOnGUI() {
  GUILayout.BeginArea(this.Rect, header, this.Style);
  base.InternalOnGUI();
  GUILayout.EndArea();
 }
}