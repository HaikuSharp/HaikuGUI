using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Scripting;
public class ScriptableElement(string name, Rect rect, GUIStyle style) : StyledElementBase(name, rect, style) {
 public delegate void GuiHandler(Rect rect, GUIStyle style);
 public event GuiHandler OnGUIRun;
 protected override void InternalOnGUI() {
  OnGUIRun?.Invoke(this.Rect, this.Style);
 }
}
