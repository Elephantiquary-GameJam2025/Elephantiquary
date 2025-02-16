// Team Elephantiquary 2025

using UnrealBuildTool;
using System.Collections.Generic;

public class ElephantiquaryEditorTarget : TargetRules
{
	public ElephantiquaryEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Elephantiquary" } );
	}
}
