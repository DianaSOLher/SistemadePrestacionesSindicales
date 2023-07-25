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
using System.ComponentModel.DataAnnotations.Schema;

namespace Prestaciones.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty(nameof(Nombre))]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Prestacion : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Prestacion(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {


            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        Registro registro;
        private string _Nombre;
        [RuleRequiredField]
        [Size(150)]
        public string Nombre
        {
            get => _Nombre;
            set => SetPropertyValue(nameof(Nombre), ref _Nombre, value);
        }

        private string _Clausula;
        [Size(10)]
        public string Clausula
        {
            get => _Clausula;
            set => SetPropertyValue(nameof(Clausula), ref _Clausula, value);
        }

        private string _Numeral;
        [Size(10)]
        public string Numeral
        {
            get => _Numeral;
            set => SetPropertyValue(nameof(Numeral), ref _Numeral, value);
        }

        [Association("Prestacion-Documento")]
        public XPCollection<Documento> Documento
        {
            get
            {
                return GetCollection<Documento>(nameof(Documento));
            }
        }


        [Association("Prestacion-Registro")]
        public XPCollection<Registro> Registro
        {
            get
            {
                return GetCollection<Registro>(nameof(Registro));
            }
        }


    }

    
}