﻿using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Uno.UI;
using Uno.UI.Samples.Controls;

namespace UITests.Shared.Windows_UI_Input.GestureRecognizerTests
{
	[SampleControlInfo("Gesture recognizer")]
	public sealed partial class TappedTest : Page
	{
		public TappedTest()
		{
			this.InitializeComponent();
		}

		private void TargetTapped(object sender, TappedRoutedEventArgs e)
		{
			var target = (FrameworkElement)sender;
			var position = e.GetPosition(target).LogicalToPhysicalPixels();

			LastTapped.Text = $"{target.Name}@{position.X:F2},{position.Y:F2}";
		}

		private void ItemTapped(object sender, TappedRoutedEventArgs e)
		{
			var target = (FrameworkElement)sender;
			var position = e.GetPosition(target).LogicalToPhysicalPixels();

			LastTapped.Text = $"Item_{target.DataContext}@{position.X:F2},{position.Y:F2}";
		}
	}
}
