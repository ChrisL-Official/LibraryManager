#pragma once
#include <stdbool.h>
#include <wchar.h>
#include <stdbool.h>
#include "util.h"

/*
*	这里存放所有需要暴露的函数
*/

/*
*  dllmain.c
*/
//
/*
//增加
_declspec(dllexport) pItem add_item(const char* id, const wchar_t* u_name, const wchar_t* u_class, const wchar_t* b_name, int days);
//修改
_declspec(dllexport) pItem change_item(pItem p, const char* id, const wchar_t* u_name, const wchar_t* u_class, const wchar_t* b_name, int days);
//删除
_declspec(dllexport) void delete_item(pItem p);
//获取所有条目
_declspec(dllexport) pItem get_all_items();
//获取工作条目
_declspec(dllexport) pPItem get_need_items();

_declspec(dllexport) pUser get_all_users();

_declspec(dllexport) pUser add_user(const char* id, const wchar_t* uname, const wchar_t* uclass);

_declspec(dllexport) pUser change_user(pUser p, const char* id, const wchar_t* uname, const wchar_t* uclass);

_declspec(dllexport) pUser delete_user(pUser p);*/

_declspec(dllexport) int init();

_declspec(dllexport) int login(char* account, char* pwd);

_declspec(dllexport) pNode get_users();

_declspec(dllexport) pNode get_penaltys();

_declspec(dllexport) pNode get_books();

_declspec(dllexport) pLinkedList get_user_list();

_declspec(dllexport) pLinkedList get_penalty_list();

_declspec(dllexport) pLinkedList get_book_list();

_declspec(dllexport) pLinkedList get_search_list();

_declspec(dllexport) void fresh_penalty_list();

_declspec(dllexport) void delete_item(pLinkedList list, pNode p);

_declspec(dllexport) void clear_list(pLinkedList list);

_declspec(dllexport) int add_search_str(char* str, int type, bool is_fuzzy);

_declspec(dllexport) int add_search_i(wchar_t* wstr, int type);

_declspec(dllexport) int add_search_f(wchar_t* wstr, int type);

_declspec(dllexport) int add_penalty(pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days);

_declspec(dllexport) int edit_penalty(pPenalty penalty, pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days);

_declspec(dllexport) int add_user(int uid, const char* u_id, const wchar_t* u_name, const wchar_t* u_class);

_declspec(dllexport) int edit_user(pUser user, const char* u_id, const wchar_t* u_name, const wchar_t* u_class);

_declspec(dllexport) int add_book(int uid, const wchar_t* b_name, const char* b_id);

_declspec(dllexport) int edit_book(pBook book, const wchar_t* b_name, const char* b_id);

_declspec(dllexport) pLinkedList search(pLinkedList source, pLinkedList search);

_declspec(dllexport) void sort(pLinkedList list, int type, bool is_positive);

_declspec(dllexport) pUser get_penalty_user(pNode p);

_declspec(dllexport) pBook get_penalty_book(pNode p);

/*
*  util.c
*/
//检查字符串是否为一般小数
_declspec(dllexport) bool wstr_is_illegal_decimal(const wchar_t* str);
//检查字符串是否为纯数字
_declspec(dllexport) bool wstr_is_pure_numberic(wchar_t* str);
//检查字符串是否为id
_declspec(dllexport) bool wstr_is_id(const wchar_t* str);
//字符串转数字
_declspec(dllexport) unsigned short wstr_to_short(const wchar_t* str);