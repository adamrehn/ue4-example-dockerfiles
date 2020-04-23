using UnrealBuildTool;
using System.Collections.Generic;

public class DummyProjectEditorTarget : TargetRules
{
	public DummyProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DummyProject");
	}
}
