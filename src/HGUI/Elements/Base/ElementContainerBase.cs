using HGUI.Abstraction;
using HGUI.Exceptions;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace HGUI.Elements.Base;
public abstract class ElementContainerBase(string name, Rect rect, ElementContainerBase.EElementOrientation orintation, GUIStyle style) : StyledElementBase(name, rect, style), IElementContainer {
 private readonly List<IElement> m_Elements = [];
 public IEnumerable<IElement> Elements {
  get {
   return this.m_Elements;
  }
 }
 public bool Contains(IElement element) {
  return this.m_Elements.Contains(element);
 }
 public bool Contains(string name) {
  return this.m_Elements.Any(e => e.Name == name);
 }
 public void Add(IElement element) {
  ElementAlreadyAddedException.ThrowIfContains(element, this);
  this.m_Elements.Add(element);
 }
 public void Remove(IElement element) {
  if(!this.m_Elements.Remove(element)) {
   ElementNotFoundException.Throw(element, this);
  }
 }
 public void Remove(string name) {
  if(this.m_Elements.RemoveAll(e => e.Name == name) is 0) {
   ElementNotFoundException.Throw(name, this);
  }
 }
 public IElement Find(string name) {
  var element = this.InternalFind(name);
  if(element is null) {
   ElementNotFoundException.Throw(name, this);
  }
  return element;
 }
 public bool TryFind(string name, out IElement element) {
  element = this.InternalFind(name);
  return element is not null;
 }
 protected override void InternalOnGUI() {
  switch(orintation) {
   case EElementOrientation.None:
    this.OnGUIElements();
    break;
   case EElementOrientation.Horizontal:
    this.Horizontal();
    break;
   case EElementOrientation.Vertical:
    this.Vertical();
    break;
  }
 }
 private void Horizontal() {
  GUILayout.BeginHorizontal();
  this.OnGUIElements();
  GUILayout.EndHorizontal();
 }
 private void Vertical() {
  GUILayout.BeginVertical();
  this.OnGUIElements();
  GUILayout.EndVertical();
 }
 private void OnGUIElements() {
  this.m_Elements.ForEach(e => e.OnGUI());
 }
 private IElement InternalFind(string name) {
  return this.m_Elements.FirstOrDefault(e => e.Name == name);
 }
 public void Clear() {
  this.m_Elements.Clear();
 }
 public enum EElementOrientation {
  None,
  Horizontal,
  Vertical
 }
}
