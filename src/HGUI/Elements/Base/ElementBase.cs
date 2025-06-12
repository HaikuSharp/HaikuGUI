using HGUI.Abstraction;
using System;
namespace HGUI.Elements.Base;
public abstract class ElementBase(string name) : IElement, IEquatable<IElement> {
 public string Name {
  get {
   return name;
  }
 }
 public bool IsActive { get; set; } = true;
 public bool Equals(IElement other) {
  return name == other.Name;
 }
 public override bool Equals(object obj) {
  return obj is IElement element && this.Equals(element);
 }
 public override int GetHashCode() {
  return name.GetHashCode();
 }
 public void OnGUI() {
  if(this.IsActive) {
   this.InternalOnGUI();
  }
 }
 protected abstract void InternalOnGUI();
 public override string ToString() {
  return name;
 }
}
