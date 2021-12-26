#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>
#include "dllheader.h"

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

pNode add_item(pLinkedList list, pNode p)
{
    if (list->head)
    {
        p->pervious = list->tail;
        list->tail->next = p;
    }
    else
    {
        list->head = p;
    }
    list->tail = p;
    list->items++;
    return p;
}

void delete_item(pLinkedList list, pNode p)
{
    //Í·Ö¸Õë½ûÖ¹É¾³ý
    p->pervious->next = p->next;
    p->next->pervious = p->pervious;
    free(p);
    list->items--;
}

void reverse_list(pLinkedList des, pLinkedList sur)
{

}