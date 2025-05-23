# Is ControlTemplate's OnApplyTemplate() Not Being Called on Skia Desktop in Uno Platform? [UnoPlatform Issue #20498](https://github.com/unoplatform/uno/discussions/20498)

I’m investigating upgrading an existing Uno Platform project to replace net9.0-windows10.0.26100 with net9.0-desktop using Skia Desktop renderer.  The current project has many custom controls that are implemented as ControlTemplates.   Everything works well when using the net9.0-windows10.0.26100 target framework, but I’ve noticed when switching to the net9.0-desktop that the OnApplyTemplate() doesn’t seem to be called as expected.   Again, OnApplyTemplate() is not called, so GetTemplateChild() always returns null on net9.0-desktop.

A few things I've tried:
- Setting FeatureConfiguration.Control.UseDeferredOnApplyTemplate = true, but the issue persists.
- Ensuring that the control has a template properly set.

Has anyone else run into this with Skia Desktop? Is there a known workaround, or is there some documentation about Skia Desktop's support for ControlTemplates that I am missing? 🤔

References:

[Unable to override OnApplyTemplate](https://stackoverflow.com/questions/57309447/unable-to-override-onapplytemplate)

[OnApplyTemplate is called no matter its initial visibility #13019
](https://github.com/unoplatform/uno/issues/13019)
