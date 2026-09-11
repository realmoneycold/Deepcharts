using System.ComponentModel.DataAnnotations;

namespace Deepchart.DecisionMaking;

internal enum DeciderChainPolicyType
{
	Warzone,
	[Display(Name = "Female - Emily")]
	FemaleVoice,
	[Display(Name = "Female - Daniela")]
	FemaleVoice2,
	[Display(Name = "Male")]
	MaleVoice
}
