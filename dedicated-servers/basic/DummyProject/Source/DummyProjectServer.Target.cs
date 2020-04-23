using UnrealBuildTool;
using System.Collections.Generic;

public class DummyProjectServerTarget : TargetRules
{
	public DummyProjectServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("DummyProject");
	}
}
