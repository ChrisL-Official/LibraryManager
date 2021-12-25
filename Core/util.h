#pragma once
#include <wchar.h>

enum Login_State {
    SUCCESS,
    WRONG,
    NOT_EXIST,
    NOT_A_NUMBER,
    NEGETIVE_NUM
};

typedef struct User_Info User, * pUser;
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
};