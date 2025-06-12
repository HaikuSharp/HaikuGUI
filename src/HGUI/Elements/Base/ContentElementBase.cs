using UnityEngine;
namespace HGUI.Elements.Base;
public abstract class ContentElementBase(string name, Rect rect, GUIContent content, GUIStyle style) : StyledElementBase(name, rect, style) {
 public GUIContent Content {
  get {
   return content;
  }
 }
}
