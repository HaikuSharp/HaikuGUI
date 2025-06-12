using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Scripting;
public class ScriptableElement(string name, Rect rect, ScriptableElement.GuiHandler gui, GUIStyle style) : StyledElementBase(name, rect, style) {
 public delegate void GuiHandler(Rect rect, GUIStyle style);
 protected override void InternalOnGUI() {
  gui?.Invoke(this.Rect, this.Style);
 }
}
