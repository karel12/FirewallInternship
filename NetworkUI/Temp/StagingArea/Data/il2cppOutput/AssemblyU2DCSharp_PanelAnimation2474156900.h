#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Sprite[]
struct SpriteU5BU5D_t3359083662;
// UnityEngine.UI.Image
struct Image_t2042527209;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PanelAnimation
struct  PanelAnimation_t2474156900  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Sprite[] PanelAnimation::sprites
	SpriteU5BU5D_t3359083662* ___sprites_2;
	// System.Single PanelAnimation::frameRate
	float ___frameRate_3;
	// UnityEngine.UI.Image PanelAnimation::image
	Image_t2042527209 * ___image_4;

public:
	inline static int32_t get_offset_of_sprites_2() { return static_cast<int32_t>(offsetof(PanelAnimation_t2474156900, ___sprites_2)); }
	inline SpriteU5BU5D_t3359083662* get_sprites_2() const { return ___sprites_2; }
	inline SpriteU5BU5D_t3359083662** get_address_of_sprites_2() { return &___sprites_2; }
	inline void set_sprites_2(SpriteU5BU5D_t3359083662* value)
	{
		___sprites_2 = value;
		Il2CppCodeGenWriteBarrier(&___sprites_2, value);
	}

	inline static int32_t get_offset_of_frameRate_3() { return static_cast<int32_t>(offsetof(PanelAnimation_t2474156900, ___frameRate_3)); }
	inline float get_frameRate_3() const { return ___frameRate_3; }
	inline float* get_address_of_frameRate_3() { return &___frameRate_3; }
	inline void set_frameRate_3(float value)
	{
		___frameRate_3 = value;
	}

	inline static int32_t get_offset_of_image_4() { return static_cast<int32_t>(offsetof(PanelAnimation_t2474156900, ___image_4)); }
	inline Image_t2042527209 * get_image_4() const { return ___image_4; }
	inline Image_t2042527209 ** get_address_of_image_4() { return &___image_4; }
	inline void set_image_4(Image_t2042527209 * value)
	{
		___image_4 = value;
		Il2CppCodeGenWriteBarrier(&___image_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
