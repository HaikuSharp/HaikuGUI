using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Layout;
public class LayoutSpaceElement(string name, float space) : ElementBase(name) {
 protected override void InternalOnGUI() {
  GUILayout.Space(space);
 }
}
