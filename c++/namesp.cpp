#include <iostream>
#include "namesp.h"

namespace pers
{
    using std::cout;
    using std::cin;
    void getPerson(Person & rp)
    {
        cout << "enter first name:";
        cin >> rp.fname;
        cout << "enter last name:";
        cin >> rp.lname;
    }

    void showPerson(const Person & rp)
    {
        cout << rp.lname << " , " << rp.fname;
    }
}

namespace debts
{
    using std::cout;
    using std::cin;
    void getDebt(Debt & rd)
    {
        getPerson(rd.name);
        cout << "enter debt:";
        cin >> rd.amount;
    }

    void showDebt(const Debt & rd)
    {
        showPerson(rd.name);
        cout << ": $" << rd.amount;
    }

    double sumDebts(const Debt ar[],int n)
    {
        double total = 0;
        for(int i = 0;i < n;i++)
            total += ar[i].amount;
        return total;
    }
}

