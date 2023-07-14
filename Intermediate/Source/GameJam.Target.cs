using UnrealBuildTool;

public class GameJamTarget : TargetRules
{
	public GameJamTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameJam");
	}
}
