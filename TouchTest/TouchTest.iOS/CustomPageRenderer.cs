using TouchTest.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

//uncomment below for workaround ie disabling navigation pop gesture
//[assembly: ExportRenderer(typeof(Page), typeof(CustomPageRenderer))]
namespace TouchTest.iOS
{
    class CustomPageRenderer : PageRenderer
    {
        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            if (NavigationController != null)
            {
                NavigationController.InteractivePopGestureRecognizer.Enabled = false;
            }
        }
    }
}