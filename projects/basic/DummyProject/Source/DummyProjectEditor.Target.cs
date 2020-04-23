using UnrealBuildTool;
using System.Collections.Generic;

public class DummyProjectEditorTarget : TargetRules
{
	public DummyProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("DummyProject");
	}
}
