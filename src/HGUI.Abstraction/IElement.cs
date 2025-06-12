namespace HGUI.Abstraction;
public interface IElement {
 string Name { get; }
 bool IsActive { get; set; }
 void OnGUI();
}
