#pragma once
#include <wchar.h>

const char* Path_Penalty = "penalty.data";
const char* Path_Book = "book.data";
const char* Path_User = "user.data";

int check_file(const char* path);

bool str_find(const char* str, const char* key, bool is_fuzzy);

bool wstr_find(const wchar_t* str, const wchar_t* key, bool is_fuzzy);

enum StateCode 
{
    SUCCESS,
    WRONG,
    NOT_EXIST,
    CHANGED,
    SAME,
    UNREADABLE,
    UNWRITABLE,
    UNFORMATTABLE,
    MEMORY_FULL,
    CONFLICT,
    FATAL,
};

enum ItemType 
{
    USER_ID,
    USER_NAME,
    USER_CLASS,
    BOOK_NAME,
    BOOK_ID,
    DAYS,
    FINE,
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


typedef struct SearchInfo
{
    union {
        wchar_t wstr[16];
        char str[12];
        int i;
        float f;
    };
    int type;
    bool is_fuzzy;
}Search, * pSearch;

//需4字节对齐
typedef struct UserInfo
{
    int uid;
    char u_id[12];
    wchar_t u_name[6];
    wchar_t u_class[10];
}User, * pUser;

typedef struct BookInfo
{
    int uid;
    char b_id[4];
    wchar_t b_name[16];
}Book, * pBook;

//需4字节对齐
/*typedef struct PenaltyInfo
{
    wchar_t b_name[15];
    char b_id[4];
    pNode user;
    unsigned short days; //最大支持179年
    float fine;
}Penalty, * pPenalty;*/

typedef struct PenaltyInfo
{
    pUser user;
    pBook book;
    unsigned short days; //最大支持179年
    float fine;
}Penalty, * pPenalty;

typedef struct PenaltyInfo4IO
{
    int uid_book;
    int uid_user;
    unsigned short days;
    float fine;
}Penalty4IO, *pPenalty4IO;

typedef struct NodeInfo Node, *pNode;
struct NodeInfo {
    void* p;
    pNode pervious;
    pNode next;
};

typedef struct LinkedListInfo
{
    pNode head;
    pNode tail;
    int items;
}LinkedList, *pLinkedList;