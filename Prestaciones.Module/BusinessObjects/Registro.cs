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
    public class Registro : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Registro(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        [RuleRequiredField]
        [Association("Prestacion-Registro")]
        public Prestacion Prestacion
        {
            get => fPrestacion;
            set => SetPropertyValue(nameof(Prestacion), ref fPrestacion, value);
        }
        Prestacion fPrestacion;

        private Empleado _Empleado;
        [RuleRequiredField]
        [Association("Empleado-Registro")]
        public Empleado Empleado
        {
            get => _Empleado;
            set => SetPropertyValue(nameof(Empleado), ref _Empleado, value);
        }

        private double _Monto;
        public double Monto
        {
            get => _Monto;
            set => SetPropertyValue(nameof(Monto), ref _Monto, value);
        }

        private bool _Comprobado;
        public bool Comprobado
        {
            get => _Comprobado;
            set => SetPropertyValue(nameof(Comprobado), ref _Comprobado, value);
        }

        private DateTime _Fecha;
        public DateTime Fecha
        {
            get => _Fecha;
            set => SetPropertyValue(nameof(Fecha), ref _Fecha, value);
        }

    }
}