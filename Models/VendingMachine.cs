using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Models
{
    public class VendingMachine
    {
        private VendingMachineDto _vendingMachineDto;

        public const string InsertCoinMessage = "INSERT_COIN";

        private string _display;
        public string Display
        {
            get { return _display; }
            private set
            {
                _display = value;
                _vendingMachineDto.Display.Text = value;
            }
        }


        private int _amountPaidCents;
        public int AmountPaidCents
        {
            get { return _amountPaidCents; }
            set
            {
                _amountPaidCents = value;
                decimal amountPaid = _amountPaidCents / 100m;
                Display = $@"${amountPaid:N2}";
            }
        }


        public VendingMachine(VendingMachineDto vendingMachineDto)
        {
            Debug.Assert(vendingMachineDto != null, "vendingMachineDto != null");
            Debug.Assert(vendingMachineDto.Display != null, "vendingMachineDto.Display != null");

            _vendingMachineDto = vendingMachineDto;
            Display = InsertCoinMessage;
        }

        public void InsertCoin(float weightGrams, float diameterMm)
        {
            int coinValue = CoinDetector.CoinValue(weightGrams, diameterMm);
            if (coinValue > 0)
            {
                AmountPaidCents += coinValue;
            }
                
        }
    }
}
