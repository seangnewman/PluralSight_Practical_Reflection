﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenericRepository.Service.MyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPeople", ReplyAction="http://tempuri.org/IPersonService/GetPeopleResponse")]
        System.Collections.Generic.List<PeopleViewer.SharedObjects.Person> GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPeople", ReplyAction="http://tempuri.org/IPersonService/GetPeopleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<PeopleViewer.SharedObjects.Person>> GetPeopleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        PeopleViewer.SharedObjects.Person GetPerson(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        System.Threading.Tasks.Task<PeopleViewer.SharedObjects.Person> GetPersonAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        void AddPerson(PeopleViewer.SharedObjects.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(PeopleViewer.SharedObjects.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        void UpdatePerson(string lastName, PeopleViewer.SharedObjects.Person updatedPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(string lastName, PeopleViewer.SharedObjects.Person updatedPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        void DeletePerson(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePeople", ReplyAction="http://tempuri.org/IPersonService/UpdatePeopleResponse")]
        void UpdatePeople(System.Collections.Generic.List<PeopleViewer.SharedObjects.Person> updatedPeople);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePeople", ReplyAction="http://tempuri.org/IPersonService/UpdatePeopleResponse")]
        System.Threading.Tasks.Task UpdatePeopleAsync(System.Collections.Generic.List<PeopleViewer.SharedObjects.Person> updatedPeople);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : GenericRepository.Service.MyService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<GenericRepository.Service.MyService.IPersonService>, GenericRepository.Service.MyService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<PeopleViewer.SharedObjects.Person> GetPeople() {
            return base.Channel.GetPeople();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<PeopleViewer.SharedObjects.Person>> GetPeopleAsync() {
            return base.Channel.GetPeopleAsync();
        }
        
        public PeopleViewer.SharedObjects.Person GetPerson(string lastName) {
            return base.Channel.GetPerson(lastName);
        }
        
        public System.Threading.Tasks.Task<PeopleViewer.SharedObjects.Person> GetPersonAsync(string lastName) {
            return base.Channel.GetPersonAsync(lastName);
        }
        
        public void AddPerson(PeopleViewer.SharedObjects.Person newPerson) {
            base.Channel.AddPerson(newPerson);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(PeopleViewer.SharedObjects.Person newPerson) {
            return base.Channel.AddPersonAsync(newPerson);
        }
        
        public void UpdatePerson(string lastName, PeopleViewer.SharedObjects.Person updatedPerson) {
            base.Channel.UpdatePerson(lastName, updatedPerson);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(string lastName, PeopleViewer.SharedObjects.Person updatedPerson) {
            return base.Channel.UpdatePersonAsync(lastName, updatedPerson);
        }
        
        public void DeletePerson(string lastName) {
            base.Channel.DeletePerson(lastName);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(string lastName) {
            return base.Channel.DeletePersonAsync(lastName);
        }
        
        public void UpdatePeople(System.Collections.Generic.List<PeopleViewer.SharedObjects.Person> updatedPeople) {
            base.Channel.UpdatePeople(updatedPeople);
        }
        
        public System.Threading.Tasks.Task UpdatePeopleAsync(System.Collections.Generic.List<PeopleViewer.SharedObjects.Person> updatedPeople) {
            return base.Channel.UpdatePeopleAsync(updatedPeople);
        }
    }
}
