﻿using aplicativo_tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicativo_tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Visualizar : ContentPage
    {
        public Visualizar()
        {
            InitializeComponent();
        }

        public Visualizar(Tarefa tarefa)
        {
            InitializeComponent();

            BindingContext = tarefa;

            if (tarefa.Nota == null || tarefa.Nota != null && tarefa.Nota.Length == 0)
            {
                LblTituloNota.IsVisible = false;
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}