using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Widget;
using TestMobile.Api.Models;
using TestMobile.Api.Models.Domain;

namespace TestMobile;

[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
public class PassActivity : AppCompatActivity
{
    RecyclerView mRecyclerView;
    RecyclerView.LayoutManager mLayoutManager;
    Adapter mAdapter;
    List<PassDomain> passes;
    private Api.Api _api;

    public PassActivity()
    {
        _api = new Api.Api();
    }

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_pass);
        
        mRecyclerView = FindViewById<RecyclerView> (Resource.Id.recycle_view);
        
        SetPasses();
    }

    private async void SetPasses()
    {
        var passes = await _api.GetPasses();
        // Plug in the linear layout manager:
        mLayoutManager = new LinearLayoutManager (this);
        mRecyclerView.SetLayoutManager (mLayoutManager);

        // Plug in my adapter:
        mAdapter = new  (this, passes);
        mRecyclerView.SetAdapter (mAdapter);
    }
}