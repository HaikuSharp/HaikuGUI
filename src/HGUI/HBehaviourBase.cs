using HGUI.Elements.Base;
using HGUI.Elements.Containers;
using UnityEngine;
namespace HGUI;
public abstract class HBehaviourBase : MonoBehaviour {
 private bool m_IsInitialized;
 private ElementCanvas m_Canvas;
 protected abstract void OnSetup(ElementCanvas canvas);
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
  this.OnSetup(this.m_Canvas ??= new("root", new(0.0f, 0.0f, Screen.width, Screen.height), ElementContainerBase.EElementOrientation.None, GUIStyle.none));
 }
}
