using UnrealBuildTool;
using System.Collections.Generic;

public class DummyProjectTarget : TargetRules
{
	public DummyProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("DummyProject");
	}
}
