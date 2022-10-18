//Reed Goodwin
//10-18-22
//Mini Challenge #1 REdo GitHub 
//This console project will ask for their name
//and then put their name into a greeting!
//PeerReview --
bool wrong; 
long validNum = 0;
string myName ="";
string whileLoop="";
while( whileLoop != "no"){
    Console.Clear();

    Console.WriteLine("Hey!! Fancy seeing you here! Whats your name!?");
Console.WriteLine();
myName = Console.ReadLine();
 wrong = Int64.TryParse(myName, out validNum); 
if(wrong == true){

    Console.WriteLine("Please enter a name not a number");
    Console.WriteLine("Press enter to restart");
    Console.ReadLine();

}else{

    Console.WriteLine($"Hey {myName}! Nice to meet you I hope you have a good day!!");
Console.WriteLine("Play Again?   yes or no?");
whileLoop = Console.ReadLine().ToLower();
}

}