using Android.Support.V4.App;
using Java.Lang;

namespace Somuleco.Droid
{
    public class UnauthenticatedAdapter : FragmentPagerAdapter
    {

        Fragment[] fragments;
        ICharSequence[] titles;

        public UnauthenticatedAdapter(FragmentManager fm, Fragment[] fragments, ICharSequence[] titles)
        : base(fm)
        {
            this.fragments = fragments;
            this.titles = titles;
        }

        public override int Count
        {
            get { return fragments.Length; }
        }

        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }

    }
}
