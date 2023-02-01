//Cat Years, Dog Years Problem (8-Kyu)

//int humanYears = 10;
//int catYears = 0;
//int dogYears = 0;

//if (humanYears == 1)
//{
//    catYears = 15; dogYears = 15;
//}
//else if (humanYears == 2)
//{
//    catYears = 15 + 9; dogYears = 15 + 9;
//}
//else if (humanYears >= 3)
//{
//    int p = humanYears - 2;
//    catYears = 15 + 9 + (p * 4); 
//    dogYears = 15 + 9 + (p * 5);
//}

//Console.WriteLine(humanYears); //Check to see value of humanYears
//Console.WriteLine(catYears); //Check to see value of catYears
//Console.WriteLine(dogYears); //Check to see value of dogYears

//int[] humanCatDogYears = {humanYears,catYears,dogYears}; //Create an array with 3 elements assigned

//for Visual Studio
//Console.WriteLine($"[{humanCatDogYears[0]},{humanCatDogYears[1]},{humanCatDogYears[2]}]");//This returns the desired output but it prints as a string

//for Codewars
//return humanCatDogYears;

//-----------------------------------------------------------------------------------------------------------------------------

//Check Same Case (8-Kyu)

//char a = 'k';
//char b = '6';

//if (char.IsLetter(a) == false || char.IsLetter(b) == false)
//{
//    Console.WriteLine(-1); //for vs
//    return -1; //for codewars
//}
//else if (char.IsUpper(a) == true && char.IsUpper(b) == true || char.IsLower(a) == true && char.IsLower(b) == true)
//{
//    Console.WriteLine(1); // for vs
//    return 1; //for codewars
//}
//else
//{
//    Console.WriteLine(0); //for vs
//    return 0; //for codewars
//}

//-----------------------------------------------------------------------------------------------------------------------------

//Counting Sheep Problem (8-Kyu)

//string result = "";
//for (int i = 0; i <= 20; i++)
//{
//    result += $"{i} sheep...";
//}

//Console.WriteLine(result); // for VS

//return result; // for Codewars

//-----------------------------------------------------------------------------------------------------------------------------
//The Feast of Many Beasts

//bool result;
//string beast = "great blue heron";// for VS
//string dish = "garlic naan"; // for VS
//int beastLength = beast.Length;
//int dishLength = dish.Length;

//char firstBeastCharacter = beast[0];
//char lastBeastCharacter = beast[beastLength-1];
//char firstDishCharacter = dish[0];
//char lastDishCharacter = dish[dishLength-1];


//if (firstBeastCharacter == firstDishCharacter && lastBeastCharacter == lastDishCharacter)
//{
//    result = true;
//}
//else
//{
//    result = false;
//}

//Console.WriteLine(result); // for VS
//return result; //for codewars

//-----------------------------------------------------------------------------------------------------------------------------

//Gravity Flip (8-Kyu)
//using System; // for VS

//char dir = 'L'; // for VS
//int[] arrOriginal = {1,4,5,3,5}; // for VS
//int[] arrReordered = new int[arrOriginal.Length];

//if (dir == 'R')
//{
//    Array.Sort(arrOriginal);
//}

//else if (dir == 'L')
//{
//    Array.Sort(arrOriginal);
//    Array.Reverse(arrOriginal);
//}

//foreach (int i in arrOriginal)    // for VS
//{                                 // for VS
//    Console.Write(i + " ");       // for VS
//}                                 // for VS

//return arrReordered;              // for codewars


//-----------------------------------------------------------------------------------------------------------------------------

//Pillars (8-Kyu)

//int numPill = 1;

//int dist = 10; // distance between pillars in meters

//int width = 10; // width of each pillar in centimeters

//int distCentimeters = dist * 100;

//if (numPill == 1)
//{
//    Console.WriteLine(0); // for vs
//    return 0; //for codewars
//}
//else
//{
//    int totalDistance = ((numPill - 1) * distCentimeters) + ((numPill - 2) * width);
//    Console.WriteLine(totalDistance); // for vs
//    return totalDistance; // for codewars
//}


//-----------------------------------------------------------------------------------------------------------------------------

//Total Amount of Points (8-Kyu)

//Case 1
//string[] games = new string[10] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }; //VS code

//Case 2
//string[] games = new string[10] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }; //VS code

//Case 3
//string[] games = new string[10] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4"  }; //VS code

//Case 4
//string[] games = new string[10] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" }; //VS code

//int totalChampionshipPoints = 0;

//foreach (string k in games)
//{
//    int intValueOfChar0 = (int)char.GetNumericValue(k,0); // converts char to int
//    int intValueOfChar2 = (int)char.GetNumericValue(k,2); // converts char to int

//-----------------------------------
//Alternative, longer method
//char[] characterArray = k.ToCharArray();
//int intValueOfChar0 = (int)Char.GetNumericValue(characterArray[0]); // converts char to int
//int intValueOfChar2 = (int)Char.GetNumericValue(characterArray[2]); // converts char to int
//-----------------------------------

//        if (intValueOfChar0 > intValueOfChar2)
//        {
//            totalChampionshipPoints += 3; //addition assignment operator
//        }
//        else if (intValueOfChar0 < intValueOfChar2)
//        {
//            totalChampionshipPoints += 0; //addition assignment operator
//        }
//        else
//        {
//            totalChampionshipPoints += 1; //addition assignment operator
//        }
//}

//Console.WriteLine(totalChampionshipPoints); // for VS
//return totalChampionshipPoints; //for Codewars