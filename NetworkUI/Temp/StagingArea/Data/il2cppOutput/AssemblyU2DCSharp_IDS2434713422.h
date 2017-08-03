#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.String
struct String_t;
// UnityEngine.UI.Text
struct Text_t356221433;
// Controller
struct Controller_t1937198888;
// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// IDS
struct  IDS_t2434713422  : public MonoBehaviour_t1158329972
{
public:
	// System.String IDS::logText
	String_t* ___logText_2;
	// UnityEngine.UI.Text IDS::log
	Text_t356221433 * ___log_3;
	// Controller IDS::control
	Controller_t1937198888 * ___control_4;
	// UnityEngine.GameObject IDS::panelLeft
	GameObject_t1756533147 * ___panelLeft_5;
	// UnityEngine.GameObject IDS::panelRight
	GameObject_t1756533147 * ___panelRight_6;

public:
	inline static int32_t get_offset_of_logText_2() { return static_cast<int32_t>(offsetof(IDS_t2434713422, ___logText_2)); }
	inline String_t* get_logText_2() const { return ___logText_2; }
	inline String_t** get_address_of_logText_2() { return &___logText_2; }
	inline void set_logText_2(String_t* value)
	{
		___logText_2 = value;
		Il2CppCodeGenWriteBarrier(&___logText_2, value);
	}

	inline static int32_t get_offset_of_log_3() { return static_cast<int32_t>(offsetof(IDS_t2434713422, ___log_3)); }
	inline Text_t356221433 * get_log_3() const { return ___log_3; }
	inline Text_t356221433 ** get_address_of_log_3() { return &___log_3; }
	inline void set_log_3(Text_t356221433 * value)
	{
		___log_3 = value;
		Il2CppCodeGenWriteBarrier(&___log_3, value);
	}

	inline static int32_t get_offset_of_control_4() { return static_cast<int32_t>(offsetof(IDS_t2434713422, ___control_4)); }
	inline Controller_t1937198888 * get_control_4() const { return ___control_4; }
	inline Controller_t1937198888 ** get_address_of_control_4() { return &___control_4; }
	inline void set_control_4(Controller_t1937198888 * value)
	{
		___control_4 = value;
		Il2CppCodeGenWriteBarrier(&___control_4, value);
	}

	inline static int32_t get_offset_of_panelLeft_5() { return static_cast<int32_t>(offsetof(IDS_t2434713422, ___panelLeft_5)); }
	inline GameObject_t1756533147 * get_panelLeft_5() const { return ___panelLeft_5; }
	inline GameObject_t1756533147 ** get_address_of_panelLeft_5() { return &___panelLeft_5; }
	inline void set_panelLeft_5(GameObject_t1756533147 * value)
	{
		___panelLeft_5 = value;
		Il2CppCodeGenWriteBarrier(&___panelLeft_5, value);
	}

	inline static int32_t get_offset_of_panelRight_6() { return static_cast<int32_t>(offsetof(IDS_t2434713422, ___panelRight_6)); }
	inline GameObject_t1756533147 * get_panelRight_6() const { return ___panelRight_6; }
	inline GameObject_t1756533147 ** get_address_of_panelRight_6() { return &___panelRight_6; }
	inline void set_panelRight_6(GameObject_t1756533147 * value)
	{
		___panelRight_6 = value;
		Il2CppCodeGenWriteBarrier(&___panelRight_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
