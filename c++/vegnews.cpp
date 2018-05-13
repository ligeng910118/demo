#include <iostream>
using std::cout;
#include "stmgbad.h"

void callme1(StringBad &);
void callme2(StringBad);

int main()
{
    using std::endl;
    {
        cout << "starting an inner block.\n";
        StringBad headline1("celery stalks at midnight");
        StringBad headline2("lettuce prey");
        StringBad sports("spinach leaves bowl for dollars");
        cout << "headline1: " << headline1 << endl;
        cout << "headline2: " << headline2 << endl;
        cout << "sports: " << sports << endl;
        callme1(headline1);
        cout << "headline1: " << headline1 << endl;
        callme2(headline2);
        cout << "headline2: " << headline2 << endl;
        cout << "initialize one object to another:\n";
        StringBad sailor = sports;
        cout << "sailor: " << sailor << endl;
        cout << "assign one object to another:\n";
        StringBad knot = headline1;
        cout << "knot: " << knot << endl;
        cout << "exiting the block.\n";
    }
    cout << "end of main()\n";
    return 0;
}

void callme1(StringBad & rsb)
{
    cout << "string passed by reference:\n";
    cout << "    \"" << rsb << "\"\n";
}

void callme2(StringBad sb)
{
    cout << "string passed by value:\n";
    cout << "    \"" << sb<< "\"\n";
}
