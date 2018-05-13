#include <iostream>
#include "stock00.h"

void Stock::acquire(const std::string & co,long n,double pr)
{
    company = co;
    if(n < 0)
    {
        std::cout << "number of shares can't be negative;";
        std::cout << company << " shares set to 0.\n";
        shares = 0;
    }else{
        shares = n;
    }
    share_val = pr;
    set_tot();
}

void Stock::buy(long num,double price)
{
    if(num < 0)
    {
        std::cout << "number of shares purchased can't be negative.";
        std::cout << "transaction is aborted.\n";
    }else{
        shares += num;
        share_val = price;
        set_tot();
    }
}

void Stock::sell(long num,double price)
{
    using std::cout;
    if(num < 0)
    {
        cout << "number of shares sold can't be negative.";
        cout << "transaction is aborted.\n";
    }else if(num > shares){
        cout << "you can't sell more than you have!";
        cout << "transaction is aborted.\n";
    }else{
        shares -= num;
        share_val = price;
        set_tot();
    }
}

void Stock::update(double price)
{
    share_val = price;
    set_tot();
}

void Stock::show()
{
    std::cout << "company: " << company << " shares: " << shares << "\n"
              <<" share price: $" << share_val << " total worth: $" << total_val << "\n";
}
