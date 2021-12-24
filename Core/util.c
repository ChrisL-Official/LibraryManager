#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>
#include "dllheader.h"

bool wstr_is_pure_numberic(const wchar_t* str)
{
    wchar_t* p = str;
    if (!*p) return false;
    while (*p)
    {
        if (*p < 0x30 || *p > 0x39) return false;
        p++;
    }
    return true;
}

bool wstr_is_id(const wchar_t* str)
{
    wchar_t* p = str;
    wchar_t c;
    if (!*p) return false;
    while (c = *p++)
    {
        if (c >= 0x30 && c <= 0x39) continue; //0-9
        if (c >= 0x41 && c <= 0x5A) continue; //A-Z
        //if (c >= 0x61 && c <= 0x7A) continue; //a-z
        return false;
    }
    return true;
}