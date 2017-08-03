#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_ScriptableObject1975622470.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Service
struct  Service_t1178910011  : public ScriptableObject_t1975622470
{
public:
	// System.String Service::name
	String_t* ___name_2;
	// System.String Service::usingPort
	String_t* ___usingPort_3;
	// System.String Service::direction
	String_t* ___direction_4;

public:
	inline static int32_t get_offset_of_name_2() { return static_cast<int32_t>(offsetof(Service_t1178910011, ___name_2)); }
	inline String_t* get_name_2() const { return ___name_2; }
	inline String_t** get_address_of_name_2() { return &___name_2; }
	inline void set_name_2(String_t* value)
	{
		___name_2 = value;
		Il2CppCodeGenWriteBarrier(&___name_2, value);
	}

	inline static int32_t get_offset_of_usingPort_3() { return static_cast<int32_t>(offsetof(Service_t1178910011, ___usingPort_3)); }
	inline String_t* get_usingPort_3() const { return ___usingPort_3; }
	inline String_t** get_address_of_usingPort_3() { return &___usingPort_3; }
	inline void set_usingPort_3(String_t* value)
	{
		___usingPort_3 = value;
		Il2CppCodeGenWriteBarrier(&___usingPort_3, value);
	}

	inline static int32_t get_offset_of_direction_4() { return static_cast<int32_t>(offsetof(Service_t1178910011, ___direction_4)); }
	inline String_t* get_direction_4() const { return ___direction_4; }
	inline String_t** get_address_of_direction_4() { return &___direction_4; }
	inline void set_direction_4(String_t* value)
	{
		___direction_4 = value;
		Il2CppCodeGenWriteBarrier(&___direction_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
