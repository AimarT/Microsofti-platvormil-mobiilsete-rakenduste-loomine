﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Exercises
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Kw { get; set; }
        public int ImageResourceId { get; set; }
    }
}