﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackingPage : ContentPage
	{
        private AccelerationReader ar;

		public TrackingPage ()
		{
			InitializeComponent ();
            ar = new AccelerationReader();
            ar.ToggleAccelerometer();
		}



	}
}