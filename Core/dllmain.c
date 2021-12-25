#include <stdlib.h>
#include <string.h>
#include <memory.h>
#include <wchar.h>
#include "dllheader.h"
#include "util.h"

pItem list_item = NULL; //总表 
pPItem list_working = NULL; //工作表

pUser list_user = NULL;

int init()
{
    add_user("0", L"[不存在]", L"[不存在]");
}

int login(const char* account, const char* pwd)
{
    if (!strcmp(account, "admin"))
    {
        if (!strcmp(account, pwd))
        {
            return SUCCESS;
        }
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
    p->days = days;
    p->fine = 0;
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

void delete_item(const pItem p)
{
    pItem p_last, p_now;
    p_last = list_item;
    if (p_last == NULL)
        return;
    p_now = p_last->next;
    if (p_last==p)
    {
        list_item = p_now;
        free(p);
        return;
    }
    while (p_now)
    {
        if (p_now==p)
        {
            p_last->next = p_now->next;
            free(p);
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

pUser get_all_users()
{
    return list_user;
}

pPItem get_need_items()
{
    return list_working;
}

pUser add_user(const char* id, const wchar_t* uname, const wchar_t* uclass)
{
    pUser p = (pUser)malloc(sizeof(User));
    if (!p) return NULL;
    strcpy(p->id, id);
    wcscpy(p->uname, uname);
    wcscpy(p->uclass, uclass);
    p->next = NULL;
    if (list_user)
    {
        pUser p1 = list_user;
        while (p1->next)
        {
            p1 = p1->next;
        }
        p1->next = p;
        p->pervious = p1;
    }
    else
    {
        p->pervious = NULL;
        list_user = p;
    }
    return p;
}

pUser change_user(pUser p, const char* id, const wchar_t* uname, const wchar_t* uclass)
{
    if (!p) return NULL;
    strcpy(p->id, id);
    wcscpy(p->uname, uname);
    wcscpy(p->uclass, uclass);
    return p;
}

pUser delete_user(pUser p)
{
    if (p->pervious)
    {
        p->pervious->next = p->next;
    }
    else
    {
        list_user = p->next;
    }
    if(p->next) p->next->pervious = p->pervious;
    free(p);
}