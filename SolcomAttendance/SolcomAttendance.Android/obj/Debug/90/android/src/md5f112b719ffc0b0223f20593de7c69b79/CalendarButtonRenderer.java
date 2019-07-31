package md5f112b719ffc0b0223f20593de7c69b79;


public class CalendarButtonRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ButtonRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XamForms.Controls.Droid.CalendarButtonRenderer, XamForms.Controls.Calendar.Droid", CalendarButtonRenderer.class, __md_methods);
	}


	public CalendarButtonRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CalendarButtonRenderer.class)
			mono.android.TypeManager.Activate ("XamForms.Controls.Droid.CalendarButtonRenderer, XamForms.Controls.Calendar.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CalendarButtonRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CalendarButtonRenderer.class)
			mono.android.TypeManager.Activate ("XamForms.Controls.Droid.CalendarButtonRenderer, XamForms.Controls.Calendar.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CalendarButtonRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CalendarButtonRenderer.class)
			mono.android.TypeManager.Activate ("XamForms.Controls.Droid.CalendarButtonRenderer, XamForms.Controls.Calendar.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
