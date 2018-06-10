using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using System;
using System.Diagnostics;

namespace com.datacoper.appprodutor.Activities
{
    [Application]
    public class Start : Application
    {

        public Start(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        { }
        public override void OnCreate()
        {
            base.OnCreate();

            AndroidEnvironment.UnhandledExceptionRaiser += (sender, args) =>
            {
                args.Handled = true;

                try
                {
                    Toast.MakeText(this, "Não foi possível concluir a operação, por favor tente novamente.", ToastLength.Long).Show();         
                }
                catch { }
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                
            };
        }
    }
}