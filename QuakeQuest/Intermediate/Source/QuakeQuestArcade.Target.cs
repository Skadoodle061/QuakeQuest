using UnrealBuildTool;

public class QuakeQuestArcadeTarget : TargetRules
{
	public QuakeQuestArcadeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("QuakeQuestArcade");
	}
}
