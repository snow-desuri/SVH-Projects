// For this challenge, they are adding the expectation of switch statements, so again, I'll be staying within the scope of the expectation for now. 
#include <iostream>

using namespace std;

//Coke = 1
//Pepsi = 2
//Sprite = 3
//Mt.Dew = 4
//Water = 5

int x;

int main()
{
	cout << "Please enter your selection: ";
	cin >> x;

	switch (x)
	{
		case 1: 
			cout << "You selected Coke. \n";
			break;

		case 2: 
			cout << "You selected Pepsi. \n";
			break;

		case 3: 
			cout << "You selected Sprite. \n";
			break;

		case 4: 
			cout << "You selected Mt. Dew.\n";
			break;

		case 5: 
			cout << "You selected Water. \n";
			break;

		default: 
			cout << "You selected something that doesn't exist. Here's your money back. \n";
			break;
	}

		return 0;
}