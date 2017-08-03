#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_ScriptableObject1975622470.h"

// System.Collections.Generic.List`1<FRule>
struct List_1_t2138850320;
// System.Collections.Generic.List`1<System.String>
struct List_1_t1398341365;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// FireWallData
struct  FireWallData_t115724952  : public ScriptableObject_t1975622470
{
public:
	// System.Collections.Generic.List`1<FRule> FireWallData::rawinputRules
	List_1_t2138850320 * ___rawinputRules_2;
	// System.Collections.Generic.List`1<FRule> FireWallData::rawoutputRules
	List_1_t2138850320 * ___rawoutputRules_3;
	// System.Collections.Generic.List`1<System.String> FireWallData::inputRules
	List_1_t1398341365 * ___inputRules_4;
	// System.Collections.Generic.List`1<System.String> FireWallData::outputRules
	List_1_t1398341365 * ___outputRules_5;

public:
	inline static int32_t get_offset_of_rawinputRules_2() { return static_cast<int32_t>(offsetof(FireWallData_t115724952, ___rawinputRules_2)); }
	inline List_1_t2138850320 * get_rawinputRules_2() const { return ___rawinputRules_2; }
	inline List_1_t2138850320 ** get_address_of_rawinputRules_2() { return &___rawinputRules_2; }
	inline void set_rawinputRules_2(List_1_t2138850320 * value)
	{
		___rawinputRules_2 = value;
		Il2CppCodeGenWriteBarrier(&___rawinputRules_2, value);
	}

	inline static int32_t get_offset_of_rawoutputRules_3() { return static_cast<int32_t>(offsetof(FireWallData_t115724952, ___rawoutputRules_3)); }
	inline List_1_t2138850320 * get_rawoutputRules_3() const { return ___rawoutputRules_3; }
	inline List_1_t2138850320 ** get_address_of_rawoutputRules_3() { return &___rawoutputRules_3; }
	inline void set_rawoutputRules_3(List_1_t2138850320 * value)
	{
		___rawoutputRules_3 = value;
		Il2CppCodeGenWriteBarrier(&___rawoutputRules_3, value);
	}

	inline static int32_t get_offset_of_inputRules_4() { return static_cast<int32_t>(offsetof(FireWallData_t115724952, ___inputRules_4)); }
	inline List_1_t1398341365 * get_inputRules_4() const { return ___inputRules_4; }
	inline List_1_t1398341365 ** get_address_of_inputRules_4() { return &___inputRules_4; }
	inline void set_inputRules_4(List_1_t1398341365 * value)
	{
		___inputRules_4 = value;
		Il2CppCodeGenWriteBarrier(&___inputRules_4, value);
	}

	inline static int32_t get_offset_of_outputRules_5() { return static_cast<int32_t>(offsetof(FireWallData_t115724952, ___outputRules_5)); }
	inline List_1_t1398341365 * get_outputRules_5() const { return ___outputRules_5; }
	inline List_1_t1398341365 ** get_address_of_outputRules_5() { return &___outputRules_5; }
	inline void set_outputRules_5(List_1_t1398341365 * value)
	{
		___outputRules_5 = value;
		Il2CppCodeGenWriteBarrier(&___outputRules_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
