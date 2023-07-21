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

        string segundoApellido;
        string primerApellido;
        string nombre;
        string numeroEmpleado;

        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NumeroEmpleado
        {
            get => numeroEmpleado;
            set => SetPropertyValue(nameof(NumeroEmpleado), ref numeroEmpleado, value);
        }

        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nombre
        {
            get => nombre;
            set => SetPropertyValue(nameof(Nombre), ref nombre, value);
        }


        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PrimerApellido
        {
            get => primerApellido;
            set => SetPropertyValue(nameof(PrimerApellido), ref primerApellido, value);
        }


        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SegundoApellido
        {
            get => segundoApellido;
            set => SetPropertyValue(nameof(SegundoApellido), ref segundoApellido, value);
        }



        [Association("Empleado-RegistroPrestacionEmpleados")]
        public XPCollection<RegistroPrestacionEmpleado> RegistroPrestacionEmpleados
        {
            get
            {
                return GetCollection<RegistroPrestacionEmpleado>(nameof(RegistroPrestacionEmpleados));
            }
        }


    }
}