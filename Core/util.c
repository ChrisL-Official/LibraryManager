#include <stdbool.h>
#include "util.h"
#include "dllheader.h"

bool str_is_numberic(const wchar_t* str, int length)
{
    if (!length) return false;
    for (int i = 0; i < length; i++)
    {
        //0x30ÊÇ0 0x39ÊÇ9
        if (str[i] < 0x30 || str[i]>0x39) return false;
    }
    return true;
}