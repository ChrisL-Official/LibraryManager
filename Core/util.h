#pragma once
#include <wchar.h>

bool str_find(const char* str, const char* key, bool is_fuzzy);

bool wstr_find(const wchar_t* str, const wchar_t* key, bool is_fuzzy);

bool is_file_readable(const wchar_t * path);

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
}LinkedList, *pLinkedList;