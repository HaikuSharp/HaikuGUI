using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Reactive;
public class ButtonElement(string name, Rect rect, GUIContent content, GUIStyle style) : ContentElementBase(name, rect, content, style) {
 public delegate void ButtonClickHadnler();
 public event ButtonClickHadnler OnClick;
 protected override void InternalOnGUI() {
  if(GUI.Button(this.Rect, this.Content, this.Style)) {
   OnClick?.Invoke();
  }
 }
}
