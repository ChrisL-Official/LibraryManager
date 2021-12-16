#include <stdbool.h>

_declspec(dllexport) int login(char* account, char* pwd);

_declspec(dllexport) enum Login_State {
    SUCCESS,
    WRONG,
    NOT_EXIST
};

_declspec(dllexport) typedef struct Account_Info {
    int id;
    char name[11];
    char class[11];
    char pwd[20];
}Account,*pAccount;