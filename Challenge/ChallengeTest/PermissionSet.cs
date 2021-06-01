namespace ChallengeTest
{
    public class PermissionSet
    {
        public bool[] UserPermissions = new bool[100];

        //For testing
        public void SetPermissions()
        {
            for (int i = 0; i < 100; i++)
                 UserPermissions[i] = i % 2 == 0;
        }
    }
}