using System;
using System.Windows;
using VolumetricaControls;

namespace VolAnalysis.Creations;

internal interface IEfficientFactorySingleton
{
	bool ApplyVisible { get; set; }

	event EventHandler<RoutedEventArgs> CancelClick;

	event EventHandler<RoutedEventArgs> ApplyClick;

	event EventHandler<RoutedEventArgs> SaveClick;

	void SetContent(PropertyView config);

	void RemoveContent();
}
