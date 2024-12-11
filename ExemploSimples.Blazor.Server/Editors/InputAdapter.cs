using DevExpress.ExpressApp.Blazor.Components;
using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Utils;
using ExemploSimples.Blazor.Server.Editors;
using Microsoft.AspNetCore.Components;

namespace MinasDireto.Module.Blazor.Editors
{
    public class InputAdapter : ComponentAdapterBase
    {
        public InputModel myComnponentModel { get; }


        public InputAdapter(InputModel componentModel)
        {
            myComnponentModel = componentModel;
            BuscarSocios(myComnponentModel);
            myComnponentModel.ValueChanged = EventCallback.Factory.Create<string>(this, value => { myComnponentModel.Value = value; RaiseValueChanged(); });

        }
        public override IComponentModel ComponentModel { get; }
        public override object GetValue() => myComnponentModel.Value;
        public override void SetAllowEdit(bool allowEdit) => myComnponentModel.ReadOnly = !allowEdit;
        public override void SetAllowNull(bool allowNull) { }
        public override void SetDisplayFormat(string displayFormat) { }
        public override void SetEditMask(string editMask) { }
        public override void SetEditMaskType(EditMaskType editMaskType) { }
        public override void SetErrorIcon(ImageInfo errorIcon) { }
        public override void SetErrorMessage(string errorMessage) { }
        public override void SetIsPassword(bool isPassword) { }
        public override void SetMaxLength(int maxLength) { }
        public override void SetNullText(string nullText) { }
        public override void SetValue(object value) => myComnponentModel.Value = (string)value;
        protected override RenderFragment CreateComponent()
        {
            return ComponentModelObserver.Create(myComnponentModel, InputRenderer.Create(myComnponentModel));
        }
        private async Task BuscarSocios(InputModel model)
        {
            var data = new List<string>()
            {
                {"Gabriel" },
                {"Felipe" },
                {"Miguel" }
            };

            model.Data = data;
        }
    }
}
