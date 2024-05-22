
     using System.ComponentModel.Design;

    
void HobbyGenerator(){
    bool repeat = true;
    do
    {
        Random randy = new Random();
    int randomHobby = randy.Next(1, 6);
    var yourHobby = "";

    if (randomHobby == 1)
    {
        yourHobby = "a hypersomniac! Sweet dreams!";
    }
    else
    {
        if (randomHobby == 2)
        {
            yourHobby = "a League of Legends player! My condolences.";
        }
        else
        {
            if (randomHobby == 3)
            {
                yourHobby = "preoccupied with testing the quality of ashes at the crematorium... Are you OK";
            }
            else
            {
                if (randomHobby == 4)
                {
                    yourHobby = "a hobbyist! Good luck finding a hobby!";
                }
                else
                {
                    yourHobby = "a crusty juggler! Watch out for the NWA!";
                }
            }
        } 
        {

        }
    }

    
   

    

    Console.WriteLine("Enter your name");
    var userInput = Console.ReadLine();
    Console.WriteLine($"{userInput} has become {yourHobby}");

    if (userInput == "exit")
    {
        repeat = false;
    }
    } while ( repeat );
}
HobbyGenerator();


// hobbies include: sleeping, league of legends, testing the quality of ashes at the crematorium,