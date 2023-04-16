using System.Collections.Generic;
using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using TestMobile.Api.Models;
using TestMobile.Api.Models.Domain;

namespace TestMobile;

public class Adapter : RecyclerView.Adapter
{
    private readonly List<PassDomain> Passes;
    private Activity _activity;

    public Adapter(Activity activity, List<PassDomain> passes)
    {
        Passes = passes;
        _activity = activity;
    }

    public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    {
        ViewHolder vh = holder as ViewHolder;
        vh.TextView.Text = Passes[position].Pass.StartDate.ToString();
    }

    public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
    {
        View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CardView, parent, false);

        ViewHolder vh = new ViewHolder(itemView, _activity);
        return vh;
    }

    public override int ItemCount => Passes.Count;
}