#pragma once 

#include "CoreMinimal.h"
#include "GameFramework/HUD.h"
#include "DummyProjectHUD.generated.h"

UCLASS()
class ADummyProjectHUD : public AHUD
{
	GENERATED_BODY()

public:
	ADummyProjectHUD();

	/** Primary draw call for the HUD */
	virtual void DrawHUD() override;

private:
	/** Crosshair asset pointer */
	class UTexture2D* CrosshairTex;

};

