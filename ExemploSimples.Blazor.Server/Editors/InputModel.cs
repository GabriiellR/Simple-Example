using DevExpress.ExpressApp.Blazor.Components.Models;
using Microsoft.AspNetCore.Components;

namespace MinasDireto.Module.Blazor.Editors
{
    public class InputModel : ComponentModelBase
    {
        public EventCallback<string> ValueChanged { get => GetPropertyValue<EventCallback<string>>(); set => SetPropertyValue(value); }

        public bool ReadOnly { get => GetPropertyValue<bool>(); set => SetPropertyValue(value); }

        public List<string> Data { get => GetPropertyValue<List<string>>(); set => SetPropertyValue(value); }

        public string Value { get => GetPropertyValue<string>(); set => SetPropertyValue(value); }
    }
}
