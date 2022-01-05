#pragma once
#include <stdbool.h>
#include <wchar.h>
#include <stdbool.h>
#include "util.h"

/*
*	������������Ҫ��¶�ĺ���
*/

/*
*  dllmain.c
*/
//�൱��main()�ĳ�ʼ��
_declspec(dllexport) int init();
//��¼
_declspec(dllexport) int login(char* account, char* pwd);
//��ȡ�û��б�
_declspec(dllexport) pLinkedList get_user_list();
//��ȡ���ڼ�¼�б�
_declspec(dllexport) pLinkedList get_penalty_list();
//��ȡͼ���б�
_declspec(dllexport) pLinkedList get_book_list();
//��ȡ�����б�
_declspec(dllexport) pLinkedList get_search_list();
//ˢ�³��ڼ�¼�б�
_declspec(dllexport) void fresh_penalty_list();
//�����ļ�
_declspec(dllexport) int write_list();
//�����������ɾ���ڵ������
_declspec(dllexport) void delete_item_from_searching(pLinkedList source, void* info);
//�����������
_declspec(dllexport) int add_search_str(char* str, int type, bool is_fuzzy);
//�����������
_declspec(dllexport) int add_search_i(wchar_t* wstr, int type);
//��Ӹ���������
_declspec(dllexport) int add_search_f(wchar_t* wstr, int type);
//��ӳ��ڼ�¼
_declspec(dllexport) int add_penalty(pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days);
//�޸ĳ��ڼ�¼
_declspec(dllexport) int edit_penalty(pPenalty penalty, pUser user, pBook book, const wchar_t* b_name, const char* b_id,
    const char* u_id, const wchar_t* u_name, const wchar_t* u_class, unsigned short days);
//����û�
_declspec(dllexport) int add_user(int uid, const char* u_id, const wchar_t* u_name, const wchar_t* u_class);
//�޸��û�
_declspec(dllexport) int edit_user(pUser user, const char* u_id, const wchar_t* u_name, const wchar_t* u_class);
//���ͼ��
_declspec(dllexport) int add_book(int uid, const wchar_t* b_name, const char* b_id);
//�޸�ͼ��
_declspec(dllexport) int edit_book(pBook book, const wchar_t* b_name, const char* b_id);
//����
_declspec(dllexport) pLinkedList search(pLinkedList source, pLinkedList search);
//����
_declspec(dllexport) void sort_penalty(pLinkedList list, int type, bool is_positive);
//ͳ��
_declspec(dllexport) float statistic(pLinkedList list);

_declspec(dllexport) pUser get_penalty_user(pNode p);

_declspec(dllexport) pBook get_penalty_book(pNode p);

/*
*  util.c
*/
//����ַ����Ƿ�Ϊһ��С��
_declspec(dllexport) bool wstr_is_illegal_decimal(const wchar_t* str);
//����ַ����Ƿ�Ϊ������
_declspec(dllexport) bool wstr_is_pure_numberic(wchar_t* str);
//����ַ����Ƿ�Ϊid
_declspec(dllexport) bool wstr_is_id(const wchar_t* str);
//�ַ���ת����
_declspec(dllexport) unsigned short wstr_to_short(const wchar_t* str);
//ɾ���ڵ�
_declspec(dllexport) void delete_item(pLinkedList list, pNode p, bool free_data);
//����б�(����list)
_declspec(dllexport) void clear_list(pLinkedList list);