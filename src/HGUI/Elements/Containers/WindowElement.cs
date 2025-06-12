using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Containers;
public class WindowElement(string name, Rect rect, int id, GUIContent header, ElementContainerBase.EElementOrientation orintation, GUIStyle style) : ElementContainerBase(name, rect, orintation, style) {
 public GUIContent Header {
  get {
   return header;
  }
 }
 public bool IsDraggable { get; set; } = true;
 public Rect DragRect { get; set; } = new(Vector2.zero, rect.size);
 protected override void InternalOnGUI() {
  this.Rect = GUI.Window(id, this.Rect, this.WindowFunction, header, this.Style);
 }
 private void WindowFunction(int id) {
  base.InternalOnGUI();
  if(this.IsDraggable) {
   GUI.DragWindow(this.DragRect);
  }
 }
}
