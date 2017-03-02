using Xamarin.Forms;
using MasterDetailPageExample.Controls;
using MasterDetailPageExample.Droid.Controls;
using Xamarin.Forms.Platform.Android.AppCompat;
using System.Reflection;

[assembly: ExportRenderer(typeof(CustomMasterDetailPage), typeof(CustomMasterDetailRenderer))]
namespace MasterDetailPageExample.Droid.Controls
{
    public class CustomMasterDetailRenderer : MasterDetailPageRenderer
    {
        public override void AddView(Android.Views.View child)
        {
            child.GetType().GetRuntimeProperty("TopPadding").SetValue(child, 0);
            base.AddView(child);
        }
    }
}