#pragma once
#include <wchar.h>

//枚举
enum State_Code {
    SUCCESS,
    WRONG,
    NOT_EXIST,
    UNREADLE,
    UNWRITEABLE,
    UNREALLOCABLE
};

//用户结构体
typedef struct Account_Info User, * pUser;
struct Account_Info {
    char id[10];
    wchar_t name[5];
    wchar_t class[10];
    char pwd[21];
    pUser next;
};

//书本结构体
typedef struct Book_Info Book, * pBook;
struct Book_Info {
    int id;
    char isbn[13];
    wchar_t name[20];
    pBook next;
};

//超时条目结构体
typedef struct Item_Info Item, * pItem;
struct Item_Info {
    pUser user;
    pBook book;
    int date;
    float u_prise;  //单价
    pItem next;
};
