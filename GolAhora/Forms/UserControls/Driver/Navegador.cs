using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GolAhora.Forms.UserControls.Driver;

public class Browser
{
    private static Browser _instance;
    public static Browser Instance => _instance ?? (_instance = new Browser());

    private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();

    private Browser() { }

    public T GetView<T>() where T : UserControl, new()
    {
        Type tipo = typeof(T);

        if (!_views.ContainsKey(tipo) || _views[tipo].IsDisposed)
            _views[tipo] = new T();

        return (T)_views[tipo];
    }
}