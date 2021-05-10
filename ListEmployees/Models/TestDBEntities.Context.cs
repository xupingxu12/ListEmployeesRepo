﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListEmployees.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TestDBEntities : DbContext
    {
        public TestDBEntities()
            : base("name=TestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SelectEmployee_Result> SelectEmployee(string lastName, string firstName, Nullable<int> departmentID, Nullable<int> subDepartmentID)
        {
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var subDepartmentIDParameter = subDepartmentID.HasValue ?
                new ObjectParameter("SubDepartmentID", subDepartmentID) :
                new ObjectParameter("SubDepartmentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectEmployee_Result>("SelectEmployee", lastNameParameter, firstNameParameter, departmentIDParameter, subDepartmentIDParameter);
        }
    }
}
