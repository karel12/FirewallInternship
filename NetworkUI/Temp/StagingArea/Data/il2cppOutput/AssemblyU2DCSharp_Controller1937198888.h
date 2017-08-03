#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;
// FireWallData
struct FireWallData_t115724952;
// RuleChecker
struct RuleChecker_t774621429;
// LevelControl
struct LevelControl_t1927737663;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Controller
struct  Controller_t1937198888  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject Controller::currentLeftPanel
	GameObject_t1756533147 * ___currentLeftPanel_2;
	// UnityEngine.GameObject Controller::currentRightPanel
	GameObject_t1756533147 * ___currentRightPanel_3;
	// UnityEngine.GameObject Controller::defaultLeftPanel
	GameObject_t1756533147 * ___defaultLeftPanel_4;
	// UnityEngine.GameObject Controller::defaultRightPanel
	GameObject_t1756533147 * ___defaultRightPanel_5;
	// FireWallData Controller::data
	FireWallData_t115724952 * ___data_6;
	// FireWallData Controller::innerData
	FireWallData_t115724952 * ___innerData_7;
	// FireWallData Controller::outerData
	FireWallData_t115724952 * ___outerData_8;
	// UnityEngine.GameObject Controller::finalScreen
	GameObject_t1756533147 * ___finalScreen_9;
	// RuleChecker Controller::checker
	RuleChecker_t774621429 * ___checker_10;
	// LevelControl Controller::levelControl
	LevelControl_t1927737663 * ___levelControl_11;
	// System.Int32 Controller::levelNumber
	int32_t ___levelNumber_12;
	// System.Boolean Controller::levelComplete
	bool ___levelComplete_13;

public:
	inline static int32_t get_offset_of_currentLeftPanel_2() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___currentLeftPanel_2)); }
	inline GameObject_t1756533147 * get_currentLeftPanel_2() const { return ___currentLeftPanel_2; }
	inline GameObject_t1756533147 ** get_address_of_currentLeftPanel_2() { return &___currentLeftPanel_2; }
	inline void set_currentLeftPanel_2(GameObject_t1756533147 * value)
	{
		___currentLeftPanel_2 = value;
		Il2CppCodeGenWriteBarrier(&___currentLeftPanel_2, value);
	}

	inline static int32_t get_offset_of_currentRightPanel_3() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___currentRightPanel_3)); }
	inline GameObject_t1756533147 * get_currentRightPanel_3() const { return ___currentRightPanel_3; }
	inline GameObject_t1756533147 ** get_address_of_currentRightPanel_3() { return &___currentRightPanel_3; }
	inline void set_currentRightPanel_3(GameObject_t1756533147 * value)
	{
		___currentRightPanel_3 = value;
		Il2CppCodeGenWriteBarrier(&___currentRightPanel_3, value);
	}

	inline static int32_t get_offset_of_defaultLeftPanel_4() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___defaultLeftPanel_4)); }
	inline GameObject_t1756533147 * get_defaultLeftPanel_4() const { return ___defaultLeftPanel_4; }
	inline GameObject_t1756533147 ** get_address_of_defaultLeftPanel_4() { return &___defaultLeftPanel_4; }
	inline void set_defaultLeftPanel_4(GameObject_t1756533147 * value)
	{
		___defaultLeftPanel_4 = value;
		Il2CppCodeGenWriteBarrier(&___defaultLeftPanel_4, value);
	}

	inline static int32_t get_offset_of_defaultRightPanel_5() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___defaultRightPanel_5)); }
	inline GameObject_t1756533147 * get_defaultRightPanel_5() const { return ___defaultRightPanel_5; }
	inline GameObject_t1756533147 ** get_address_of_defaultRightPanel_5() { return &___defaultRightPanel_5; }
	inline void set_defaultRightPanel_5(GameObject_t1756533147 * value)
	{
		___defaultRightPanel_5 = value;
		Il2CppCodeGenWriteBarrier(&___defaultRightPanel_5, value);
	}

	inline static int32_t get_offset_of_data_6() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___data_6)); }
	inline FireWallData_t115724952 * get_data_6() const { return ___data_6; }
	inline FireWallData_t115724952 ** get_address_of_data_6() { return &___data_6; }
	inline void set_data_6(FireWallData_t115724952 * value)
	{
		___data_6 = value;
		Il2CppCodeGenWriteBarrier(&___data_6, value);
	}

	inline static int32_t get_offset_of_innerData_7() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___innerData_7)); }
	inline FireWallData_t115724952 * get_innerData_7() const { return ___innerData_7; }
	inline FireWallData_t115724952 ** get_address_of_innerData_7() { return &___innerData_7; }
	inline void set_innerData_7(FireWallData_t115724952 * value)
	{
		___innerData_7 = value;
		Il2CppCodeGenWriteBarrier(&___innerData_7, value);
	}

	inline static int32_t get_offset_of_outerData_8() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___outerData_8)); }
	inline FireWallData_t115724952 * get_outerData_8() const { return ___outerData_8; }
	inline FireWallData_t115724952 ** get_address_of_outerData_8() { return &___outerData_8; }
	inline void set_outerData_8(FireWallData_t115724952 * value)
	{
		___outerData_8 = value;
		Il2CppCodeGenWriteBarrier(&___outerData_8, value);
	}

	inline static int32_t get_offset_of_finalScreen_9() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___finalScreen_9)); }
	inline GameObject_t1756533147 * get_finalScreen_9() const { return ___finalScreen_9; }
	inline GameObject_t1756533147 ** get_address_of_finalScreen_9() { return &___finalScreen_9; }
	inline void set_finalScreen_9(GameObject_t1756533147 * value)
	{
		___finalScreen_9 = value;
		Il2CppCodeGenWriteBarrier(&___finalScreen_9, value);
	}

	inline static int32_t get_offset_of_checker_10() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___checker_10)); }
	inline RuleChecker_t774621429 * get_checker_10() const { return ___checker_10; }
	inline RuleChecker_t774621429 ** get_address_of_checker_10() { return &___checker_10; }
	inline void set_checker_10(RuleChecker_t774621429 * value)
	{
		___checker_10 = value;
		Il2CppCodeGenWriteBarrier(&___checker_10, value);
	}

	inline static int32_t get_offset_of_levelControl_11() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___levelControl_11)); }
	inline LevelControl_t1927737663 * get_levelControl_11() const { return ___levelControl_11; }
	inline LevelControl_t1927737663 ** get_address_of_levelControl_11() { return &___levelControl_11; }
	inline void set_levelControl_11(LevelControl_t1927737663 * value)
	{
		___levelControl_11 = value;
		Il2CppCodeGenWriteBarrier(&___levelControl_11, value);
	}

	inline static int32_t get_offset_of_levelNumber_12() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___levelNumber_12)); }
	inline int32_t get_levelNumber_12() const { return ___levelNumber_12; }
	inline int32_t* get_address_of_levelNumber_12() { return &___levelNumber_12; }
	inline void set_levelNumber_12(int32_t value)
	{
		___levelNumber_12 = value;
	}

	inline static int32_t get_offset_of_levelComplete_13() { return static_cast<int32_t>(offsetof(Controller_t1937198888, ___levelComplete_13)); }
	inline bool get_levelComplete_13() const { return ___levelComplete_13; }
	inline bool* get_address_of_levelComplete_13() { return &___levelComplete_13; }
	inline void set_levelComplete_13(bool value)
	{
		___levelComplete_13 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
