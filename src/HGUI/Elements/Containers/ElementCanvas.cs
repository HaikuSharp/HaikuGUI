using HGUI.Elements.Base;
using UnityEngine;
namespace HGUI.Elements.Containers;
public class ElementCanvas(string name, Rect rect, ElementContainerBase.EElementOrientation orintation, GUIStyle style) : ElementContainerBase(name, rect, orintation, style) {
 public bool EnabledScaling { get; set; }
 public Vector2 ResolutionReference { get; set; } = new(1920.0f, 1080.0f);
 public Vector2 ScaleFactor { get; set; } = Vector2.one;
 protected override void InternalOnGUI() {
  if(this.EnabledScaling) {
   var resolutionReference = this.ResolutionReference;
   var scaleFactor = this.ScaleFactor;

   float screenWidth = Screen.width;
   float screenHeight = Screen.height;
   var resolutionWidth = resolutionReference.x;
   var resolutionHeight = resolutionReference.y;

   var scaleFactorWidth = scaleFactor.x;
   var scaleFactorHeight = scaleFactor.y;

   if(screenWidth != resolutionWidth) {
    scaleFactorWidth *= Screen.width / resolutionReference.x;
   }
   if(screenHeight != resolutionHeight) {
    scaleFactorHeight *= Screen.height / resolutionReference.y;
   }

   GUIUtility.ScaleAroundPivot(new Vector2(scaleFactorWidth, scaleFactorHeight), Vector2.zero);
  }
  base.InternalOnGUI();
 }
}
