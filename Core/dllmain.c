#include <stdlib.h>
#include <string.h>
#include <memory.h>
#include <wchar.h>
#include <stdio.h>
#include <io.h>
#include "dllheader.h"
#include "util.h"

LinkedList list_penalty = { NULL, NULL};
LinkedList list_user = { NULL, NULL};
LinkedList list_book = { NULL, NULL};
LinkedList list_search = { NULL, NULL};

const char* Path_Penalty = "penalty.dat";
const char* Path_Book = "book.dat";
const char* Path_User = "user.dat";

const wchar_t* Format_Book_Read = L"%d\t%ls\t%l[^\t]\t\n"; //uid,id,名称
const wchar_t* Format_Book_Write = L"%d\t%ls\t%ls\t\n";
const wchar_t* Format_User_Read = L"%d\t%ls\t%l[^\t]\t%l[^\t]\t\n"; //uid,id,姓名,班级
const wchar_t* Format_User_Write = L"%d\t%ls\t%ls\t%ls\t\n";
const char* Format_Penalty = "%d\t%d\t%d\t\n"; //uid,uid,天数

int init()
{
    //每个链表的头都是预留的错误项
    const wchar_t* error = L"[失效]";
    add_user(0,"?", error, error);
    add_book(0, error, "?");
    pPenalty p = (pPenalty)malloc(sizeof(Penalty));
    if (!p)
        return MEMORY_FULL;
    memset(p, 0, sizeof(Penalty));
    p->user = list_user.head->p;
    p->book = list_book.head->p;
    p->days = 2;
    add_item(&list_penalty, p);
    load_list();
}

