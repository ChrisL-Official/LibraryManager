#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>
#include "dllheader.h"

bool wstr_is_numberic(const wchar_t* str, int length)
{
    if (!length) return false;
    for (int i = 0; i < length; i++)
    {
        if (str[i] < 0x30 || str[i]>0x39) return false;
    }
    return true;
}