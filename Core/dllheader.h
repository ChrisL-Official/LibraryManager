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
/*_declspec(dllexport) int login(char* account, char* pwd);
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

_declspec(dllexport) pNode add_item(pLinkedList list, pNode data);

_declspec(dllexport) void delete_item(pNode p);

_declspec(dllexport) void change_item(pNode p, pNode data);

_declspec(dllexport) pLinkedList get_user_list();

_declspec(dllexport) pLinkedList get_penalty_list();

_declspec(dllexport) pNode add_user(const char* u_id, const wchar_t* u_name, const wchar_t* u_class);

_declspec(dllexport) pNode add_penalty(const wchar_t* b_name, unsigned short days);

/*
*  util.c
*/
//检查字符串是否为纯数字
_declspec(dllexport) bool wstr_is_pure_numberic(wchar_t* str);
//检查字符串是否为id
_declspec(dllexport) bool wstr_is_id(const wchar_t* str);