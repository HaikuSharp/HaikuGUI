using HGUI.Elements.Containers;
using UnityEngine;
namespace HGUI;
public abstract class HBehaviourBase : MonoBehaviour {
 private ElementCanvas m_Canvas;
 protected abstract void OnSetup(ElementCanvas canvas);
 private bool m_IsInitialized;
#pragma warning disable IDE0051
 private void OnGUI() {
  this.IntializeIfNeeded();
  this.m_Canvas.OnGUI();
 }
#pragma warning restore
 private void IntializeIfNeeded() {
  if(!this.m_IsInitialized) {
   this.m_IsInitialized = true;
   this.Intialize();
  }
 }
 private void Intialize() {
  var canvas = this.m_Canvas ??= new("root", new(0.0f, 0.0f, Screen.width, Screen.height), ElementContainer.EElementOrientation.None, GUIStyle.none);
  this.OnSetup(canvas);
 }
}
