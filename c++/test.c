#include <stdio.h>
int put1(const char *);
int main()
{
    put1("abc");
    return 0;

}

int put1(const char * string)
{
    int count = 0;
    while(*string++)
    {
        putchar(*string);
        count++;
    }
    putchar('\n');
    return (count);
}
