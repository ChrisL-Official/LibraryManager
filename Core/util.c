#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>
#include <io.h>
#include "dllheader.h"

unsigned short wstr_to_short(const wchar_t* str)
{
    int result = 0;
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

void delete_item(pLinkedList list,pNode p)
{
    if (p->pervious)
        p->pervious->next = p->next;
    else
        list->head = p->next;
    if (p->next)
        p->next->pervious = p->pervious;
    else
        list->tail = p->pervious;
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

void delete_list(pLinkedList list)
{
    pNode p = list->head,tmp;
    while (p)
    {
        tmp = p->next;
        free(p->p);
        free(p);
        p = tmp;
    }
    free(list);
}

void clear_list(pLinkedList list)
{

}

int check_file(const char* path)
{
    //r->4 w->2 rw->6
    if (_access(path, 6))
    {
        FILE* f = fopen(path, 'w');
        if (f)
        {
            fclose(f);
            return SUCCESS;
        }
        else 
        {
            return UNWRITABLE;
        }
    }
    return SUCCESS;
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