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
    //[DefaultProperty(nameof())]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Fecha : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Fecha(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string anio;
        EnumMes mes;

        public EnumMes Mes
        {
            get => mes;
            set => SetPropertyValue(nameof(Mes), ref mes, value);
        }

        
        [Size(4)]
        [XafDisplayName("Año")]
        public string Anio
        {
            get => anio;
            set => SetPropertyValue(nameof(Anio), ref anio, value);
        }

        [Association("Fecha-Archivo")]
        public XPCollection<Archivo> Archivo
        {
            get
            {
                return GetCollection<Archivo>(nameof(Archivo));
            }
        }
    }

    public enum EnumMes
    {
        Enero = 0,
        Febrero = 1,
        Marzo = 2,
        Abril = 3,
        Mayo = 4,
        Junio = 5,
        Julio = 6,
        Agosto = 7,
        Septiembre = 8,
        Octubre = 9,
        Noviembre = 10,
        Diciembre = 11
    }
}