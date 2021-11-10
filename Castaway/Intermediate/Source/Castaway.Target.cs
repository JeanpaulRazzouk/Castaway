using UnrealBuildTool;

public class CastawayTarget : TargetRules
{
	public CastawayTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Castaway");
	}
}
