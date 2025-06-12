using UnityEngine;
namespace HGUI.Abstraction;
public interface IStyledElement : IElement {
 GUIStyle Style { get; }
}
