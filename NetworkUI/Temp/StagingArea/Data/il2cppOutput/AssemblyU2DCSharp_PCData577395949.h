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
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.UI.Text
struct Text_t356221433;
// Controller
struct Controller_t1937198888;
// Service[]
struct ServiceU5BU5D_t3693819770;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PCData
struct  PCData_t577395949  : public MonoBehaviour_t1158329972
{
public:
	// System.String PCData::id
	String_t* ___id_2;
	// System.String PCData::IPadress
	String_t* ___IPadress_3;
	// UnityEngine.GameObject PCData::panel
	GameObject_t1756533147 * ___panel_4;
	// UnityEngine.UI.Text PCData::ip
	Text_t356221433 * ___ip_5;
	// UnityEngine.UI.Text PCData::servicesRunning
	Text_t356221433 * ___servicesRunning_6;
	// Controller PCData::control
	Controller_t1937198888 * ___control_7;
	// Service[] PCData::services
	ServiceU5BU5D_t3693819770* ___services_8;

public:
	inline static int32_t get_offset_of_id_2() { return static_cast<int32_t>(offsetof(PCData_t577395949, ___id_2)); }
	inline String_t* get_id_2() const { return ___id_2; }
	inline String_t** get_address_of_id_2() { return &___id_2; }
	inline void set_id_2(String_t* value)
	{
		___id_2 = value;
		Il2CppCodeGenWriteBarrier(&___id_2, value);
	}

	inline static int32_t get_offset_of_IPadress_3() { return static_cast<int32_t>(offsetof(PCData_t577395949, ___IPadress_3)); }
	inline String_t* get_IPadress_3() const { return ___IPadress_3; }
	inline String_t** get_address_of_IPadress_3() { return &___IPadress_3; }
	inline void set_IPadress_3(String_t* value)
	{
		___IPadress_3 = value;
		Il2CppCodeGenWriteBarrier(&___IPadress_3, value);
	}

	inline static int32_t get_offset_of_panel_4() { return static_cast<int32_t>(offsetof(PCData_t577395949, ___panel_4)); }
	inline GameObject_t1756533147 * get_panel_4() const { return ___panel_4; }
	inline GameObject_t1756533147 ** get_address_of_panel_4() { return &___panel_4; }
	inline void set_panel_4(GameObject_t1756533147 * value)
	{
		___panel_4 = value;
		Il2CppCodeGenWriteBarrier(&___panel_4, value);
	}

	inline static int32_t get_offset_of_ip_5() { return static_cast<int32_t>(offsetof(PCData_t577395949, ___ip_5)); }
	inline Text_t356221433 * get_ip_5() const { return ___ip_5; }
	inline Text_t356221433 ** get_address_of_ip_5() { return &___ip_5; }
	inline void set_ip_5(Text_t356221433 * value)
	{
		___ip_5 = value;
		Il2CppCodeGenWriteBarrier(&___ip_5, value);
	}

	inline static int32_t get_offset_of_servicesRunning_6() { return static_cast<int32_t>(offsetof(PCData_t577395949, ___servicesRunning_6)); }
	inline Text_t356221433 * get_servicesRunning_6() const { return ___servicesRunning_6; }
	inline Text_t356221433 ** get_address_of_servicesRunning_6() { return &___servicesRunning_6; }
	inline void set_servicesRunning_6(Text_t356221433 * value)
	{
		___servicesRunning_6 = value;
		Il2CppCodeGenWriteBarrier(&___servicesRunning_6, value);
	}

	inline static int32_t get_offset_of_control_7() { return static_cast<int32_t>(offsetof(PCData_t577395949, ___control_7)); }
	inline Controller_t1937198888 * get_control_7() const { return ___control_7; }
	inline Controller_t1937198888 ** get_address_of_control_7() { return &___control_7; }
	inline void set_control_7(Controller_t1937198888 * value)
	{
		___control_7 = value;
		Il2CppCodeGenWriteBarrier(&___control_7, value);
	}

	inline static int32_t get_offset_of_services_8() { return static_cast<int32_t>(offsetof(PCData_t577395949, ___services_8)); }
	inline ServiceU5BU5D_t3693819770* get_services_8() const { return ___services_8; }
	inline ServiceU5BU5D_t3693819770** get_address_of_services_8() { return &___services_8; }
	inline void set_services_8(ServiceU5BU5D_t3693819770* value)
	{
		___services_8 = value;
		Il2CppCodeGenWriteBarrier(&___services_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
