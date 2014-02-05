using Android.Views;
using SherlockSlidingMenuSharp;

namespace SherlockSlidingMenuSharp.App
{
    public interface ISlidingActivity
    {
        void SetBehindContentView(View view, ViewGroup.LayoutParams layoutParams);
        void SetBehindContentView(View view);
        void SetBehindContentView(int layoutResId);
        SlidingMenu SlidingMenu { get; }
        void Toggle();
        void ShowContent();
        void ShowMenu();
        void ShowSecondaryMenu();
        void SetSlidingActionBarEnabled(bool enabled);
    }
}