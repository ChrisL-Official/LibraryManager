#pragma once
#include <wchar.h>

enum StateCode {
    SUCCESS,
    WRONG,
    NOT_EXIST,
    FATAL
};

/*typedef struct User_Info User, * pUser;
struct User_Info {
    char id[12];
    wchar_t uname[5];
    wchar_t uclass[10];
    pUser pervious;
    pUser next;
};

typedef struct Item_Info Item, *pItem;
struct Item_Info {
    char id[12];
    wchar_t u_name[5];
    wchar_t u_class[10];
    wchar_t b_name[20];
    int days;
    float fine;
    pItem next;
};

typedef struct Item_Info_Pointer PItem, * pPItem;
struct Item_Info_Pointer {
    pItem p;
    pPItem next;
};*/

pNode add_item(pLinkedList list, pNode p);

void delete_item(pLinkedList list, pNode p);

typedef struct UserInfo
{
    char u_id[12];
    wchar_t u_name[5];
    wchar_t u_class[9];
}User, *pUser;

typedef struct PenaltyInfo
{
    wchar_t b_name[15];
    pNode user;
    unsigned short days; //最大支持179年
    float fine;
}Penalty, *pPenalty;

typedef struct PenaltyInfo4IO
{
    wchar_t b_name[15];
    char u_id[12];
    unsigned short days;
    float fine;
}Penalty4IO, *pPenalty4IO;

typedef struct NodeInfo Node, *pNode;
struct NodeInfo {
    union
    {
        User;
        Penalty;
    };
    pNode pervious;
    pNode next;
};

typedef struct LinkedListInfo
{
    pNode head;
    pNode tail;
    int items;
}LinkedList, *pLinkedList;