using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Doviz_Otomasyonu.Module.TANIMLAR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Doviz_Otomasyonu.Module.HAREKET
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    [RuleCriteria("Miktaruyari", DefaultContexts.Save, "Miktar != 0",
   "Miktar 0 VEYA eksi  Olamaz.!", SkipNullOrEmptyValues = false)]
    
    public class HAREKET_DovizIslemleri : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public HAREKET_DovizIslemleri(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        private string _musteri_adi;[Size(100)]
        public string MusteriAdi 
        {
            get
            {
                return _musteri_adi;
            }
            set
            {
                SetPropertyValue(nameof(MusteriAdi), ref _musteri_adi, value);
            }
        }

        private string _tckn;[Size(11)]
        public string TCKN 
        {
            get
            {
                return _tckn;
            }
            set
            {
                SetPropertyValue(nameof(TCKN), ref _tckn, value);
            }
        }
        private TANIMLAR_DovizKart _doviz_id;
        public TANIMLAR_DovizKart DovizID
        {
            get { return _doviz_id; }
            set { SetPropertyValue(nameof(DovizID), ref _doviz_id, value); }

        }
        private decimal _miktar;
        public decimal Miktar
        {
            get
            {
                return _miktar;
            }
            set
            {
                SetPropertyValue(nameof(Miktar), ref _miktar, value);
            }
        }
        private decimal _kur;
        public decimal KUR
        {
            get
            {
                return _kur;
            }
            set
            {
                SetPropertyValue(nameof(KUR), ref _kur, value);
            }
        }
        private decimal _tutar;
        public decimal Tutar
        {
            get
            {
                return _tutar;
            }
            set
            {
                SetPropertyValue(nameof(Tutar), ref _tutar, value);
            }
        }
        private decimal _stopaj;
        public decimal Stopaj
        {
            get
            {
                return _stopaj;
            }
            set
            {
                SetPropertyValue(nameof(Stopaj), ref _stopaj, value);
            }
        }
     

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == "Miktar" || propertyName == "KUR")
            {
                Tutar = Miktar * KUR;
                Stopaj = Tutar * 99/100;

            }
        }
    }



}