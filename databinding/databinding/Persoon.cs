using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace databinding
{
    public class Persoon : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string naamValue;

        public string Naam
        {
            get { return  naamValue;; }
            set
            {
                naamValue = value;
                RaisePropertyChanged("Naam");
            }
        }

        private decimal weddeValue;

        public decimal Wedde
        {
            get { return weddeValue; }
            set
            {
                weddeValue = value;
                RaisePropertyChanged("Wedde");
            }
        }

        private DateTime indienstValue;

        public DateTime InDienst
        {
            get { return indienstValue; }
            set
            {
                indienstValue = value;
                RaisePropertyChanged("InDienst");

            }
        }


        private void RaisePropertyChanged(string info)
        {
            if (PropertyChanged !=null )
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public Persoon(string naam, decimal wedde, DateTime indienst)
        {
            this.Naam = naam;
            this.Wedde = wedde;
            this.InDienst = indienst;
        }
    }
}
