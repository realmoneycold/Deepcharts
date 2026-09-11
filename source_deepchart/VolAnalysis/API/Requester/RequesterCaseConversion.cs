using System.ComponentModel.DataAnnotations;

namespace VolAnalysis.API.Requester;

internal enum RequesterCaseConversion
{
	[Display(Name = "Local")]
	PersonalLocal,
	[Display(Name = "Cloud")]
	PersonalCloud,
	[Display(Name = "Shared")]
	SharedCloud
}
