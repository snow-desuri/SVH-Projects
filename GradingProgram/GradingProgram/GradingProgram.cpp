
// To stay within the scope of the challenege, I COULD have used switch statements here, but I elected not to as it was not an expectation of the challenge. I want to try and stay within the scope of the challenge for these. 

#include <iostream>
using namespace std;

int main()
{
	int score;

	cout << "Enter Your Test Score:";
	cin >> score;

	if (score <= 59)
	{
		cout << "You got an F! Try harder!" << endl;
	}

	 if (score >= 60 && score <= 69)
	{
		cout << "You got a D. You can do better!" << endl;
	}

	 if (score >= 70 && score <= 79)
	{
		cout << "You got a C. Keep studying!" << endl;
	}

	 if (score >= 80 && score <= 89)
	{
		cout << "You got a B. Not bad!" << endl;
	}

	 if (score >= 90 && score <= 99)
	{
		cout << "You got an A. That's amazing!" << endl;
	}

	 if (score >= 100)
	{
		cout << "Congratulations you aced the test!" << endl;
	}

	 return 0;
}