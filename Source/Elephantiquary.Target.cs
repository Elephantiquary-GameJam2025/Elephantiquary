// Team Elephantiquary 2025

using UnrealBuildTool;
using System.Collections.Generic;

public class ElephantiquaryTarget : TargetRules
{
	public ElephantiquaryTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Elephantiquary" } );
	}
}
