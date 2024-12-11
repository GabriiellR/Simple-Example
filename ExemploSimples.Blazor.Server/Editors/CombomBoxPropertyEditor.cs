using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;

namespace MinasDireto.Module.Blazor.Editors
{
    [PropertyEditor(typeof(string), "CombomBoxPropertyEditor", false)]
    public class CombomBoxPropertyEditor : BlazorPropertyEditorBase, IComplexViewItem
    {

        private IObjectSpace myObjectSpace;
        private XafApplication myXafApplication;
        public IReadOnlyDictionary<string, object> Attributes { get; }

        public CombomBoxPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }

        public void Setup(IObjectSpace objectSpace, XafApplication application)
        {
            myObjectSpace = objectSpace;
            myXafApplication = application;
        }

        protected override IComponentAdapter CreateComponentAdapter() => new InputAdapter(new InputModel());

    }
}
