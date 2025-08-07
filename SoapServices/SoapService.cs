using System.Text;

namespace SoapServices
{
    public class SoapService:ISoapService
    {
        public string GetServerState(bool includeEnvironment,bool includeDisks)
        {
            StringBuilder stringBuilder = new(128);
            if (includeEnvironment)
            {
                stringBuilder.AppendLine(Environment.ProcessorCount + ";" + Environment.MachineName + ";" + Environment.UserName);
                if (includeDisks)
                {
                    stringBuilder.AppendLine(";"+DriveInfo.GetDrives()[0].AvailableFreeSpace);
                }
            }
            return stringBuilder.ToString();
        }
        public int[] GetLargeRandoms()
        {
            Random random = new();
            int[] res = new int[100];
            for(int i = 0; i < 100; i++)
            {
                res[i] = random.Next();
            }
            return res;
        }
    }
}
