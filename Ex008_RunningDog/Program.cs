// Two man walk towards from $distance. Funny dog runs from one man to another and back until moment of meeting. 
// How many times will the dog turn?

static int dogRun(int distance, int firstFriendSpeed, int secondFriendSpeed, int dogSpeed, bool toFirst = false,  int count = 0) 
{
    int time = 0;
    if (distance <= 10) {return count;}
    if (toFirst) {
        time = distance / (secondFriendSpeed + dogSpeed);
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
    }
    
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    Console.WriteLine("count = " + count + "  test = " + (2 * (int) (count / 2))); 
    return dogRun(distance, firstFriendSpeed, secondFriendSpeed, dogSpeed, ! toFirst, count+1);
}


Console.WriteLine(dogRun(100000,1,2,5));
