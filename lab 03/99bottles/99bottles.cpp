#include<iostream>
using namespace std;
int main()
{
    cout<<"How many bottles of oop?\n"<<endl;
    int number;

    cin>>number;
    int total=number;
    if(number>1){
    cout<<"\n"<< number<<" bottles of oop\n"<<endl;
    }
    else{
    cout<<number<<" bottle of oop"<<endl;
    }

    while(number>-1)
    {
        string state="bottle";
        if(number>=3)
        {
            cout<< number <<" "<< state << "s "<< " of milk on the wall, " <<number <<" "<< state<< "s "<< " of milk.\n" << "Take one down and pass it around, " << number-1 << " bottles of milk on the wall.\n";
        }

        else if(number==2)
        {
            cout<< number <<" "<< state << "s "<< " of milk on the wall, " <<number <<" "<< state << "s "<< " of milk.\n" << "Take one down and pass it around, " << number-1 << " bottle of milk on the wall.\n";
        }

        else if(number==1)
        {
            cout<< number <<" "<< state << " of milk on the wall, " <<number <<" "<< state << " of milk.\n"<< "Take one down and pass it around, " << "no more bottles of milk on the wall.\n";

        }

        else{
            if(number==0)
            cout<<"No more bottles of milk on the wall, no more bottles of milk." <<"\n" <<"Go to the store and buy some more " << total<< " bottles of milk on the wall."<<endl;
        }


        number--;

        cout<<"\n"<<endl;
    }

}
