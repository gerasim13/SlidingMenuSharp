using Android.App;
using SherlockSlidingMenuSharp;

namespace Sample.Anim
{
    [Activity(Label = "Slide Animation")]
    public class SlideAnimation : CustomAnimation
    {
        public SlideAnimation()
            : base(Resource.String.anim_slide)
        {
            Transformer = new SlideTransformer();
        }
    }
}