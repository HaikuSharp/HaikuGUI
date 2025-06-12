using HGUI.Abstraction;
using System.Collections.Generic;
namespace HGUI.Reactive;
public class ReactiveProperty<T>(T defaultValue) : IReactiveProperty<T> {
 public T Value {
  get;
  set {
   if(EqualityComparer<T>.Default.Equals(value, field)) {
    value = field;
    OnValueChanged?.Invoke(value);
   }
  }
 } = defaultValue;
 public event ValueChangeHandler<T> OnValueChanged;
}
