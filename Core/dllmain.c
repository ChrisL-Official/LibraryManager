#include <stdlib.h>
#include <string.h>
#include <memory.h>
#include <wchar.h>
#include "dllheader.h"
#include "util.h"

//pItem list_item = NULL; //总表 
//pPItem list_working = NULL; //工作表

//pUser list_user = NULL;

//pNode list_penalty = NULL;
//pNode list_penalty_last = NULL;

//pNode list_user = NULL;
//pNode list_user_last = NULL;

LinkedList list_penalty = { NULL,NULL,0 };
LinkedList list_user = { NULL,NULL,0 };

int init()
{
    //每个链表的头都是预留的错误项
    const wchar_t* error = L"[错误]";
    add_user("?", error, error);
    add_penalty(error, 0);
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

pNode add_user(const char* u_id, const wchar_t* u_name, const wchar_t* u_class)
{
    pNode p = (pNode)malloc(sizeof(Node));
    if (!p) return NULL;
    memset(p, 0, sizeof(Node));
    strcpy(p->u_id, u_id);
    wcscpy(p->u_name, u_name);
    wcscpy(p->u_class, u_class);
    add_item(&list_user, p);
}

pNode add_penalty(const wchar_t* b_name,unsigned short days)
{
    pNode p = (pNode)malloc(sizeof(Node));
    if (!p) return NULL;
    memset(p, 0, sizeof(Node));
    wcscpy(p->b_name, b_name);
    p->days = days;
    p->fine = 2.0;
    add_item(&list_penalty, p);
}

void edit_user(pNode p, const char* u_id, const wchar_t* u_name, const wchar_t* u_class)
{
    if (!p) return;
    strcpy(p->u_id, u_id);
    wcscpy(p->u_name, u_name);
    wcscpy(p->u_class, u_class);
}

void edit_penalty(pNode p, const wchar_t* b_name, unsigned short days)
{
    if (!p) return;
    memset(p, 0, sizeof(Node));
    wcscpy(p->b_name, b_name);
    p->days = days;
    p->fine = 2.0;
}

pLinkedList get_user_list()
{
    return &list_user;
}

pLinkedList get_penalty_list()
{
    return &list_penalty;
}