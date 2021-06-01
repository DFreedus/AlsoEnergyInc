using System.IO;
using ProtoBuf;

namespace ChallengeTest
{
    /// <summary>
    /// Was intending on using BinaryFormatter" to achieve this but according to Microsoft it's
    /// unsafe, shouldnt be used, and is going to be removed. ProtoBuf seems to have been adopted
    /// as it's replacement and is very performant.
    /// </summary>
    public static class ByteSerialization
    {
        public static byte[] Serialize<T>(T record) where T : class
        {
            if (record == null) 
                return null;
            
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, record);
                return stream.ToArray();
            }
        }

        public static T Deserialize<T>(byte[] data) where T : class
        {
            if (data == null)
                return null;

            using (var stream = new MemoryStream(data))
            {
                return Serializer.Deserialize<T>(stream);
            }
        }
    }
}
