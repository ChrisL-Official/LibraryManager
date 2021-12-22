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