#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <io.h>
#include "dllheader.h"

bool wstr_is_illegal_decimal(const wchar_t* str) {
    int n=0, m=0;

    while (*str >= 0x30 && *str <= 0x39) {
        n++;
        str++;
    }

    if (*str == 0x2E) {
        str++;
        while (*str >= 0x30 && *str <= 0x39) {
            m++;
            str++;
        }
        if (!n && !m) return false;
    }
    else if (!n) {
        return false;
    }
    return *str == 0 ? true : false;
}

unsigned short wstr_to_short(const wchar_t* str)
{
    unsigned short result = 0;
    wchar_t* p = str;
    while (*p)
    {
        if (*p >= 0x30 && *p <= 0x39)
        {
            result = result * 10 + *p - 0x30;
        }
        p++;
    }
    return result;
}

bool wstr_is_pure_numberic(const wchar_t* str)
{
    wchar_t* p = str;
    if (!*p) return false;
    while (*p)
    {
        if (*p < 0x30 || *p > 0x39) return false;
        p++;
    }
    return true;
}

bool wstr_is_id(const wchar_t* str)
{
    wchar_t* p = str;
    wchar_t c;
    if (!*p) return false;
    while (c = *p++)
    {
        if (c >= 0x30 && c <= 0x39) continue; //0-9
        if (c >= 0x41 && c <= 0x5A) continue; //A-Z
        //if (c >= 0x61 && c <= 0x7A) continue; //a-z
        return false;
    }
    return true;
}

pNode add_item(pLinkedList list, void* p)
{
    pNode node = (pNode)malloc(sizeof(Node));
    if (!node) return NULL;
    memset(node, 0, sizeof(Node));
    node->p = p;
    if (list->head)
    {
        pNode tmp = list->tail;
        node->pervious = list->tail;
        tmp->next = node;
    }
    else
    {
        list->head = node;
    }
    list->tail = node;
    return node;
}

pNode insert_item(pLinkedList list, void* p)
{
    pNode node = (pNode)malloc(sizeof(Node));
    if (!node) return NULL;
    memset(node, 0, sizeof(Node));
    node->p = p;
    if (list->head)
    {
        list->head->next = node;
    }
    else
    {
        list->head = node;
    }
    list->tail = node;
    return node;
}

void delete_item(pLinkedList list,pNode p, bool free_data)
{
    if (p->pervious)
        p->pervious->next = p->next;
    else
        list->head = p->next;
    if (p->next)
        p->next->pervious = p->pervious;
    else
        list->tail = p->pervious;
    if(free_data)
        free(p->p);
    free(p);
}

void reverse_list(pLinkedList list)
{
    pNode p = list->tail, tmp;
    while (p->pervious)
    {
        tmp = p->pervious;
        p->pervious = p->next;
        p->next = tmp;
        p = tmp;
    }
    tmp = list->head;
    list->head = list->tail;
    list->tail = tmp;
}

void delete_list(pLinkedList list,bool free_data)
{
    clear_list(list,free_data);
    free(list);
}

void clear_list(pLinkedList list, bool free_data)
{
    pNode p = list->head, tmp;
    while (p)
    {
        tmp = p->next;
        if(free_data)
            free(p->p);
        free(p);
        p = tmp;
    }
    list->head = NULL;
    list->tail = NULL;
}

bool str_find(const char* str, const char* key, bool is_fuzzy)
{
    if (is_fuzzy)
        return strstr(str,key) == NULL ? false : true;
    return strcmp(str, key) ? false : true;
}

bool wstr_find(const wchar_t* str, const wchar_t* key, bool is_fuzzy)
{
    if (is_fuzzy)
        return wcsstr(str, key) == NULL ? false : true;
    return wcscmp(str, key) ? false : true;
}

bool is_file_readable(const wchar_t* file)
{
    FILE* f = _wfopen(file, L"r");
    if(!f)
        return false;
    bool b = true;
    fseek(f, 0, SEEK_END);
    b = ftell(f);
    fclose(f);
    return b;
}

int load_dir(const wchar_t* path)
{
    errno = 0;
    if (_waccess_s(path, 6) == ENOENT)
    {
        int ret = _wmkdir(path);
        if (ret == -1) 
            if (errno = EACCES)
                return UNWRITABLE;    }
    return SUCCESS;
}