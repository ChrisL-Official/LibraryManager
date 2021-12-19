#include <stdlib.h>
#include <string.h>
#include <memory.h>
#include <wchar.h>
#include "dllheader.h"
#include "util.h"

pItem list_item = NULL; //总表
pPItem list_working = NULL; //工作表

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

//添加
pItem add_item(const char* id, const wchar_t* u_name, const wchar_t* u_class, const wchar_t* b_name,int days)
{
    pItem p = (pItem)malloc(sizeof(Item));
    if (!p) return NULL;
    strcpy(p->id, id);
    wcscpy(p->u_name, u_name);
    wcscpy(p->u_class, u_class);
    wcscpy(p->b_name, b_name);
    p->next = NULL;
    if (list_item)
    {
        pItem p1 = list_item;
        while (p1->next)
        {
            p1 = p1->next;
        }
        p1->next = p;
    }
    else
    {
        list_item = p;
    }
    return p;
}

pItem change_item(pItem p,const char* id, const wchar_t* u_name, const wchar_t* u_class, const wchar_t* b_name, int days)
{
    if (!p) return NULL;
    strcpy(p->id, id);
    wcscpy(p->u_name, u_name);
    wcscpy(p->u_class, u_class);
    wcscpy(p->b_name, b_name);
    return p;
}

void delete_item(pItem p)
{
    pItem p_last, p_now;
    p_last = list_item;
    if (p_last == NULL)
        return;
    p_now = p_last->next;
    if (p_last==p)
    {
        list_item = p_now;
        return;
    }
    while (p_now)
    {
        if (p_now==p)
        {
            p_last->next = p_now->next;
            return;
        }
        p_last = p_now;
        p_now = p_last->next;
    }
}


pItem get_all_items()
{
    return list_item;
}

pPItem get_need_items()
{
    return list_working;
}