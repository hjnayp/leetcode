namespace source._2700._2739;

public class Solution
{
    public int DistanceTraveled(int mainTank, int additionalTank)
    {
        int addedFuel = Math.Min(additionalTank, (int)Math.Floor((mainTank - 1) / 4.0));
        return mainTank * 10 + addedFuel * 10;
    }
}