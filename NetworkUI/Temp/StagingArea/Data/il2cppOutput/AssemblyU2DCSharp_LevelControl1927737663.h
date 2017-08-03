#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_ScriptableObject1975622470.h"

// FireWallData
struct FireWallData_t115724952;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LevelControl
struct  LevelControl_t1927737663  : public ScriptableObject_t1975622470
{
public:
	// System.Int32 LevelControl::maxLevel
	int32_t ___maxLevel_2;
	// FireWallData LevelControl::data1
	FireWallData_t115724952 * ___data1_3;
	// FireWallData LevelControl::data2
	FireWallData_t115724952 * ___data2_4;

public:
	inline static int32_t get_offset_of_maxLevel_2() { return static_cast<int32_t>(offsetof(LevelControl_t1927737663, ___maxLevel_2)); }
	inline int32_t get_maxLevel_2() const { return ___maxLevel_2; }
	inline int32_t* get_address_of_maxLevel_2() { return &___maxLevel_2; }
	inline void set_maxLevel_2(int32_t value)
	{
		___maxLevel_2 = value;
	}

	inline static int32_t get_offset_of_data1_3() { return static_cast<int32_t>(offsetof(LevelControl_t1927737663, ___data1_3)); }
	inline FireWallData_t115724952 * get_data1_3() const { return ___data1_3; }
	inline FireWallData_t115724952 ** get_address_of_data1_3() { return &___data1_3; }
	inline void set_data1_3(FireWallData_t115724952 * value)
	{
		___data1_3 = value;
		Il2CppCodeGenWriteBarrier(&___data1_3, value);
	}

	inline static int32_t get_offset_of_data2_4() { return static_cast<int32_t>(offsetof(LevelControl_t1927737663, ___data2_4)); }
	inline FireWallData_t115724952 * get_data2_4() const { return ___data2_4; }
	inline FireWallData_t115724952 ** get_address_of_data2_4() { return &___data2_4; }
	inline void set_data2_4(FireWallData_t115724952 * value)
	{
		___data2_4 = value;
		Il2CppCodeGenWriteBarrier(&___data2_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
