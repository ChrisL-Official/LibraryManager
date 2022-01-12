#pragma once
#include <wchar.h>

//char查找
bool str_find(const char* str, const char* key, bool is_fuzzy);
//wchar_t查找
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

//搜索结构体：保存搜索信息、搜索类型和是否模糊搜索
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

//图书结构体：保存UID、名称、班级和学号
typedef struct UserInfo
{
    int uid;
    char u_id[12];
    wchar_t u_name[6];
    wchar_t u_class[10];
}User, * pUser;

//图书结构体：保存UID、名称和编号
typedef struct BookInfo
{
    int uid;
    char b_id[4];
    wchar_t b_name[16];
}Book, * pBook;

//超期记录结构体：图书和用户的结构体指针、天数和罚金
typedef struct PenaltyInfo
{
    pUser user;
    pBook book;
    unsigned short days;
    float fine;
}Penalty, * pPenalty;

//读写专用超期记录结构体：图书和用户的UID、天数和罚金
typedef struct PenaltyInfo4IO
{
    int uid_book;
    int uid_user;
    unsigned short days;
    float fine;
}Penalty4IO, * pPenalty4IO;

//节点结构体：保存数据指针，上一节点和下一节点指针
typedef struct NodeInfo Node, * pNode;
struct NodeInfo {
    void* p;
    pNode pervious;
    pNode next;
};

//链表结构体：保存头结点指针和尾结点指针
typedef struct LinkedListInfo
{
    pNode head;
    pNode tail;
}LinkedList, * pLinkedList;