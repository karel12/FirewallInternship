#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// FRule
struct  FRule_t2769729188  : public Il2CppObject
{
public:
	// System.String FRule::chain
	String_t* ___chain_0;
	// System.String FRule::ip
	String_t* ___ip_1;
	// System.Int32 FRule::port
	int32_t ___port_2;
	// System.String FRule::policy
	String_t* ___policy_3;
	// System.Int32 FRule::number
	int32_t ___number_4;

public:
	inline static int32_t get_offset_of_chain_0() { return static_cast<int32_t>(offsetof(FRule_t2769729188, ___chain_0)); }
	inline String_t* get_chain_0() const { return ___chain_0; }
	inline String_t** get_address_of_chain_0() { return &___chain_0; }
	inline void set_chain_0(String_t* value)
	{
		___chain_0 = value;
		Il2CppCodeGenWriteBarrier(&___chain_0, value);
	}

	inline static int32_t get_offset_of_ip_1() { return static_cast<int32_t>(offsetof(FRule_t2769729188, ___ip_1)); }
	inline String_t* get_ip_1() const { return ___ip_1; }
	inline String_t** get_address_of_ip_1() { return &___ip_1; }
	inline void set_ip_1(String_t* value)
	{
		___ip_1 = value;
		Il2CppCodeGenWriteBarrier(&___ip_1, value);
	}

	inline static int32_t get_offset_of_port_2() { return static_cast<int32_t>(offsetof(FRule_t2769729188, ___port_2)); }
	inline int32_t get_port_2() const { return ___port_2; }
	inline int32_t* get_address_of_port_2() { return &___port_2; }
	inline void set_port_2(int32_t value)
	{
		___port_2 = value;
	}

	inline static int32_t get_offset_of_policy_3() { return static_cast<int32_t>(offsetof(FRule_t2769729188, ___policy_3)); }
	inline String_t* get_policy_3() const { return ___policy_3; }
	inline String_t** get_address_of_policy_3() { return &___policy_3; }
	inline void set_policy_3(String_t* value)
	{
		___policy_3 = value;
		Il2CppCodeGenWriteBarrier(&___policy_3, value);
	}

	inline static int32_t get_offset_of_number_4() { return static_cast<int32_t>(offsetof(FRule_t2769729188, ___number_4)); }
	inline int32_t get_number_4() const { return ___number_4; }
	inline int32_t* get_address_of_number_4() { return &___number_4; }
	inline void set_number_4(int32_t value)
	{
		___number_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