int write_list()
{
    FILE* f = fopen(Path_User, "wb+");
    if (f) 
    {
        pNode p = list_user.head->next;
        while (p)
        {
            pUser user = p->p;
            wchar_t id[12];
            mbstowcs(id, user->u_id, 12);
            fwprintf(f, Format_User_Write, user->uid, id, user->u_name, user->u_class);
            p = p->next;
        }
        fclose(f);
    }
    f = fopen(Path_Book, "wb+");
    if (f)
    {
        pNode p = list_book.head->next;
        while (p)
        {
            pBook book = p->p;
            wchar_t id[4];
            mbstowcs(id, book->b_id, 4);
            fwprintf(f, Format_Book_Write, book->uid, id, book->b_name);
            p = p->next;
        }
        fclose(f);
    }
    f = fopen(Path_Penalty, "w+");
    if (f)
    {
        pNode p = list_penalty.head->next;
        while (p)
        {
            pPenalty penalty = p->p;
            pBook book = penalty->book;
            pUser user = penalty->user;
            fprintf(f, Format_Penalty,book->uid,user->uid,penalty->days);
            p = p->next;
        }
        fclose(f);
    }
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

/*
    用户可用性检查(完整检查，不适用于用户添加)
    SAME:未更改(如*book存在)
    SUCCESS:存在
    NOT_EXIST:不存在
    如*user不为null,且现有值与*user冲突但找到合法项,会修改形参*user所指向的指针
*/
int check_user(pUser *user, const char* u_id, const wchar_t* u_name, const wchar_t* u_class)
{
    pUser temp = *user;
    if (!strcmp(temp->u_id, u_id) &&
        !wcscmp(temp->u_class, u_class) &&
        !wcscmp(temp->u_name, u_name))
        return SAME;
    pNode p = list_user.head;
    while (p)
    {
        temp = p->p;
        if (!strcmp(temp->u_id, u_id) &&
            !wcscmp(temp->u_class, u_class) &&
            !wcscmp(temp->u_name, u_name))
        {
            if (user)
                *user = temp;
            return SUCCESS;
        }
        p = p->next;
    }
    return NOT_EXIST;
}

/*
    图书可用性检查(完整检查，不适用于图书添加)
    SAME:未更改(如*book存在)
    SUCCESS:存在
    NOT_EXIST:不存在
    如*book不为null,且现有值与*book冲突但找到合法项,会修改形参*book所指向的指针
*/
int check_book(pBook* book, const wchar_t* b_name, const char* b_id)
{
    pBook temp = *book;
    if (!wcscmp(temp->b_name, b_name) && !strcmp(temp->b_id, b_id))
        return SAME;
    pNode p = list_book.head;
    while (p)
    {
        temp = p->p;
        if (!wcscmp(temp->b_name, b_name) && !strcmp(temp->b_id, b_id))
        {
            if (book)
                *book = temp;
            return SUCCESS;
        }
        p = p->next;
    }
    return NOT_EXIST;
}

pNode get_users()
{
    return list_user.head->next;
}

pNode get_penaltys()
{
    return list_penalty.head->next;
}

pNode get_books()
{
    return list_book.head->next;
}

pLinkedList get_user_list()
{
    return &list_user;
}

pLinkedList get_penalty_list()
{
    return &list_penalty;
}

pLinkedList get_book_list()
{
    return &list_book;
}

pLinkedList get_search_list()
{
    return &list_search;
}

int add_penalty_from_io(pPenalty4IO p)
{
    pNode p1 = list_user.head->next;
    pPenalty p3 = (pPenalty)malloc(sizeof(Penalty));
    while (p1)
    {
        pUser p2 = p1->p;
        if (p2->uid == p->uid_user)
        {
            p3->user = p2;
            goto next1;
        }
        p1 = p1->next;
    }
    p3->user = list_user.head;
next1:
    p1 = list_book.head->next;
    while (p1)
    {
        pBook p2 = p1->p;
        if (p2->uid == p->uid_book)
        {
            p3->book = p2;
            goto next2;
        }
        p1 = p1->next;
    }
    p3->book = list_book.head;
next2:
    p3->days = p->days;
    p3->fine = p->days * 0.2;
    add_item(&list_penalty, p3);
}

//添加超期记录
int add_penalty(pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days)
{
    pPenalty penalty = (pPenalty)malloc(sizeof(Penalty));
    if (!penalty)
        return MEMORY_FULL;
    int i = edit_penalty(penalty, user, book, b_name, b_id, u_id, u_name, u_class, days);
    if (i != SUCCESS) {
        free(penalty);
        return i;
    }
    if (add_item(&list_penalty, penalty))
        return SUCCESS;
    return MEMORY_FULL;

}

//修改超期记录
int edit_penalty(pPenalty penalty, pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days)
{
    if (!penalty) return;
    pUser* pu = &(list_user.head->p);
    pBook* pb = &(list_book.head->p);
    if (user)
        pu = &user;
    if (book)
        pb = &book;
    int i = check_user(pu, u_id, u_name, u_class);
    if (i != SUCCESS && i != SAME) 
        return i;
    i = check_book(pb, b_name, b_id);
    if (i != SUCCESS && i != SAME)
        return i;
    //不可能是NULL指针
    penalty->user = *pu;
    penalty->book = *pb;
    penalty->days = days;
    penalty->fine = 0.2 * days;
    return SUCCESS; 
}

void fresh_penalty_list()
{
    pNode p1 = list_penalty.head;
    pNode p2;
    while (p1)
    {
        pPenalty temp = p1->p;
        p2 = list_user.head;
        while (p2 = p2->next) {
            if (p2->p == temp->user)
                goto next;
        }
        temp->user = list_user.head->p;
    next:
        p2 = list_book.head;
        while (p2 = p2->next) {
            if (p2->p == temp->book)
                goto final;
        }
        temp->book = list_book.head->p;
    final:
        p1 = p1->next;
    }
}

int add_search_str(char* str, int type, bool is_fuzzy)
{
    return add_search(str, type, is_fuzzy);
}

int add_search_i(wchar_t* wstr, int type)
{
    int i = _wtoi(wstr);
    return add_search(&i, type, false);
}

int add_search_f(wchar_t* wstr, int type)
{
    float f = _wtof(wstr);
    return add_search(&f, type, false);
}

int add_search(void* data, int type, bool is_fuzzy)
{
    pSearch search = (pSearch)malloc(sizeof(Search));
    if (!search)
        return MEMORY_FULL;
    memset(search, 0, sizeof(Search));
    search->type = type;
    search->is_fuzzy = is_fuzzy;
    switch (type)
    {
        case USER_ID:
        case BOOK_ID:
            strcpy(search->str, data);
            break;
        case BOOK_NAME:
        case USER_NAME:
        case USER_CLASS:
            wcscpy(search->wstr, data);
            break;
        case DAYS:
            search->i = *(int*)data;
            break;
        case FINE:
            search->f = *(float*)data;
            break;
    }
    add_item(&list_search,search);
}

//添加用户
int add_user(int uid, const char* u_id, const wchar_t* u_name, const wchar_t* u_class)
{
    pUser user = (pUser)malloc(sizeof(User));
    if (!user)
        return MEMORY_FULL;
    memset(user, 0, sizeof(User));
    if (edit_user(user, u_id, u_name, u_class))
    {
        free(user);
        return CONFLICT;
    }
    user->uid = uid;
    if (add_item(&list_user, user))
        return SUCCESS;
    return MEMORY_FULL;
}

//修改用户(只不允许学号相同)
int edit_user(pUser user, const char* u_id, const wchar_t* u_name, const wchar_t* u_class)
{
    if (!user) return;
    pNode p = list_user.head;
    pUser p1;
    while (p)
    {
        p1 = p->p;
        if (!strcmp(p1->u_id, u_id) && user != p1)
            return CONFLICT;
        p = p->next;
    }
    strcpy(user->u_id, u_id);
    wcscpy(user->u_name, u_name);
    wcscpy(user->u_class, u_class);
    //write_list();
    return SUCCESS;
}

//添加图书
int add_book(int uid, const wchar_t* b_name, const char* b_id)
{
    pBook book = (pBook)malloc(sizeof(Book));
    if (!book) 
        return MEMORY_FULL;
    memset(book, 0, sizeof(Book));
    if (edit_book(book, b_name, b_id))
    {
        free(book);
        return CONFLICT;
    }
    book->uid = uid;
    if (add_item(&list_book, book))
        return SUCCESS;
    return MEMORY_FULL;
}

//修改图书
int edit_book(pBook book, const wchar_t* b_name, const char* b_id)
{
    pNode p = list_book.head;
    pBook p1;
    while (p)
    {
        p1 = p->p;
        if ((!strcmp(p1->b_id, b_id)||!wcscmp(p1->b_name, b_name)) && book != p1)
            return CONFLICT;
        p = p->next;
    }
    strcpy(book->b_id, b_id);
    wcscpy(book->b_name, b_name);
    return SUCCESS;
}

pUser get_penalty_user(pNode p)
{
    return ((pPenalty)p->p)->user;
}

pBook get_penalty_book(pNode p)
{
    return ((pPenalty)p->p)->book;
}

pPenalty get_penalty(pNode p)
{
    return (pPenalty)p->p;
}

pLinkedList search(pLinkedList source, pLinkedList search/*, void* (*get_info)(pNode)*/)
{
    if (!search->head)
        return;
    pLinkedList des = (pLinkedList)malloc(sizeof(LinkedList));
    if (!des)
        return NULL;
    memset(des, 0, sizeof(LinkedList));
    pNode p = source->head->next;
    while (p)
    {
        pNode p1 = search->head;
        pPenalty penalty = p->p;
        pUser user = penalty->user;
        pBook book = penalty->book;
        /*if (get_info == NULL)
            p2 = p1->p; 
        else
            p2 = get_info(p1);*/
        //bool add = false;
        while (p1)
        {
            pSearch s = p1->p;
            if (s->type == USER_ID)
            {
                if (!str_find(user->u_id, s->str, s->is_fuzzy))
                    goto big_continue;
            }
            if (s->type == USER_NAME)
            {
                if (!wstr_find(user->u_name, s->wstr, s->is_fuzzy))
                    goto big_continue;
            }
            if (s->type == USER_CLASS)
            {
                if (!wstr_find(user->u_class, s->wstr, s->is_fuzzy))
                    goto big_continue;
            }
            if (s->type == BOOK_ID)
            {
                if (!str_find(book->b_id, s->str, s->is_fuzzy))
                    goto big_continue;
            }
            if (s->type == BOOK_NAME)
            {
                if (!wstr_find(book->b_name, s->wstr, s->is_fuzzy))
                    goto big_continue;
            }
            if (s->type == DAYS)
            {
                if (penalty->days!=s->i)
                    goto big_continue;
            }
            if (s->type == FINE)
            {
                if (fabs(penalty->fine-s->f)>1e-6)
                    goto big_continue;
            }
            p1 = p1->next;
        }
        add_item(des, p->p);
    big_continue:
        p = p->next;
    }
    return des;
}

bool compare(pNode p1, pNode p2, int type, void* (*get_info)(pNode))
{
    void *v1, *v2;
    v1 = get_info(p1);
    v2 = get_info(p2);
    if (type == USER_ID)
        return strcmp(((pUser)v1)->u_id, ((pUser)v2)->u_id)>0;
    if (type == USER_NAME)
        return wcscmp(((pUser)v1)->u_name, ((pUser)v2)->u_name)>0;
    if (type == USER_CLASS)
        return wcscmp(((pUser)v1)->u_class, ((pUser)v2)->u_class)>0;
    if (type == BOOK_ID)
        return strcmp(((pBook)v1)->b_id, ((pBook)v2)->b_id)>0;
    if (type == BOOK_NAME)
        return wcscmp(((pBook)v1)->b_name, ((pBook)v2)->b_name)>0;
    if (type == DAYS)
        return ((pPenalty)v1)->days > ((pPenalty)v2)->days;
    if (type == FINE)
        return ((pPenalty)v1)->fine > ((pPenalty)v2)->fine;
}

void sort(pLinkedList list, int type, bool is_positive, void* (*p)(void*))
{
    if (list->head->next == NULL)
        return;
    bool swapped;
    pNode ptr1;
    pNode lptr = NULL;
    do
    {
        swapped = false;
        ptr1 = list->head->next;
        while (ptr1->next != lptr)
        {
            bool b = compare(ptr1, ptr1->next, type, p);
            if ((b&&is_positive)||(!b&&!is_positive))
            {
                void* tmp = ptr1->p;
                ptr1->p = ptr1->next->p;
                ptr1->next->p = tmp;
                swapped = true;
            }
            ptr1 = ptr1->next;
        }
        lptr = ptr1;
    } while (swapped);
}

void sort_penalty(pLinkedList list, int type, bool is_positive)
{
    void*(*p)(void*) ;
    if (list->head->next == NULL)
        return;
    switch (type)
    {
    case USER_ID:
    case USER_NAME:
    case USER_CLASS:
        p = get_penalty_user;
        break;
    case BOOK_ID:
    case BOOK_NAME:
        p = get_penalty_book;
        break;
    default:
        p = get_penalty;
    }
    sort(list, type,is_positive,p);
}

void delete_item_from_searching(pLinkedList source, void* info)
{
    pNode p = source->head;
    while (p)
    {
        if (p->p == info)
        {
            delete_item(source, p, true);
            break;
        }
        p = p->next;
    }
}

int load_list()
{
    FILE* f;
    wchar_t str[12] = { 0 };
    if (is_file_readable(Path_User))
    {
        f = fopen(Path_User, "rb");
        while (!feof(f))
        {
            pUser user = (pUser)malloc(sizeof(User));
            if (!user)
                return MEMORY_FULL;
            memset(user, 0, sizeof(User));
            int i = fwscanf(f, Format_User_Read, &user->uid, str, user->u_name, user->u_class);

            wcstombs(user->u_id, str, 12);
            add_item(&list_user, user);
            //memset(str, 0, 12 * sizeof(wchar_t));
        }
        fclose(f);
    }
    if (is_file_readable(Path_Book))
    {
        f = fopen(Path_Book, "rb");
        while (!feof(f))
        {
            pBook book = (pBook)malloc(sizeof(Book));
            if (!book)
                return MEMORY_FULL;
            memset(book, 0, sizeof(Book));
            fwscanf(f, Format_Book_Read, &book->uid, str, book->b_name);
            wcstombs(book->b_id, str, 4);
            add_item(&list_book, book);
            //memset(str, 0, 12 * sizeof(wchar_t));
        }
        fclose(f);
    }
    pPenalty4IO penalty = (pPenalty4IO)malloc(sizeof(Penalty4IO));
    if (is_file_readable(Path_Penalty))
    {
        f = fopen(Path_Penalty, "r");
        while (!feof(f))
        {
            fscanf(f, Format_Penalty, &penalty->uid_book, &penalty->uid_user, &penalty->days);
            add_penalty_from_io(penalty);
        }
        fclose(f);
    }
}

float statistic(pLinkedList list)
{
    float ans = 0;
    pNode p = list->head;
    while (p)
    {
        ans += ((pPenalty)(p->p))->fine;
        p = p->next;
    }
    return ans;
}