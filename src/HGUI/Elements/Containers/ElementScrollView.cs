using HGUI.Elements.Base;
using System;
using UnityEngine;
namespace HGUI.Elements.Containers;
public class ElementScrollView(string name, Rect rect, Rect viewPort, ElementContainerBase.EElementOrientation orientation, ElementScrollView.EBarFlags showBarsFlags, GUIStyle style) : ElementContainerBase(name, rect, orientation, style) {
 public Vector2 Scroll { get; set; }
 protected override void InternalOnGUI() {
  this.Scroll = GUI.BeginScrollView(this.Rect, this.Scroll, viewPort, (showBarsFlags & EBarFlags.HorizontalBar) == EBarFlags.HorizontalBar, (showBarsFlags & EBarFlags.VerticalBar) == EBarFlags.VerticalBar, this.Style, this.Style);
  base.InternalOnGUI();
  GUI.EndScrollView();
 }
 [Flags]
 public enum EBarFlags {
  None = 0,
  HorizontalBar = 1,
  VerticalBar = 2,
 }
}
