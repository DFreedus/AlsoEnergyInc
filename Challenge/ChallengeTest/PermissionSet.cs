using ProtoBuf;

namespace ChallengeTest
{
    [ProtoContract(SkipConstructor = true)]
    public class PermissionSet
    {
        [ProtoMember(1)]
        public bool[] UserPermissions = new bool[100];

        //For testing serialization
        public void SetPermissions()
        {
            for (int i = 0; i < 100; i++)
                 UserPermissions[i] = i % 2 == 0;
        }
    }
}