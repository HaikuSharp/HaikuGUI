using HGUI.Abstraction;
using System;
namespace HGUI.Exceptions;
public class ElementAlreadyAddedException(string elementName, string containerName) : Exception($"Element {elementName} already contains in {containerName}.") {
 public static void ThrowIfContains(string name, IElementContainer container) {
  if(container.Contains(name)) {
   throw new ElementAlreadyAddedException(name, container.Name);
  }
 }
 public static void ThrowIfContains(IElement element, IElementContainer container) {
  if(container.Contains(element)) {
   throw new ElementAlreadyAddedException(element.Name, container.Name);
  }
 }
}
