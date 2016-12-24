using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Coin_counter
{
    class VM: INotifyPropertyChanged
    {
        public decimal Penny
        {
            get { return _penny; }
            set { _penny = value; Calc(); OnPropertyChanged(); }
        }
        private decimal _penny;
        public string Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged(); }
        }
        private string _result;
        public decimal Dime
        {
            get { return _dime; }
            set { _dime = value;Calc(); OnPropertyChanged(); }
        }
        private decimal _dime;
        public decimal Nickel
        {
            get { return _nickel; }
            set { _nickel = value;Calc(); OnPropertyChanged(); }
        }
        private decimal _nickel;
        public decimal Quarter
        {
            get { return _quarter; }
            set { _quarter = value;Calc(); OnPropertyChanged(); }
        }
        private decimal _quarter;
        
        public void Calc()
        {
            decimal add = ((Penny * 1 ) + (Nickel * 5) + (Dime * 10) + (Quarter * 25));
            if (add < 100)
            {
                Result = "Money is less than a dollar";

            }
            else if (add > 100)
            {
                Result = "Money is more than a dollar";

            }
            else if (add == 100)
            {
                Result = "Congratulations,Money is exactly a dollar!!!";
            }
            else
            {
                System.Windows.MessageBox.Show("Enter valid values");
                Penny = 0;
                Nickel = 0;
                Dime = 0;
                Quarter = 0;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
