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
    public class RegistroPrestacionEmpleado : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public RegistroPrestacionEmpleado(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        CatalogoPrestacion catalogoPrestacion;
        Empleado empleado;
        DateTime fecha;
        bool comprobado;
        double monto;



        [RuleRequiredField]
        [Association("CatalogoPrestacion-RegistroPrestacionEmpleados")]
        public CatalogoPrestacion CatalogoPrestacion
        {
            get => catalogoPrestacion;
            set => SetPropertyValue(nameof(CatalogoPrestacion), ref catalogoPrestacion, value);
        }


        [RuleRequiredField]
        [Association("Empleado-RegistroPrestacionEmpleados")]
        public Empleado Empleado
        {
            get => empleado;
            set => SetPropertyValue(nameof(Empleado), ref empleado, value);
        }


        public double Monto
        {
            get => monto;
            set => SetPropertyValue(nameof(Monto), ref monto, value);
        }


        public bool Comprobado
        {
            get => comprobado;
            set => SetPropertyValue(nameof(Comprobado), ref comprobado, value);
        }

        
        public DateTime Fecha
        {
            get => fecha;
            set => SetPropertyValue(nameof(Fecha), ref fecha, value);
        }

    }
}