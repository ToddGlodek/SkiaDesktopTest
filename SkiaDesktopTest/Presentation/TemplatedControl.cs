
/*****  https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.frameworkelement.onapplytemplate?view=winrt-26100   ****/

namespace SkiaDesktopTest.Presentation;

internal partial class TemplatedControl : Control
{

    public TemplatedControl() : base()
    {

        DefaultStyleKey = typeof(TemplatedControl);
    }


    protected override void OnApplyTemplate()
    {

        base.OnApplyTemplate();

    }

}
