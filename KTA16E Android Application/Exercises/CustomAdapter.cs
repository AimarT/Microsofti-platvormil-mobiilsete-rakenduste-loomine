﻿using System.Collections.Generic;

using Android.App;
using Android.Views;
using Android.Widget;

namespace Exercises
{
    public class CustomAdapter : BaseAdapter
    {
        List<Car> items;
        Activity context;

        public CustomAdapter(Activity context, List<Car> items) : base()
        {
            this.context = context;
            this.items = items;
        }       

        public override int Count
        {
            get { return items.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null; // could wrap a Contact in a Java.Lang.Object to return it here if needed
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = items[position].Name;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = items[position].Kw.ToString();
            return view;
        }
    }
}