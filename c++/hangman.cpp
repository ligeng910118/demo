#include <iostream>
#include <string>
#include <cstdlib>
#include <ctime>
#include <cctype>
using std::string;
const int NUM = 26;
const string wordlist[NUM] = {
    "apiary","beetle","cereal","danger","ensign","florid","garage","health","insult",
    "jackal","keeper","loaner","manage","nonce","onset","plaid","quilt","remote","stolid",
    "train","useful","valid","whence","xenon","yearn","zippy"
};

int main()
{
    using namespace std;
    std::srand(std::time(0));
    char play;
    cout << "will you play a word game?<y/n>";
    cin >> play;
    play = tolower(play);
    while(play == 'y')
    {
        string target = wordlist[std::rand() % NUM];
        int length = target.length();
        string attempt(length,'-');
        string badchars;
        int guesses = 6;
        cout << "guess my secret word. it has " << length << " letters,and you guess\n"
             << "one letter at a time.you get " << guesses <<" wrong guessws.\n";
        cout << "your word: " << attempt << endl;
        while(guesses > 0 && attempt != target)
        {
            char letter;
            cout << "guess a letter:";
            cin >> letter;
            if(badchars.find(letter) != string::npos || attempt.find(letter)!=string::npos)
            {
                cout << "you already guessed that.try again.\n";
                continue;
            }
            int loc = target.find(letter);
            if(loc == string::npos)
            {
                cout << "oh,bad guess!\n";
                --guesses;
                badchars += letter;
            }else{
                cout << "good guess!\n";
                attempt[loc] = letter;
                loc = target.find(letter,loc + 1);
                while(loc != string::npos)
                {
                    attempt[loc] = letter;
                    loc = target.find(letter,loc + 1);
                }
            }
            cout << "your word: " << attempt << endl;
            if(attempt != target)
            {
                if(badchars.length() > 0)
                    cout << "bad choices: " << badchars << endl;
                cout << guesses << " bad guesses left\n";
            }
        }
        if(guesses > 0)
            cout << "that's right!\n";
        else
            cout << "sorry, the word is " << target << ".\n";
        cout << "will you play another?<y/n>";
        cin >> play;
        play = tolower(play);
    }
    cout << "bye\n";
    return 0;
}
