// cpp-proj2-dll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

extern "C" _declspec(dllexport) int SumTwo(int var_x, int var_y)
{
	return var_x + var_y;
}

extern "C" _declspec(dllexport) int test1()
{
	return 5;
}

extern "C" _declspec(dllexport) char test2()
{
	return 'A';
}



