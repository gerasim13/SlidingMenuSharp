using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;

namespace Sample.Fragments
{
    public class BirdMenuFragment : ListFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup p1, Bundle p2)
        {
            return inflater.Inflate(Resource.Layout.list, null);
        }

        public override void OnActivityCreated(Bundle p0)
        {
            base.OnActivityCreated(p0);

            var birds = Resources.GetStringArray(Resource.Array.birds);
            var colorAdapter = new ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleListItem1,
                                                        Android.Resource.Id.Text1, birds);
            ListAdapter = colorAdapter;
        }

        public override void OnListItemClick(ListView p0, View p1, int p2, long p3)
        {
            var newContent = new BirdGridFragment(p2);
            SwitchFragment(newContent);
        }

        private void SwitchFragment(Android.Support.V4.App.Fragment fragment)
        {
            if (null == Activity)
                return;
            
            if (Activity is ResponsiveUIActivity)
            {
                var ra = (ResponsiveUIActivity) Activity;
                ra.SwitchContent(fragment);
            }
        }
    }
}