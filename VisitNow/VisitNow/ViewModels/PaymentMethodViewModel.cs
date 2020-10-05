using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using VisitNow.Models;
using Xamarin.Forms;

namespace VisitNow.ViewModels
{
    public class PaymentMethodViewModel : BaseViewModel
    {
        public ObservableCollection<PaymentMethod> PaymentMethods { get; set; }
        public Command LoadPaymentMethodsCommand { get; set; }

        public PaymentMethodViewModel(Page context)
        {
            Title = "Método de Pagamento";
            Context = context;
            PaymentMethods = new ObservableCollection<PaymentMethod>();
            LoadPaymentMethodsCommand = new Command(async () => await ExecuteLoadPaymentMethodsCommand());
        }

        async Task ExecuteLoadPaymentMethodsCommand()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                PaymentMethods.Clear();
                ObservableCollection<PaymentMethod> paymentMethods = new ObservableCollection<PaymentMethod>()
                {
                    new PaymentMethod()
                    {
                        CardNumber = "...****.0000",
                        Name = "Fulano de Tal",
                        Flag = "card_mastercard"
                    },
                    new PaymentMethod()
                    {
                        CardNumber = "...****.1111",
                        Name = "Fulano de Tal",
                        Flag = "card_visa"
                    }
                };

                foreach (var item in paymentMethods)
                {
                    PaymentMethods.Add(item);
                    await Task.Delay(500);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
