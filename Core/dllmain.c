#include <stdlib.h>
#include <string.h>
#include <memory.h>
#include <wchar.h>
#include "dllheader.h"
#include "util.h"

pBook list_book;
pUser list_user;
pItem list_item;

int init()
{
    
}

int login(const wchar_t* account, const wchar_t* pwd)
{
    if (strcmp(account, pwd) == 0)
    {
        return SUCCESS;
    }
    return WRONG;
}

bool str_is_numberic(const wchar_t* str, int length)
{
    if (!length) return false;
    for (int i = 0; i < length; i++)
    {
        //0x30是0 0x39是9
        if (str[i] < 0x30 || str[i]>0x39) return false;
    }
    return true;
}

//添加学生
pUser add_user(const char* id, const wchar_t* name, const wchar_t* class)
{
    pUser p = (pUser)malloc(sizeof(User));
    if (!p) return NULL;
    strcpy(p->id, id);
    wcscpy(p->name, name);
    wcscpy(p->class, class);
    p->next = NULL;
    if (list_user) 
    {
        pUser p1 = list_user;
        while (p1->next)
        {
            p1 = p1->next;
        }
        p1->next = p;
    }
    else
    {
        list_user = p;
    }
    return p;
}

pUser get_user()
{

}


pUser get_next_user(pUser p)
{
    return p->next;
}

