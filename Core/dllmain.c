#include <stdlib.h>
#include <string.h>
#include "dllheader.h"



int login(char* account, char* pwd)
{
    if (strcmp(account, pwd) == 0)
    {
        return SUCCESS;
    }
    return WRONG;
}

