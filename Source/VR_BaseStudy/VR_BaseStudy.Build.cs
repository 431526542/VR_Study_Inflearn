// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class VR_BaseStudy : ModuleRules
{
	public VR_BaseStudy(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "UMG" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		//경로 설정에 추가하면 유리함
		PrivateIncludePaths.AddRange(new string[] 
		{
            "VR_BaseStudy/Main"
        });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
