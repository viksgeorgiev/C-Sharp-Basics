
double energy = double.Parse(Console.ReadLine());
double roundedEnergy = Math.Round(energy, 2);

string input = string.Empty;

int artifactPieces = 0;
int mountainPasses = 0;
bool isDead = false;
bool artifactFound = false;

while ((input = Console.ReadLine()) != "Journey ends here!")
{
    string terrains = input;

	switch (terrains)
	{
		case "mountain":
            roundedEnergy -= 10;
            mountainPasses++;
            if (mountainPasses % 3 == 0)
            {
                artifactPieces++;
            }
            break;
        case "desert":
            roundedEnergy -= 15;
            break;
        case "forest":
            roundedEnergy += 7;
            break;
    }

    if (artifactPieces == 3)
    {
        artifactFound = true;
        break;
    }

    if (roundedEnergy <= 0)
    {
        isDead = true;
        break;
    }

    
    
}

if (artifactFound)
{
    Console.WriteLine($"The character reached the legendary artifact with {roundedEnergy:F2} energy left.");
}
else if(isDead)
{
    Console.WriteLine($"The character is too exhausted to carry on with the journey.");
}
else
{
    Console.WriteLine($"The character could not find all the pieces and needs {3 - artifactPieces} more to complete the legendary artifact.");
}