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

const char* Path_Penalty = "penalty.data";
const char* Path_Book = "book.data";
const char* Path_User = "user.data";

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
}

int load_list()
{
    int i = check_file(Path_User);
    if (i) return i;
    FILE* f = fopen(Path_User, 'r');
    while (!feof(f))
    {
        pUser user = (pUser)malloc(sizeof(User));
        memset(user, 0, sizeof(User));
        if (fscanf(f, "%d\t%s\t%s\t%s\n", &(user->uid), user->u_id, user->u_name, user->u_class) != EOF)
            add_item(&list_user, user);
        else
            free(user);
    }
    fclose(f);

    i = check_file(Path_Book);
    if (i) return i;
    f = fopen(Path_Book, 'r');
    while (!feof(f))
    {
        pBook book = (pBook)malloc(sizeof(Book));
        memset(book, 0, sizeof(Book));
        if (fscanf(f, "%d\t%[^\t]\t%s\n", &(book->uid), book->b_name, book->b_id) != EOF)
            add_item(&list_book, book);
        else
            free(book);
    }
    fclose(f);

    i = check_file(Path_Penalty);
    if (i) return i;
    f = fopen(Path_Penalty, 'r');
    while (!feof(f))
    {
        pPenalty4IO penalty = (pPenalty4IO)malloc(sizeof(Penalty4IO));
        if (fscanf(f, "%d\t%d\t%d\n", &(penalty->uid_user), &(penalty->uid_book), &(penalty->uid_user)) != EOF)
            ;
        else
            free(penalty);
    }
    fclose(f);
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
                if (fabs(penalty->days-s->f)>1e-6)
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
        return strcmp(((pUser)v1)->u_id, ((pUser)v2)->u_id);
    if (type == USER_NAME)
        return wcscmp(((pUser)v1)->u_name, ((pUser)v2)->u_name);
    if (type == USER_CLASS)
        return wcscmp(((pUser)v1)->u_class, ((pUser)v2)->u_class);
    if (type == BOOK_ID)
        return strcmp(((pBook)v1)->b_id, ((pBook)v2)->b_id);
    if (type == BOOK_NAME)
        return wcscmp(((pBook)v1)->b_name, ((pBook)v2)->b_name);
    if (type == DAYS)
        return ((pPenalty)v1)->days > ((pPenalty)v2)->days;
    if (type == FINE)
        return ((pPenalty)v1)->fine > ((pPenalty)v2)->fine;
}

void sort(pLinkedList list, int type, bool is_positive)
{
    bool swapped;
    pNode ptr1;
    pNode lptr = NULL;
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
    do
    {
        swapped = false;
        ptr1 = list->head->next;

        while (ptr1->next != lptr)
        {
            if (compare(ptr1, ptr1->next, type, p) && is_positive)
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