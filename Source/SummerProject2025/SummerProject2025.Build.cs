// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SummerProject2025 : ModuleRules
{
	public SummerProject2025(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SummerProject2025",
			"SummerProject2025/Variant_Platforming",
			"SummerProject2025/Variant_Combat",
			"SummerProject2025/Variant_Combat/AI",
			"SummerProject2025/Variant_SideScrolling",
			"SummerProject2025/Variant_SideScrolling/Gameplay",
			"SummerProject2025/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
