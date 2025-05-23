using Mvvm.Navigation;

namespace SkiaDesktopTest.Presentation;


[ViewFor<SecondViewModel>]
public sealed partial class SecondPage : Page
{
    public SecondPage()
    {
        this.DataContext<SecondViewModel>((page, vm) => page
            .Background(Theme.Brushes.Background.Default)
            .Content(
                new Grid()
                    .SafeArea(SafeArea.InsetMask.VisibleBounds)
                    .Children(
                        new NavigationBar()
                            .Content("Second Page"),

                        new StackPanel()
                            .Grid(row: 1)
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .Spacing(16)
                            .Children(
                                new TextBlock()
                                    .Text(() => vm.Entity.Name)
                                    .HorizontalAlignment(HorizontalAlignment.Center)
                                    .VerticalAlignment(VerticalAlignment.Center)
                            )
                    )
                )
            );
    }
}

