#pragma once
#include <stdbool.h>
#include <wchar.h>
#include "util.h"

/*
	这里存放所有需要暴露的函数
*/

_declspec(dllexport) int login(char* account, char* pwd);


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