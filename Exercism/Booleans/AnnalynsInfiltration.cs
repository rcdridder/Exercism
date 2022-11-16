namespace Exercism.Booleans
{
    public static class AnnalynsInfiltration
    {
        public static bool CanFastAttack(bool knightIsAwake) => knightIsAwake ? false : true;
        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake ? true : false;
        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => prisonerIsAwake && !archerIsAwake ? true : false;
        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => petDogIsPresent && !archerIsAwake || prisonerIsAwake && !knightIsAwake && !archerIsAwake ? true : false;
    }
}
