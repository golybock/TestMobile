using System;
using Android.App;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TestMobile;

public class ViewHolder : RecyclerView.ViewHolder
{
    public LinearLayout Card { get; set; }
    public TextView TextView { get; set; }

    public ViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }

    public ViewHolder(View itemView, Activity activity) : base(itemView)
    {
        TextView = itemView.FindViewById<TextView>(Resource.Id.pass_text);
    }
}