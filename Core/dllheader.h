#pragma once
#include <stdbool.h>
#include <wchar.h>
#include "util.h"

/*
	������������Ҫ��¶�ĺ���
*/

_declspec(dllexport) int login(char* account, char* pwd);


//����
_declspec(dllexport) pItem add_item(const char* id, const wchar_t* u_name, const wchar_t* u_class, const wchar_t* b_name, int days);
//�޸�
_declspec(dllexport) pItem change_item(pItem p, const char* id, const wchar_t* u_name, const wchar_t* u_class, const wchar_t* b_name, int days);
//ɾ��
_declspec(dllexport) void delete_item(pItem p);
//��ȡ������Ŀ
_declspec(dllexport) pItem get_all_items();
//��ȡ������Ŀ
_declspec(dllexport) pPItem get_need_items();