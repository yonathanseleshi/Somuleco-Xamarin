
using Android.Support.V4.App;
using Java.Lang;

namespace Somuleco.Droid
{
    public class UnauthenticatedAdapter : FragmentPagerAdapter
    {

        Android.Support.V4.App.Fragment[] fragments;
        ICharSequence[] titles;

        public UnauthenticatedAdapter(Android.Support.V4.App.FragmentManager fm, Fragment[] fragments, ICharSequence[] titles)
        : base(fm)
        {
            this.fragments = fragments;
            this.titles = titles;
        }

        public override int Count
        {
            get { return fragments.Length; }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return (Android.Support.V4.App.Fragment)fragments[position];
        }

    }
}
