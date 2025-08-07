using System.ServiceModel;
namespace SoapServices
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string GetServerState(bool includeEnvironment,bool includeDisks);
        [OperationContract]
        int[] GetLargeRandoms();
    }
}
