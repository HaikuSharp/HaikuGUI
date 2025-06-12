using HGUI.Abstraction;
using System;
namespace HGUI.Exceptions;
public class ElementNotFoundException(string elementName, string containerName) : Exception($"Element {elementName} not found in {containerName}.") {
 public static void ThrowIfNotContains(IElement element, IElementContainer container) {
  if(!container.Contains(element)) {
   Throw(element, container);
  }
 }
 public static void ThrowIfNotContains(string name, IElementContainer container) {
  if(!container.Contains(name)) {
   Throw(name, container);
  }
 }
 public static void Throw(IElement element, IElementContainer container) {
  Throw(element.Name, container);
 }
 public static void Throw(string name, IElementContainer container) {
  throw new ElementNotFoundException(name, container.Name);
 }
}