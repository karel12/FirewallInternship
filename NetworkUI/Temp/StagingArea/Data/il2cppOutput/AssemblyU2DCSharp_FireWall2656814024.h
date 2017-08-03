#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// FireWallData
struct FireWallData_t115724952;
// Controller
struct Controller_t1937198888;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// FireWall
struct FireWall_t2656814024;
// UnityEngine.UI.Text
struct Text_t356221433;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// FireWall
struct  FireWall_t2656814024  : public MonoBehaviour_t1158329972
{
public:
	// FireWallData FireWall::data
	FireWallData_t115724952 * ___data_2;
	// Controller FireWall::control
	Controller_t1937198888 * ___control_3;
	// UnityEngine.GameObject FireWall::panel
	GameObject_t1756533147 * ___panel_4;
	// UnityEngine.GameObject FireWall::rulePanel
	GameObject_t1756533147 * ___rulePanel_5;
	// FireWall FireWall::thisObject
	FireWall_t2656814024 * ___thisObject_6;
	// UnityEngine.UI.Text FireWall::input
	Text_t356221433 * ___input_7;
	// UnityEngine.UI.Text FireWall::output
	Text_t356221433 * ___output_8;

public:
	inline static int32_t get_offset_of_data_2() { return static_cast<int32_t>(offsetof(FireWall_t2656814024, ___data_2)); }
	inline FireWallData_t115724952 * get_data_2() const { return ___data_2; }
	inline FireWallData_t115724952 ** get_address_of_data_2() { return &___data_2; }
	inline void set_data_2(FireWallData_t115724952 * value)
	{
		___data_2 = value;
		Il2CppCodeGenWriteBarrier(&___data_2, value);
	}

	inline static int32_t get_offset_of_control_3() { return static_cast<int32_t>(offsetof(FireWall_t2656814024, ___control_3)); }
	inline Controller_t1937198888 * get_control_3() const { return ___control_3; }
	inline Controller_t1937198888 ** get_address_of_control_3() { return &___control_3; }
	inline void set_control_3(Controller_t1937198888 * value)
	{
		___control_3 = value;
		Il2CppCodeGenWriteBarrier(&___control_3, value);
	}

	inline static int32_t get_offset_of_panel_4() { return static_cast<int32_t>(offsetof(FireWall_t2656814024, ___panel_4)); }
	inline GameObject_t1756533147 * get_panel_4() const { return ___panel_4; }
	inline GameObject_t1756533147 ** get_address_of_panel_4() { return &___panel_4; }
	inline void set_panel_4(GameObject_t1756533147 * value)
	{
		___panel_4 = value;
		Il2CppCodeGenWriteBarrier(&___panel_4, value);
	}

	inline static int32_t get_offset_of_rulePanel_5() { return static_cast<int32_t>(offsetof(FireWall_t2656814024, ___rulePanel_5)); }
	inline GameObject_t1756533147 * get_rulePanel_5() const { return ___rulePanel_5; }
	inline GameObject_t1756533147 ** get_address_of_rulePanel_5() { return &___rulePanel_5; }
	inline void set_rulePanel_5(GameObject_t1756533147 * value)
	{
		___rulePanel_5 = value;
		Il2CppCodeGenWriteBarrier(&___rulePanel_5, value);
	}

	inline static int32_t get_offset_of_thisObject_6() { return static_cast<int32_t>(offsetof(FireWall_t2656814024, ___thisObject_6)); }
	inline FireWall_t2656814024 * get_thisObject_6() const { return ___thisObject_6; }
	inline FireWall_t2656814024 ** get_address_of_thisObject_6() { return &___thisObject_6; }
	inline void set_thisObject_6(FireWall_t2656814024 * value)
	{
		___thisObject_6 = value;
		Il2CppCodeGenWriteBarrier(&___thisObject_6, value);
	}

	inline static int32_t get_offset_of_input_7() { return static_cast<int32_t>(offsetof(FireWall_t2656814024, ___input_7)); }
	inline Text_t356221433 * get_input_7() const { return ___input_7; }
	inline Text_t356221433 ** get_address_of_input_7() { return &___input_7; }
	inline void set_input_7(Text_t356221433 * value)
	{
		___input_7 = value;
		Il2CppCodeGenWriteBarrier(&___input_7, value);
	}

	inline static int32_t get_offset_of_output_8() { return static_cast<int32_t>(offsetof(FireWall_t2656814024, ___output_8)); }
	inline Text_t356221433 * get_output_8() const { return ___output_8; }
	inline Text_t356221433 ** get_address_of_output_8() { return &___output_8; }
	inline void set_output_8(Text_t356221433 * value)
	{
		___output_8 = value;
		Il2CppCodeGenWriteBarrier(&___output_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
