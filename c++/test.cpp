#include <iostream>
class A
{
    public:
        int a;
};

int main()
{
    A obj1,obj2;
    obj1.a=10;
    obj2 = obj1;
    obj2.a++;
    std::cout << obj1.a << std::endl;
    return 0;
}
