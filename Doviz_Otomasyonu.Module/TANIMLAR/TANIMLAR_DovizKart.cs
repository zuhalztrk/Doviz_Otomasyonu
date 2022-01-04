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

namespace Doviz_Otomasyonu.Module.TANIMLAR
{
    [DefaultClassOptions]
    [DefaultProperty("DovizID")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    [RuleCriteria("BakiyeUyari", DefaultContexts.Save, "Bakiye>=0",
   "Bakiye - olamaz", SkipNullOrEmptyValues = false)]
    public class TANIMLAR_DovizKart : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public TANIMLAR_DovizKart(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _doviz_id;[Size(3)]
        public string DovizID
        {
            get { return _doviz_id; }
            set { SetPropertyValue(nameof(DovizID), ref _doviz_id, value); }

        }
        private string _doviz_adi;[Size(50)]
        public string DovizAdi
        {
            get { return _doviz_adi; }
            set { SetPropertyValue(nameof(DovizAdi), ref _doviz_adi, value); }

        }
        private decimal _doviz_giren_miktar;
        public decimal DovizGirenMiktar
        {
            get { return _doviz_giren_miktar; }
            set { SetPropertyValue(nameof(DovizGirenMiktar), ref _doviz_giren_miktar, value); }

        }
        private decimal _doviz_cıkan_miktar;
        public decimal DovizCikanMiktar
        {
            get { return _doviz_cıkan_miktar; }
            set { SetPropertyValue(nameof(DovizCikanMiktar), ref _doviz_cıkan_miktar, value); }

        }




        private decimal _bakiye; [NonPersistent]
        public decimal Bakiye
        {

            get { return DovizGirenMiktar - DovizCikanMiktar; }
            set
            {
                SetPropertyValue(nameof(Bakiye), ref _bakiye, value);

            }


        }




       






        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}