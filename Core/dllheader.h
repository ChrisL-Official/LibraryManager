#pragma once
#include <stdbool.h>
#include "util.h"
#include <wchar.h>

/*������������Ҫ��¶�ĺ���*/

//��ʼ��
_declspec(dllexport) int init();
//��¼
_declspec(dllexport) int login(char* account, char* pwd);

_declspec(dllexport) pUser add_user(const char* id, const wchar_t* name, const wchar_t* class);
