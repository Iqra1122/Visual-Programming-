//# include<iostream>
//# include<conio.h>
//# include<conio.h>
//using namespace std;
//class HASH
//{
//	int arr[10];
//public:
//	HASH()
//	{
//		for (int i = 0; i<11; i++)
//			arr[i] = NULL;
//	}
//	void hashing(int a)
//	{
//		int item;
//		item = a;
//		a = a % 11;
//		for (int i = 0; i<11; i++)
//		{
//			if (arr[a] == NULL)
//			{
				/*arr[a] = item;
				cout << " values = " << item << " \t and Stored location is " << "\t" << a << endl;
				break;
			}
			else
			{
				a++;
			}
		}
	}


};
void main()
{
	int x;
	HASH obj;
	cout << " -------------------------- HASHING  ---------------------------" << endl;
	cout << " Enter the 10 values " << endl;
	for (int i = 0; i<11; i++)
	{
		cin >> x;
		obj.hashing(x);
	}
	cout << " -------------------------- HASHING COMPLETE  ---------------------------" << endl;
	getch();
}*/
//# include<iostream>
//# include<conio.h>
//# include<conio.h>
//using namespace std;
//class HASH
//{
//	int arr[10];
//public:
//	HASH()
//	{
//		for( int i=0;i<11;i++)
//		  arr[i]=NULL;
//	}
//	void hashing(int a)
//	{
//		int item;
//		item=a;
//		a=a % 11;
//		for ( int i=0; i<11;i++)
//		{
//			if ( arr[a]==NULL)
//			{
//				arr[a]=item; 
//				cout<<" values = "<< item <<" \t and Stored location is "<<"\t"<<a<<endl;
//				break; 
//			}
//			else
//			{
//				a++;
//			}
//		}
//	}
//		
//
//};
//void main()
//{
//	int x;
//    HASH obj;
//	cout<<" -------------------------- HASHING  ---------------------------"<<endl;
//	cout<<" Enter the 10 values "<<endl;
//	for ( int i=0; i<11;i++)
//	{
//		cin>>x;
//		obj.hashing(x);
//	}
//	cout<<" -------------------------- HASHING COMPLETE  ---------------------------"<<endl;
//	getch();
//}
//-----------------------------------------------------------------------------------------------------------------------------------
# include<iostream>
# include<conio.h>
# include<conio.h>
using namespace std;
class HASH
{
	int arr[30];
public:
	HASH()
	{
		for (int i = 0; i<31; i++)
			arr[i] = NULL;
	}
	void hashing(int a)
	{
		int item;
		item = a;
		a = a % 30;
		for (int i = 0; i<30; i++)
		{
			if (arr[a] == NULL)
			{
				arr[a] = item;
				cout << " REGISTATION NUMBER  = " << item << " \t PARKING LOCATION IS " << "\t" << a << endl;
				break;
			}
			else
			{
				a++;
			}
		}
	}


};
void main()
{
	int x;
	char y;
	HASH obj;
	do
	{
		cout << " -------------------------- PARKING  ---------------------------" << endl << endl;
		cout << " Enter the first three digit of registration number !  " << endl;
		for (int i = 0; i<11; i++)
		{
			cin >> x;
			obj.hashing(x);
			cout << " Do you want to continue y/n" << endl;
			cin >> y;
		}

	} while (y == 'Y' || y == 'y');
	cout << " -------------------------- THANK YOU  ---------------------------" << endl;
	getch();
}