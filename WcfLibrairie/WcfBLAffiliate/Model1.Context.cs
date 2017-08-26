﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfBLAffiliate
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ExamSGBD2017Entities : DbContext
    {
        public ExamSGBD2017Entities()
            : base("name=ExamSGBD2017Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vAffiliate> vAffiliates { get; set; }
        public virtual DbSet<vAuthor> vAuthors { get; set; }
        public virtual DbSet<vEmpruntDetail> vEmpruntDetails { get; set; }
        public virtual DbSet<vItemDetail> vItemDetails { get; set; }
        public virtual DbSet<vLibrary> vLibraries { get; set; }
        public virtual DbSet<vVolume> vVolumes { get; set; }
        public virtual DbSet<vWishlist> vWishlists { get; set; }
    
        public virtual int DeleteWishById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteWishById", idParameter);
        }
    
        public virtual ObjectResult<GetAffiliateByCardNum_Result> GetAffiliateByCardNum(Nullable<int> number)
        {
            var numberParameter = number.HasValue ?
                new ObjectParameter("number", number) :
                new ObjectParameter("number", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAffiliateByCardNum_Result>("GetAffiliateByCardNum", numberParameter);
        }
    
        public virtual ObjectResult<GetAffiliateByName_Result> GetAffiliateByName(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAffiliateByName_Result>("GetAffiliateByName", firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<GetAllVolumes_Result> GetAllVolumes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllVolumes_Result>("GetAllVolumes");
        }
    
        public virtual ObjectResult<GetAuthorByVolumeIsbn_Result> GetAuthorByVolumeIsbn(string volumeIsbn)
        {
            var volumeIsbnParameter = volumeIsbn != null ?
                new ObjectParameter("VolumeIsbn", volumeIsbn) :
                new ObjectParameter("VolumeIsbn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAuthorByVolumeIsbn_Result>("GetAuthorByVolumeIsbn", volumeIsbnParameter);
        }
    
        public virtual ObjectResult<GetEmpruntByAffiliate_Result> GetEmpruntByAffiliate(Nullable<int> id, Nullable<bool> selectClosed)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var selectClosedParameter = selectClosed.HasValue ?
                new ObjectParameter("SelectClosed", selectClosed) :
                new ObjectParameter("SelectClosed", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmpruntByAffiliate_Result>("GetEmpruntByAffiliate", idParameter, selectClosedParameter);
        }
    
        public virtual ObjectResult<GetEmpruntByCode_Result> GetEmpruntByCode(Nullable<int> code, Nullable<bool> selectClosed)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(int));
    
            var selectClosedParameter = selectClosed.HasValue ?
                new ObjectParameter("SelectClosed", selectClosed) :
                new ObjectParameter("SelectClosed", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmpruntByCode_Result>("GetEmpruntByCode", codeParameter, selectClosedParameter);
        }
    
        public virtual ObjectResult<GetEmpruntById_Result> GetEmpruntById(Nullable<int> id, Nullable<bool> selectClosed)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var selectClosedParameter = selectClosed.HasValue ?
                new ObjectParameter("SelectClosed", selectClosed) :
                new ObjectParameter("SelectClosed", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmpruntById_Result>("GetEmpruntById", idParameter, selectClosedParameter);
        }
    
        public virtual ObjectResult<GetItemByVol_Result> GetItemByVol(Nullable<int> idvol)
        {
            var idvolParameter = idvol.HasValue ?
                new ObjectParameter("Idvol", idvol) :
                new ObjectParameter("Idvol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetItemByVol_Result>("GetItemByVol", idvolParameter);
        }
    
        public virtual ObjectResult<GetLibraries_Result> GetLibraries()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetLibraries_Result>("GetLibraries");
        }
    
        public virtual ObjectResult<GetVolumeById_Result> GetVolumeById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetVolumeById_Result>("GetVolumeById", idParameter);
        }
    
        public virtual ObjectResult<GetVolumeByIsbn_Result> GetVolumeByIsbn(string isbn)
        {
            var isbnParameter = isbn != null ?
                new ObjectParameter("isbn", isbn) :
                new ObjectParameter("isbn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetVolumeByIsbn_Result>("GetVolumeByIsbn", isbnParameter);
        }
    
        public virtual ObjectResult<GetVolumeByTitle_Result> GetVolumeByTitle(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetVolumeByTitle_Result>("GetVolumeByTitle", titleParameter);
        }
    
        public virtual ObjectResult<GetWishlist_Result> GetWishlist(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetWishlist_Result>("GetWishlist", idParameter);
        }
    
        public virtual int InsertWish(Nullable<int> cardNum, Nullable<int> volume_Id)
        {
            var cardNumParameter = cardNum.HasValue ?
                new ObjectParameter("CardNum", cardNum) :
                new ObjectParameter("CardNum", typeof(int));
    
            var volume_IdParameter = volume_Id.HasValue ?
                new ObjectParameter("Volume_Id", volume_Id) :
                new ObjectParameter("Volume_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertWish", cardNumParameter, volume_IdParameter);
        }
    }
}