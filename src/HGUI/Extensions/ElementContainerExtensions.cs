using HGUI.Abstraction;
using HGUI.Exceptions;
namespace HGUI.Extensions;
public static class ElementContainerExtensions {
 public static TElement Find<TElement>(this IElementContainer container, string name) where TElement : class, IElement {
  var element = container.Find(name);
  if(element is not TElement result) {
   ElementNotFoundException.Throw(element, container);
   return null;
  }
  return result;
 }
 public static bool TryFind<TElement>(this IElementContainer container, string name, out TElement element) where TElement : class, IElement {
  if(container.TryFind(name, out var findElement) && findElement is TElement result) {
   element = result;
   return true;
  }
  element = null;
  return false;
 }
}
