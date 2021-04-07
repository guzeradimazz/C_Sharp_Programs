#pragma once

#ifdef MATHDLL_EXPORTS
#define DLLIMPORT_EXPORT __declspec(dllexport)
#else
#define DLLIMPORT_EXPORT __declspec(dllimport)
#endif

extern "C" {
    DLLIMPORT_EXPORT int _stdcall Sum(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Subtract(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Multiply(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Divide(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Mod(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Gcd(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Min(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Max(int a, int b);
    DLLIMPORT_EXPORT int _stdcall Abs(int a);
    DLLIMPORT_EXPORT int _cdecl Pow(int a, int power);
}
