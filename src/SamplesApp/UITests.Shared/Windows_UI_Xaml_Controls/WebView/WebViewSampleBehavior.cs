﻿using System;
using Windows.UI.Xaml;
using WebViewUno = Windows.UI.Xaml.Controls.WebView;

namespace Uno.UI.Samples.Content.UITests.WebView
{
	public static class WebViewSampleBehavior
	{
		public static string GetSourceUri(DependencyObject obj)
		{
			return (string)obj.GetValue(SourceUriProperty);
		}

		public static void SetSourceUri(DependencyObject obj, string value)
		{
			obj.SetValue(SourceUriProperty, value);
		}
		
		public static readonly DependencyProperty SourceUriProperty =
			DependencyProperty.RegisterAttached("SourceUri", typeof(string), typeof(WebViewSampleBehavior), new PropertyMetadata("", OnSourceUriChanged));

		private static void OnSourceUriChanged(object d, DependencyPropertyChangedEventArgs e)
		{
			var uriString = e.NewValue?.ToString();
			if (!string.IsNullOrEmpty(uriString))
			{
				(d as WebViewUno).Navigate(new Uri(uriString, UriKind.Absolute));
			}
		}
	}
}
