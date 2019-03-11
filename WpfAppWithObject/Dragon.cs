using System;

public class Dragon
{

    public int horde { get; private set; }
    public int stamina { get; private set; }

	public Dragon()
	{
        horde = 0;
        stamina = 100;
	}

    public void Raid()
    {
        if(stamina - 10 >= 0)
        {
            stamina -= 10;
            horde += 100;
        }
    }

    public void Rest()
    {
        if(stamina + 10 <= 100)
        {
            stamina += 10;
        }
    }
}
