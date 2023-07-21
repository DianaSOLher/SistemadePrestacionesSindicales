using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Prestaciones.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty(nameof(Nombre))]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Documento : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Documento(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _Nombre;
        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nombre
        {
            get => _Nombre;
            set => SetPropertyValue(nameof(Nombre), ref _Nombre, value);
        }

        private string _Descripcion;
        [RuleRequiredField]
        [Size(SizeAttribute.Unlimited)]
        public string Descripcion
        {
            get => _Descripcion;
            set => SetPropertyValue(nameof(Descripcion), ref _Descripcion, value);
        }

        private FileData _Archivo;
        [RuleRequiredField]
        public FileData Archivo
        {
            get => _Archivo;
            set => SetPropertyValue(nameof(Archivo), ref _Archivo, value);
        }

        [Association("Documento-Prestacion")]
        public XPCollection<Prestacion> Prestacion
        {
            get
            {
                return GetCollection<Prestacion>(nameof(Prestacion));
            }
        }

    }
}