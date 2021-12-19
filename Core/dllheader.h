#pragma once
#include <stdbool.h>
#include "util.h"
#include <wchar.h>

/*这里存放所有需要暴露的函数*/

//初始化
_declspec(dllexport) int init();
//登录
_declspec(dllexport) int login(char* account, char* pwd);

_declspec(dllexport) pUser add_user(const char* id, const wchar_t* name, const wchar_t* class);
