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
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class CatalogoPrestacion : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CatalogoPrestacion(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        CatalogoDocumento catalogoDocumento;
        string numeral;
        string clausula;
        string nombre;


        [RuleRequiredField]
        [Size(150)]
        public string Nombre
        {
            get => nombre;
            set => SetPropertyValue(nameof(Nombre), ref nombre, value);
        }


        [Size(10)]
        public string Clausula
        {
            get => clausula;
            set => SetPropertyValue(nameof(Clausula), ref clausula, value);
        }


        [Size(10)]
        public string Numeral
        {
            get => numeral;
            set => SetPropertyValue(nameof(Numeral), ref numeral, value);
        }

        [RuleRequiredField]
        [Association("CatalogoDocumento-CatalogoPrestaciones")]
        public CatalogoDocumento CatalogoDocumento
        {
            get => catalogoDocumento;
            set => SetPropertyValue(nameof(CatalogoDocumento), ref catalogoDocumento, value);
        }


        [Association("CatalogoPrestacion-RegistroPrestacionEmpleados")]
        public XPCollection<RegistroPrestacionEmpleado> RegistroPrestacionEmpleados
        {
            get
            {
                return GetCollection<RegistroPrestacionEmpleado>(nameof(RegistroPrestacionEmpleados));
            }
        }

    }
}