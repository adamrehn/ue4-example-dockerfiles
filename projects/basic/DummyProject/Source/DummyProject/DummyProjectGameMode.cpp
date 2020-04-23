#include "DummyProjectGameMode.h"
#include "DummyProjectHUD.h"
#include "DummyProjectCharacter.h"
#include "UObject/ConstructorHelpers.h"

ADummyProjectGameMode::ADummyProjectGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = ADummyProjectHUD::StaticClass();
}
