using aplicativo_tarefa.Telas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicativo_tarefa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Listar());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
