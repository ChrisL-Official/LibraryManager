#pragma once
#include <wchar.h>

//ö��
enum State_Code {
    SUCCESS,
    WRONG,
    NOT_EXIST,
    UNREADLE,
    UNWRITEABLE,
    UNREALLOCABLE
};

//�û��ṹ��
typedef struct Account_Info User, * pUser;
struct Account_Info {
    char id[10];
    wchar_t name[5];
    wchar_t class[10];
    char pwd[21];
    pUser next;
};

//�鱾�ṹ��
typedef struct Book_Info Book, * pBook;
struct Book_Info {
    int id;
    char isbn[13];
    wchar_t name[20];
    pBook next;
};

//��ʱ��Ŀ�ṹ��
typedef struct Item_Info Item, * pItem;
struct Item_Info {
    pUser user;
    pBook book;
    int date;
    float u_prise;  //����
    pItem next;
};
