using Android.App;
using SherlockSlidingMenuSharp;

namespace Sample.Anim
{
    [Activity(Label = "Scale Animation")]
    public class ScaleAnimation : CustomAnimation
    {
        public ScaleAnimation() 
            : base(Resource.String.anim_scale)
        {
            Transformer = new ScaleTransformer();
        }
    }
}