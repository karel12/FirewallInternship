#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// FireWall
struct FireWall_t2656814024;
// UnityEngine.UI.ToggleGroup
struct ToggleGroup_t1030026315;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ToggleControl
struct  ToggleControl_t4102087071  : public MonoBehaviour_t1158329972
{
public:
	// FireWall ToggleControl::firewall
	FireWall_t2656814024 * ___firewall_2;
	// UnityEngine.UI.ToggleGroup ToggleControl::chain
	ToggleGroup_t1030026315 * ___chain_3;
	// UnityEngine.UI.ToggleGroup ToggleControl::ip
	ToggleGroup_t1030026315 * ___ip_4;
	// UnityEngine.UI.ToggleGroup ToggleControl::port
	ToggleGroup_t1030026315 * ___port_5;
	// UnityEngine.UI.ToggleGroup ToggleControl::policy
	ToggleGroup_t1030026315 * ___policy_6;

public:
	inline static int32_t get_offset_of_firewall_2() { return static_cast<int32_t>(offsetof(ToggleControl_t4102087071, ___firewall_2)); }
	inline FireWall_t2656814024 * get_firewall_2() const { return ___firewall_2; }
	inline FireWall_t2656814024 ** get_address_of_firewall_2() { return &___firewall_2; }
	inline void set_firewall_2(FireWall_t2656814024 * value)
	{
		___firewall_2 = value;
		Il2CppCodeGenWriteBarrier(&___firewall_2, value);
	}

	inline static int32_t get_offset_of_chain_3() { return static_cast<int32_t>(offsetof(ToggleControl_t4102087071, ___chain_3)); }
	inline ToggleGroup_t1030026315 * get_chain_3() const { return ___chain_3; }
	inline ToggleGroup_t1030026315 ** get_address_of_chain_3() { return &___chain_3; }
	inline void set_chain_3(ToggleGroup_t1030026315 * value)
	{
		___chain_3 = value;
		Il2CppCodeGenWriteBarrier(&___chain_3, value);
	}

	inline static int32_t get_offset_of_ip_4() { return static_cast<int32_t>(offsetof(ToggleControl_t4102087071, ___ip_4)); }
	inline ToggleGroup_t1030026315 * get_ip_4() const { return ___ip_4; }
	inline ToggleGroup_t1030026315 ** get_address_of_ip_4() { return &___ip_4; }
	inline void set_ip_4(ToggleGroup_t1030026315 * value)
	{
		___ip_4 = value;
		Il2CppCodeGenWriteBarrier(&___ip_4, value);
	}

	inline static int32_t get_offset_of_port_5() { return static_cast<int32_t>(offsetof(ToggleControl_t4102087071, ___port_5)); }
	inline ToggleGroup_t1030026315 * get_port_5() const { return ___port_5; }
	inline ToggleGroup_t1030026315 ** get_address_of_port_5() { return &___port_5; }
	inline void set_port_5(ToggleGroup_t1030026315 * value)
	{
		___port_5 = value;
		Il2CppCodeGenWriteBarrier(&___port_5, value);
	}

	inline static int32_t get_offset_of_policy_6() { return static_cast<int32_t>(offsetof(ToggleControl_t4102087071, ___policy_6)); }
	inline ToggleGroup_t1030026315 * get_policy_6() const { return ___policy_6; }
	inline ToggleGroup_t1030026315 ** get_address_of_policy_6() { return &___policy_6; }
	inline void set_policy_6(ToggleGroup_t1030026315 * value)
	{
		___policy_6 = value;
		Il2CppCodeGenWriteBarrier(&___policy_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
