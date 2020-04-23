using UnrealBuildTool;
using System.Collections.Generic;

public class DummyProjectTarget : TargetRules
{
	public DummyProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DummyProject");
	}
}
