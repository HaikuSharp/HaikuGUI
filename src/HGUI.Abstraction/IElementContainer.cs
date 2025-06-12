using System.Collections.Generic;
namespace HGUI.Abstraction;
public interface IElementContainer : IElement {
 IEnumerable<IElement> Elements { get; }
 bool Contains(IElement element);
 bool Contains(string name);
 void Add(IElement element);
 void Remove(IElement element);
 void Remove(string name);
 IElement Find(string name);
 bool TryFind(string name, out IElement element);
 void Clear();
}
