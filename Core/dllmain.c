#include <stdlib.h>
#include <string.h>
#include <memory.h>
#include <wchar.h>
#include <stdio.h>
#include <io.h>
#include "dllheader.h"
#include "util.h"

//pItem list_item = NULL; //总表 
//pPItem list_working = NULL; //工作表

//pUser list_user = NULL;

//pNode list_penalty = NULL;
//pNode list_penalty_last = NULL;

//pNode list_user = NULL;
//pNode list_user_last = NULL;

LinkedList list_penalty = { NULL, NULL, 0};
LinkedList list_user = { NULL, NULL, 0};
LinkedList list_book = { NULL, NULL, 0};
LinkedList list_working1, list_working2;

void* tmp;

int init()
{
    //每个链表的头都是预留的错误项
    const wchar_t* error = L"[失效]";
    add_user(0,"?", error, error);
    add_penalty(error, 0, 0,NULL);
    load_list();
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
    FILE* f = fopen(Path_Book, 'r');
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
    FILE* f = fopen(Path_Penalty, 'r');
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
    pUser temp;
    if (user)
    {
        temp = *user;
        if (!strcmp(temp->u_id, u_id)&&
            wcscmp(temp->u_class,u_class)&&
            wcscmp(temp->u_name,u_name))
            return SAME;
    }
    pNode p = list_book.head;
    while (p)
    {
        temp = p->p;
        if (!strcmp(temp->u_id, u_id) &&
            wcscmp(temp->u_class, u_class) &&
            wcscmp(temp->u_name, u_name))
        {
            if (*user)
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
    pBook temp;
    if (book)
    {
        temp = *book;
        if (!wcscmp(temp->b_name, b_name) && !strcmp(temp->b_id, b_id))
            return SAME;
    }
    pNode p = list_book.head;
    while (p)
    {
        temp = p->p;
        if (!wcscmp(temp->b_name, b_name)&&!strcmp(temp->b_id, b_id))
        {
            if (*book)
                *book = temp;
            return SUCCESS;
        }
        p = p->next;
    }
    return NOT_EXIST;
}


int add_penalty(int uid_user, int uid_book, unsigned short days)
{
    
}

pLinkedList get_user_list()
{
    return &list_user;
}

pLinkedList get_penalty_list()
{
    return &list_penalty;
}

//添加超期记录
int add_penalty(pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days)
{
    pPenalty penalty = (pPenalty)malloc(sizeof(Penalty));
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
    int i = check_user(&user, u_id, u_name, u_class);
    if (i != SUCCESS|| i != SAME) 
        return i;
    i = check_book(&book, b_name, b_id);
    if (i != SUCCESS || i != SAME)
        return i;
    penalty->user = user;
    penalty->book = book;
    penalty->days = days;
    penalty->fine = 0.2 * days;
    return SUCCESS; 
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
    while (p = p->next)
    {
        p1 = p->p;
        if (!strcmp(p1->uid, u_id) && user != p1)
            return CONFLICT;
    }
    strcpy(user->u_id, u_id);
    wcscpy(user->u_name, u_name);
    wcscpy(user->u_class, u_class);
    return SUCCESS;
}

//添加图书
int add_book(int uid, const wchar_t* b_name, const char* b_id)
{

    pBook book = (pBook)malloc(sizeof(book));
    if (!book) return MEMORY_FULL;
    memset(book, 0, sizeof(Book));
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
    while (p = p->next)
    {
        p1 = p->p;
        if ((!strcmp(p1->b_id, b_id)||!wcscmp(p1->b_name, b_name)) && book != p1)
            return CONFLICT;
    }
    strcpy(book->b_id, b_id);
    wcscpy(book->b_name, b_name);
    return SUCCESS;
}

pLinkedList search(pLinkedList source, pLinkedList search)
{
    if (!search->head)
        return;
    pLinkedList des = (pLinkedList)malloc(sizeof(LinkedList));
    memset(des, 0, sizeof(LinkedList));
    pNode p = source->head->next;
    while (p)
    {
        pNode p1 = search->head;
        bool add = false;
        while (p1)
        {
            pSearch s = p1->p;
            if (s->type == USER_ID)
            {
                if (!str_find(((pUser)p->p)->u_id, s->str, s->is_fuzzy))
                    goto big_continue;
                continue;
            }
            if (s->type == USER_NAME)
            {
                if (!wstr_find(((pUser)p->p)->u_name, s->wstr, s->is_fuzzy))
                    goto big_continue;
                continue;
            }
            if (s->type == USER_CLASS)
            {
                if (!wstr_find(((pUser)p->p)->u_class, s->wstr, s->is_fuzzy))
                    goto big_continue;
                continue;
            }
            if (s->type == BOOK_ID)
            {
                if (!str_find(((pBook)p->p)->b_id, s->str, s->is_fuzzy))
                    goto big_continue;
                continue;
            }
            if (s->type == BOOK_NAME)
            {
                if (!wstr_find(((pBook)p->p)->b_name, s->wstr, s->is_fuzzy))
                    goto big_continue;
                continue;
            }
            if (s->type == DAYS)
            {
                if (((pPenalty)p->p)->days!=s->i)
                    goto big_continue;
                continue;
            }
            if (s->type == FINE)
            {
                if (fabs(((pPenalty)p->p)->days-s->f)>1e-6)
                    goto big_continue;
                continue;
            }
        }
        add_item(des, p->p);
    big_continue:
        p = p->next;
    }
    return des;
}

void sort(pLinkedList list, int type)
{
    
}