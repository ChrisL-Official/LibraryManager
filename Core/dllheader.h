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
//相当于main()的初始化
_declspec(dllexport) int init();
//登录
_declspec(dllexport) int login(char* account, char* pwd);
//获取用户列表
_declspec(dllexport) pLinkedList get_user_list();
//获取超期记录列表
_declspec(dllexport) pLinkedList get_penalty_list();
//获取图书列表
_declspec(dllexport) pLinkedList get_book_list();
//获取搜索列表
_declspec(dllexport) pLinkedList get_search_list();
//刷新超期记录列表
_declspec(dllexport) void fresh_penalty_list();
//保存文件
_declspec(dllexport) int write_list();
//从搜索结果中删除节点和数据
_declspec(dllexport) void delete_item_from_searching(pLinkedList source, void* info);
//添加文字搜索
_declspec(dllexport) int add_search_str(char* str, int type, bool is_fuzzy);
//添加整形搜索
_declspec(dllexport) int add_search_i(wchar_t* wstr, int type);
//添加浮点型搜索
_declspec(dllexport) int add_search_f(wchar_t* wstr, int type);
//添加超期记录
_declspec(dllexport) int add_penalty(pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days);
//修改超期记录
_declspec(dllexport) int edit_penalty(pPenalty penalty, pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days);
//添加用户
_declspec(dllexport) int add_user(int uid, const char* u_id, const wchar_t* u_name, const wchar_t* u_class);
//修改用户
_declspec(dllexport) int edit_user(pUser user, const char* u_id, const wchar_t* u_name, const wchar_t* u_class);
//添加图书
_declspec(dllexport) int add_book(int uid, const wchar_t* b_name, const char* b_id);
//修改图书
_declspec(dllexport) int edit_book(pBook book, const wchar_t* b_name, const char* b_id);
//搜索
_declspec(dllexport) pLinkedList search(pLinkedList source, pLinkedList search);
//排序
_declspec(dllexport) void sort_penalty(pLinkedList list, int type, bool is_positive);
//统计
_declspec(dllexport) float statistic(pLinkedList list);

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
//删除节点
_declspec(dllexport) void delete_item(pLinkedList list, pNode p, bool free_data);
//清空列表(保留list)
_declspec(dllexport) void clear_list(pLinkedList list);