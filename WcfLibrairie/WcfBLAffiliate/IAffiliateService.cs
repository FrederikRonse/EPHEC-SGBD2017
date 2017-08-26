using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessObjects;

namespace WcfBLAffiliate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAffiliateService
    {
        [OperationContract]
        [FaultContract(typeof(CustomFault))]
        bool CheckIn(string login, string password);



        /// Operations "Get"
        [OperationContract]
        [FaultContract(typeof(CustomFault))]
         vAffiliate GetAffiliateById(int lectId);

        [OperationContract]
        [FaultContract(typeof(CustomFault))]
        vAffiliate GetAffiliateByName(string FirstName, string lastName);

        [OperationContract]
        [FaultContract(typeof(CustomFault))]
        List<vEmpruntDetail> GetEmpruntsByAffiliate(int lectId);

        [OperationContract]
        [FaultContract(typeof(CustomFault))]
        vEmpruntDetail GetEmpruntByCode(string code);

        [OperationContract]
        [FaultContract(typeof(CustomFault))]
        List<vEmpruntDetail> GetRetards(DateTime date, int libId);

        [OperationContract]
        [FaultContract(typeof(CustomFault))]
        List<vLibrary> GetLibraries();

        [OperationContract]
        [FaultContract(typeof(CustomFault))]
        List<vVolume> GetAllVolumes( );

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //List<Item> GetItemsByVolume(int volumeId);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //Volume GetVolumeDetails(int volumeId);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //Volume GetVolumeDetailsByIsbn(string isbn);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //Volume GetVolumeByTitle(string titleLike);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //List<Volume> GetVolumesByTitle(string titleLike);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //List<Tarif> GetTarifsByLib(int libraryId);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //List<Author> GetAllAuthorsNames();



        ///// Operations "Set"
        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //void AddVolume(Volume volumeToAdd);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //void UpdateVolume(Volume volumeToUpdate);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //void DeleteVolume(Volume volumeToDelete);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //void AddItem(Item itemToAdd);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //void UpdateItem(Item itemToUpdate);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //void DeleteItem(Item itemToDelete);

        //[OperationContract]
        //[FaultContract(typeof(CustomFault))]
        //void CloseEmprunt(int EmpruntToCloseID, DateTime LastModified);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfLibrairie.ContractType".
    [DataContract]
    public class CustomFault
    {
        private string _message;
        public CustomFault(string message)
        {
            _message = message;
        }
        [DataMember]
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}
