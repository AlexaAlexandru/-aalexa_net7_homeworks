// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*

 * Create human steps for 1 action : ACTION - prepare backpack for gym.

Step 1: GET the backpack
Step 2: Open the backpack and check to have the shoes:
	IF the shoes are present go to step 3
	ELSE find the shoes and put them into the backpack
Step 3: GET a shirt, a pair of trainers and a towel.
Step 4: FOR each item at step 3
	IF the item is on your wardrobe	THEN
	put the item into the backpack
	END IF
	END FOR
Step 5: Check to have the bottle of water into the backpack
Step 6: IF step 5 is true, check that the bootle has water
Step 7: IF step 6 is true go to step 9
Step 8: IF step 6 is false, get the bootle and fulfil it this water
Step 9: DISPLAY " the backpack is ready to be taken to the gym "


Create human steps for 2 action : ACTION - take out the garbage

Step 1: Get the garbage from the basket.
Step 2: If you can close with a node the garbage go to step 4
	ELSE take out another garbage bag and spit the garbage between them
Step 3: Check and remember  what kind of garbage is the one you are going to throw away
Step 4: Go to the trash station
Step 5: Check if trash container  1 is for the kind of garbage you have
Step 6: IF step 5 is false THEN :
	REPEAT step 5  for each trash container
	UNTIL trash container is the one of the kind of the garbage
Step 7: IF trash container is full 
	THEN look for another trash station in the area AND perform from step 5 to step 6.
	ELSE go to step 8
Step 8: Throw inside the trash container your garbage
Step 9: DONE

-------------------
Sorting algorithm	


Step 1 : we check numbers by couples and see if the first is smaller than the second
Step 2 : IF step 1 is true go to step 3
	 ELSE switch the second number with the first one.
Step 3 : Check the next couple of numbers ( number 2 and number 3, number 3 and number 4 etc , till the end of the array by applying the same rule of step 1.
	 Perform step 2 for every couple.
Step 4 : At the last pair of numbers
	 IF the second number is bigger than the first we switch place with the first.
Step 5 : We check the next couple of numbers going backwards, by applying the same rule of step 4.

Step 6 : We arrive to the first pair of numbers
	 We verify that the first numbers is smaller than the second one, the second one smaller than 	
	 the third one and so on, till the last number.
Step 7 : DONE


Example 
Given array: 14 | 33 |  27 | 35 | 10|

14 < 33 TRUE 

 14 | 33 |  27 | 35 | 10| <---- Algorithm

33 < 27 FALSE
 
 14 | 27 |  33 | 35 | 10| <---- Algorithm

33 < 35 TRUE

14 | 27 |  33 | 35 | 10|  <---- Algorithm

35 < 10 FALSE

14 | 27 |  33 | 10 | 35|  <---- Algorithm

33 < 10 FALSE

14 | 27 |  10 | 33 | 35|  <---- Algorithm

27 < 10 FALSE

14 | 10 |  27 | 33 | 35|  <---- Algorithm

14 < 10 FALSE

10 | 14 |  27 | 33 | 35|  <---- Algorithm

10 < 14 TRUE

10 | 14 |  27 | 33 | 35|  <----  FINAL Algorithm

------------------------------ 

Write algorithm. Point 4.1

DISPLAY ( insert your amount )

amount <- INPUT ()

tax = 0.005 * amount * 10

IF
	tax < 1 

	OUTPUT ( 1 )
ELSE

	OUTPUT ( tax )


------------------------------

Write algorithm. Point 4.2 


DISPLAY ( insert your amount )

amount <- INPUT ()

total = amount/ 500 ;

OUTPUT ( "There are : " , total , " banknotes of 500 " );

amount = amount - ( total * 500 ) :

total = amount / 200 ;

OUTPUT ( "There are : " , total , " banknotes of 200 " );

amount = amount - ( total * 200 ) :

total = amount / 100 ;

OUTPUT ( "There are : " , total , " banknotes of 100 " );

amount = amount - ( total * 100 ) :

total = amount / 50 ;

OUTPUT ( "There are : " , total , " banknotes of 50 " );

amount = amount - ( total * 50 ) :

total = amount / 20 ;

OUTPUT ( "There are : " , total , " banknotes of 20 " );

amount = amount - ( total * 20 ) :

total = amount / 10 ;

OUTPUT ( "There are : " , total , " banknotes of 10 " );

amount = amount - ( total * 10 ) :

total = amount / 5 ;

OUTPUT ( "There are : " , total , " banknotes of 5 " );

amount = amount - ( total * 5 ) :

total = amount / 1;

OUTPUT ( "There are : " , total , " banknotes of 1 " );
 */
//Algorithm 1 written in C#
string input1 = Console.ReadLine();
int amount1 = Convert.ToInt32(input1);

double tax = 0.005 * amount1 * 10;
if (tax < 1)
{
    Console.WriteLine("Fee will be 1 dollar");
}
else
{
    Console.WriteLine("Fee will be : " + tax);
}


// Algorithm 2 written in C#
string input = Console.ReadLine();
int amount = Convert.ToInt32(input);
int total = amount / 500;
Console.WriteLine("There are: " + total + " banknotes of 500");
amount = amount - (total * 500);
total = amount / 200;
Console.WriteLine("There are: " + total + " banknotes of 200");
amount = amount - (total * 200);
total = amount / 100;
Console.WriteLine("Thee are: " + total + " banknotes of 100 ");
amount = amount - (total * 100);
total = amount / 50;
Console.WriteLine("Thee are: " + total + " banknotes of 50 ");
amount = amount - (total * 50);
total = amount / 20;
Console.WriteLine("Thee are: " + total + " banknotes of 20 ");
amount = amount - (total * 20);
total = amount / 10;
Console.WriteLine("Thee are: " + total + " banknotes of 10 ");
amount = amount - (total * 10);
total = amount / 5;
Console.WriteLine("Thee are: " + total + " banknotes of 5 ");
amount = amount - (total * 5);
total = amount / 1;
Console.WriteLine("Thee are: " + total + " banknotes of 1 ");