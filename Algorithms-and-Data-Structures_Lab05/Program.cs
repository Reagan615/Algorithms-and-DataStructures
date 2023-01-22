Queue<string> playList = new Queue<string>();
string[] playAry = new string[playList.Count];

bool continueRunning = true;

while (continueRunning)
{
    Console.WriteLine("1. Add a song to your playlist or 2. Play the next song in your playlist or 3.Skip the next song or 4.Rewind one song or 5.Exit");
    int option = Int32.Parse(Console.ReadLine());

    if (option == 5)
    {
        continueRunning = false;
    }
    while (option == 1)
    {
        Console.WriteLine("Enter Song Name: ");
        string songName = Console.ReadLine();
        playList.Enqueue(songName);

        Console.WriteLine($"{songName} added to your playlist.");
        Console.WriteLine($"Next song - {playList.Peek()}");
        Console.WriteLine("1. Add a song to your playlist or 2. Play the next song in your playlist or 3.Skip the next song or 4.Rewind one song");
        option = Int32.Parse(Console.ReadLine());

    }
    int i = 0;
    int j = 0;
    while (option == 2)
    {
        playAry = playList.ToArray();


        if (i < playAry.Length - 1)
        {
            Console.WriteLine($"Now playing - {playAry[i]}");
            Console.WriteLine($"Next song - {playAry[i + 1]}");
            j = i;
            i++;

        }
        else
        {

            Console.WriteLine($"Now playing - {playAry[playAry.Length - 1]}");
            Console.WriteLine($"Next song - none queued");
        }

        Console.WriteLine("1. Add a song to your playlist or 2. Play the next song in your playlist or 3.Skip the next song or 4.Rewind one song");
        option = Int32.Parse(Console.ReadLine());
    }

    while (option == 3)
    {
        playAry = playList.ToArray();

        if (j < playAry.Length - 2)
        {

            Console.WriteLine($"Now playing - {playAry[j]}");
            Console.WriteLine($"Next song - {playAry[j + 2]}");
            i++;
        }
        else
        {
            Console.WriteLine($"Now playing - {playAry[j]}");
            Console.WriteLine($"Next song - none queued");
        }

        Console.WriteLine("1. Add a song to your playlist or 2. Play the next song in your playlist or 3.Skip the next song or 4.Rewind one song");
        option = Int32.Parse(Console.ReadLine());
    }

    while (option == 4)
    {
        playAry = playList.ToArray();

        if (j >= 1)
        {
            Console.WriteLine($"Now playing - {playAry[j - 1]}");
            Console.WriteLine($"Next song - {playAry[j]}");
            j--;
        }
        else
        {
            Console.WriteLine($"It's already the first song");
            Console.WriteLine($"Now playing - {playAry[0]}");

        }
        Console.WriteLine("1. Add a song to your playlist or 2. Play the next song in your playlist or 3.Skip the next song or 4.Rewind one song");
        option = Int32.Parse(Console.ReadLine());

    }
}
