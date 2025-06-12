namespace HGUI.Abstraction;
public delegate void ValueChangeHandler<T>(T value);
public interface IReactiveProperty<T> {
 event ValueChangeHandler<T> OnValueChanged;
 T Value { get; set; }
}
