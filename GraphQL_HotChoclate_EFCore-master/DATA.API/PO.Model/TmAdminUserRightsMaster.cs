using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmAdminUserRightsMaster
    {
        public int GroupId { get; set; }
        public int ModuleId { get; set; }
        public int SubModuleId { get; set; }
        public bool CanView { get; set; }
        public bool CanSave { get; set; }
        public bool CanSearch { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public DateTime CreationDate { get; set; }
        public int CuserId { get; set; }
        public DateTime ModificationDate { get; set; }
        public int MuserId { get; set; }
        public int UserCode { get; set; }
        public bool CanExport { get; set; }
        public int Rid { get; set; }
    }


    public partial class CMAdminUserRightsMaster
    {
        public int GroupId { get; set; }
        public int ModuleId { get; set; }
        public int SubModuleId { get; set; }
        public bool CanView { get; set; }
        public bool CanSave { get; set; }
        public bool CanSearch { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public DateTime CreationDate { get; set; }
        public int CuserId { get; set; }
        public DateTime ModificationDate { get; set; }
        public int MuserId { get; set; }
        public int UserCode { get; set; }
        public bool CanExport { get; set; }
        public int Rid { get; set; }
    }




    public partial class CMWebUserRightsMaster
    {
        public int GroupId { get; set; }
        public int ModuleId { get; set; }
        public int SubModuleId { get; set; }
        public bool CanView { get; set; }
        public bool CanSave { get; set; }
        public bool CanSearch { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public DateTime CreationDate { get; set; }
        public int CuserId { get; set; }
        public DateTime ModificationDate { get; set; }
        public int MuserId { get; set; }
       
        public int UserCode { get; set; }
        public bool CanExport { get; set; }
        [Key]
        public int Rid { get; set; }
    }


}
