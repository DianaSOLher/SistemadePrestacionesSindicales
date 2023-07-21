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
    [DefaultProperty(nameof(NumeroEmpleado))]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Empleado : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Empleado(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _NumeroEmpleado;
        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NumeroEmpleado
        {
            get => _NumeroEmpleado;
            set => SetPropertyValue(nameof(NumeroEmpleado), ref _NumeroEmpleado, value);
        }

        private string _Nombre;
        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nombre
        {
            get => _Nombre;
            set => SetPropertyValue(nameof(Nombre), ref _Nombre, value);
        }

        private string _PrimerApellido;
        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PrimerApellido
        {
            get => _PrimerApellido;
            set => SetPropertyValue(nameof(PrimerApellido), ref _PrimerApellido, value);
        }

        private string _SegundoApellido;
        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SegundoApellido
        {
            get => _SegundoApellido;
            set => SetPropertyValue(nameof(SegundoApellido), ref _SegundoApellido, value);
        }

        [Association("Empleado-Registro")]
        public XPCollection<Registro> Registro
        {
            get
            {
                return GetCollection<Registro>(nameof(Registro));
            }
        }


    }
}