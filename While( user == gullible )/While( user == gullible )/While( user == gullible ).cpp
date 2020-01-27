//   **********************************************************************
//   * This challenge asks for a user to input a number except 5 and exit *
//   * after entering 5. Added steps are to tell them they win after 10   *
//   * itterations. Finally the last task is to have them enter a number  *
//   * that incriments and tells them not to enter the number they just   *
//   * entered.                                                           *
//   **********************************************************************

#include <iostream>


using namespace std;

int userNum;


int main()
{

	cout << "Enter any number other than 5: \n";
	cin >> userNum;

	while (userNum != 5)
	{
		cout << "yes... Continue... \n";
		cout << "Enter a new number: ";
		cin >> userNum;
	}	

	if (userNum == 5)

	{
	cout << "Hey! You weren't supposed to enter 5!!! Game Over nub!";
	}

	return 0;

}