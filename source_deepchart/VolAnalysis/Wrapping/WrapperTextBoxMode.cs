using System.ComponentModel.DataAnnotations;
using Deepchart.Management;

namespace VolAnalysis.Wrapping;

internal enum WrapperTextBoxMode
{
	[Display(Name = "Dark")]
	Dark = 100,
	[Display(Name = "Dark (standard)")]
	DarkStandard = 101,
	[Display(Name = "Blue")]
	Blue = 200,
	[Display(Name = "Light")]
	Light = 300,
	[Display(Name = "Light (standard)")]
	LightStandard = 301,
	[Display(Name = "Purple")]
	Purple = 400,
	[IdentifiableCalculatorAllocator]
	DarkGreen = 1000,
	[IdentifiableCalculatorAllocator]
	DarkLightBlue = 1001
}
