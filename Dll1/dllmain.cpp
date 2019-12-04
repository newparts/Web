// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

extern "C" __declspec(dllexport)
int este_prim_dll(int n)
{
	for (int i = 2; i * i <= n; i++)
		if (n % i == 0)
			return 0;
	return 1;
}

int ultim_prim_calculat_dll;

extern "C" __declspec(dllexport)
int get_adresa_memorie(void)
{
	return (int)& ultim_prim_calculat_dll;
}

extern "C" __declspec(dllexport)
void start(int start_number)
{

}

extern "C" __declspec(dllexport)
void stop(void)
{

}

