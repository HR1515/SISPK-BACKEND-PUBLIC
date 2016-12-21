﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISPK.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SISPKEntities : DbContext
    {
        public SISPKEntities()
            : base("name=SISPKEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BACKUP_TP_DETAILS> BACKUP_TP_DETAILS { get; set; }
        public DbSet<MASTER_KA_BACKUP> MASTER_KA_BACKUP { get; set; }
        public DbSet<SYS_ACCESS_DETAIL_BK> SYS_ACCESS_DETAIL_BK { get; set; }
        public DbSet<SYS_MENU_copy> SYS_MENU_copy { get; set; }
        public DbSet<TRX_POLLING_DETAILS_copy> TRX_POLLING_DETAILS_copy { get; set; }
        public DbSet<TRX_SNI_copy> TRX_SNI_copy { get; set; }
        public DbSet<DN_VW_UPDATE_SNI> DN_VW_UPDATE_SNI { get; set; }
        public DbSet<MASTER_ACUAN_NON_SNI> MASTER_ACUAN_NON_SNI { get; set; }
        public DbSet<MASTER_BIBLIOGRAFI> MASTER_BIBLIOGRAFI { get; set; }
        public DbSet<MASTER_BIDANG> MASTER_BIDANG { get; set; }
        public DbSet<MASTER_DOC_REFERENCES> MASTER_DOC_REFERENCES { get; set; }
        public DbSet<MASTER_FILETYPES> MASTER_FILETYPES { get; set; }
        public DbSet<MASTER_FOLDERS> MASTER_FOLDERS { get; set; }
        public DbSet<MASTER_ICS> MASTER_ICS { get; set; }
        public DbSet<MASTER_INSTANSI> MASTER_INSTANSI { get; set; }
        public DbSet<MASTER_KOMITE_TEKNIS> MASTER_KOMITE_TEKNIS { get; set; }
        public DbSet<MASTER_KOMTEK_ANGGOTA> MASTER_KOMTEK_ANGGOTA { get; set; }
        public DbSet<MASTER_KOMTEK_ICS> MASTER_KOMTEK_ICS { get; set; }
        public DbSet<MASTER_REFERENCES> MASTER_REFERENCES { get; set; }
        public DbSet<MASTER_SCOPE> MASTER_SCOPE { get; set; }
        public DbSet<MASTER_SNI_STYLE> MASTER_SNI_STYLE { get; set; }
        public DbSet<MASTER_TAS> MASTER_TAS { get; set; }
        public DbSet<MASTER_TAS_DETAIL_ICS> MASTER_TAS_DETAIL_ICS { get; set; }
        public DbSet<MASTER_TAS_EDUCATION> MASTER_TAS_EDUCATION { get; set; }
        public DbSet<MASTER_TAS_RIWAYAT> MASTER_TAS_RIWAYAT { get; set; }
        public DbSet<MASTER_WILAYAH> MASTER_WILAYAH { get; set; }
        public DbSet<PORTAL_NEWS> PORTAL_NEWS { get; set; }
        public DbSet<PORTAL_PROFILE> PORTAL_PROFILE { get; set; }
        public DbSet<PORTAL_SLIDER> PORTAL_SLIDER { get; set; }
        public DbSet<SYS_ACCESS> SYS_ACCESS { get; set; }
        public DbSet<SYS_ACCESS_DETAIL> SYS_ACCESS_DETAIL { get; set; }
        public DbSet<SYS_CONFIG> SYS_CONFIG { get; set; }
        public DbSet<SYS_DOC_ACCESS> SYS_DOC_ACCESS { get; set; }
        public DbSet<SYS_DOC_ACCESS_DETAIL> SYS_DOC_ACCESS_DETAIL { get; set; }
        public DbSet<SYS_EMAIL> SYS_EMAIL { get; set; }
        public DbSet<SYS_HIT_COUNTERS> SYS_HIT_COUNTERS { get; set; }
        public DbSet<SYS_LINK> SYS_LINK { get; set; }
        public DbSet<SYS_LOGS> SYS_LOGS { get; set; }
        public DbSet<SYS_MENU> SYS_MENU { get; set; }
        public DbSet<SYS_NOTIF> SYS_NOTIF { get; set; }
        public DbSet<SYS_USER> SYS_USER { get; set; }
        public DbSet<SYS_USER_INTERN> SYS_USER_INTERN { get; set; }
        public DbSet<SYS_USER_PUBLIC> SYS_USER_PUBLIC { get; set; }
        public DbSet<T_MASTER_KOMITE_TEKNIS> T_MASTER_KOMITE_TEKNIS { get; set; }
        public DbSet<T_MASTER_KOMTEK_ICS> T_MASTER_KOMTEK_ICS { get; set; }
        public DbSet<TRX_AKTIF_SNI_REV> TRX_AKTIF_SNI_REV { get; set; }
        public DbSet<TRX_DOC_RELATEDS> TRX_DOC_RELATEDS { get; set; }
        public DbSet<TRX_DOCUMENTS> TRX_DOCUMENTS { get; set; }
        public DbSet<TRX_LOG_JOB> TRX_LOG_JOB { get; set; }
        public DbSet<TRX_LPK> TRX_LPK { get; set; }
        public DbSet<TRX_LPK_DETAIL> TRX_LPK_DETAIL { get; set; }
        public DbSet<TRX_LPK_DETAIL_SNI> TRX_LPK_DETAIL_SNI { get; set; }
        public DbSet<TRX_LPK_SCOPE> TRX_LPK_SCOPE { get; set; }
        public DbSet<TRX_MAINTENANCE_DETAILS> TRX_MAINTENANCE_DETAILS { get; set; }
        public DbSet<TRX_MAINTENANCES> TRX_MAINTENANCES { get; set; }
        public DbSet<TRX_MONITORING> TRX_MONITORING { get; set; }
        public DbSet<TRX_POLLING> TRX_POLLING { get; set; }
        public DbSet<TRX_POLLING_DETAILS> TRX_POLLING_DETAILS { get; set; }
        public DbSet<TRX_PROPOSAL> TRX_PROPOSAL { get; set; }
        public DbSet<TRX_PROPOSAL_ADOPSI> TRX_PROPOSAL_ADOPSI { get; set; }
        public DbSet<TRX_PROPOSAL_APPROVAL> TRX_PROPOSAL_APPROVAL { get; set; }
        public DbSet<TRX_PROPOSAL_ICS_REF> TRX_PROPOSAL_ICS_REF { get; set; }
        public DbSet<TRX_PROPOSAL_RAPAT> TRX_PROPOSAL_RAPAT { get; set; }
        public DbSet<TRX_PROPOSAL_REFERENCE> TRX_PROPOSAL_REFERENCE { get; set; }
        public DbSet<TRX_PROPOSAL_REV> TRX_PROPOSAL_REV { get; set; }
        public DbSet<TRX_REGULASI_TEKNIS> TRX_REGULASI_TEKNIS { get; set; }
        public DbSet<TRX_REGULASI_TEKNIS_DETAIL> TRX_REGULASI_TEKNIS_DETAIL { get; set; }
        public DbSet<TRX_SK_PENETAPAN> TRX_SK_PENETAPAN { get; set; }
        public DbSet<TRX_SNI> TRX_SNI { get; set; }
        public DbSet<TRX_SNI_DOC> TRX_SNI_DOC { get; set; }
        public DbSet<TRX_SNI_SK> TRX_SNI_SK { get; set; }
        public DbSet<TRX_SNI_VALUATIONS> TRX_SNI_VALUATIONS { get; set; }
        public DbSet<TRX_SURAT_TUGAS> TRX_SURAT_TUGAS { get; set; }
        public DbSet<TRX_UPDATE_SNI_REV_HIST> TRX_UPDATE_SNI_REV_HIST { get; set; }
        public DbSet<SYS_DOC_ACCESS_DETAIL_SELECT> SYS_DOC_ACCESS_DETAIL_SELECT { get; set; }
        public DbSet<VIEW_ACCESS> VIEW_ACCESS { get; set; }
        public DbSet<VIEW_ACUAN_NON_SNI_SELECT> VIEW_ACUAN_NON_SNI_SELECT { get; set; }
        public DbSet<VIEW_ACUAN_NORMATIVE_ASING> VIEW_ACUAN_NORMATIVE_ASING { get; set; }
        public DbSet<VIEW_ANGGOTA> VIEW_ANGGOTA { get; set; }
        public DbSet<VIEW_ANOR_STANDAR_ASING> VIEW_ANOR_STANDAR_ASING { get; set; }
        public DbSet<VIEW_BIBLIOGRAFI_SELECT> VIEW_BIBLIOGRAFI_SELECT { get; set; }
        public DbSet<VIEW_BIDANG> VIEW_BIDANG { get; set; }
        public DbSet<VIEW_DOC_ACCESS> VIEW_DOC_ACCESS { get; set; }
        public DbSet<VIEW_DOCUMENTS> VIEW_DOCUMENTS { get; set; }
        public DbSet<VIEW_ICS> VIEW_ICS { get; set; }
        public DbSet<VIEW_ICS_SELECT> VIEW_ICS_SELECT { get; set; }
        public DbSet<VIEW_ICS_SNI> VIEW_ICS_SNI { get; set; }
        public DbSet<VIEW_INSTANSI> VIEW_INSTANSI { get; set; }
        public DbSet<VIEW_JAJAK_PENDAPAT> VIEW_JAJAK_PENDAPAT { get; set; }
        public DbSet<VIEW_KOMTEK> VIEW_KOMTEK { get; set; }
        public DbSet<VIEW_KOMTEK_FULL> VIEW_KOMTEK_FULL { get; set; }
        public DbSet<VIEW_KOMTEK_ICS> VIEW_KOMTEK_ICS { get; set; }
        public DbSet<VIEW_KOMTEK_TEMP> VIEW_KOMTEK_TEMP { get; set; }
        public DbSet<VIEW_LOG> VIEW_LOG { get; set; }
        public DbSet<VIEW_LPK> VIEW_LPK { get; set; }
        public DbSet<VIEW_LPK_DETAIL> VIEW_LPK_DETAIL { get; set; }
        public DbSet<VIEW_LPK_SCOPE> VIEW_LPK_SCOPE { get; set; }
        public DbSet<VIEW_LPK_SELECT> VIEW_LPK_SELECT { get; set; }
        public DbSet<VIEW_LPK_SNI> VIEW_LPK_SNI { get; set; }
        public DbSet<VIEW_MASTER_TAS> VIEW_MASTER_TAS { get; set; }
        public DbSet<VIEW_MENUS> VIEW_MENUS { get; set; }
        public DbSet<VIEW_MONITORING_RSNI> VIEW_MONITORING_RSNI { get; set; }
        public DbSet<VIEW_NEWS> VIEW_NEWS { get; set; }
        public DbSet<VIEW_NOTIF> VIEW_NOTIF { get; set; }
        public DbSet<VIEW_PEMELIHARAAN> VIEW_PEMELIHARAAN { get; set; }
        public DbSet<VIEW_POLLING> VIEW_POLLING { get; set; }
        public DbSet<VIEW_POLLING_DETAIL> VIEW_POLLING_DETAIL { get; set; }
        public DbSet<VIEW_POLLING_SINGLE> VIEW_POLLING_SINGLE { get; set; }
        public DbSet<VIEW_PROPOSAL> VIEW_PROPOSAL { get; set; }
        public DbSet<VIEW_PROPOSAL_DASHBOARD> VIEW_PROPOSAL_DASHBOARD { get; set; }
        public DbSet<VIEW_PROPOSAL_ICS> VIEW_PROPOSAL_ICS { get; set; }
        public DbSet<VIEW_PROPOSAL_RAPAT> VIEW_PROPOSAL_RAPAT { get; set; }
        public DbSet<VIEW_PROPOSAL_RASNI> VIEW_PROPOSAL_RASNI { get; set; }
        public DbSet<VIEW_PROPOSAL_REF> VIEW_PROPOSAL_REF { get; set; }
        public DbSet<VIEW_REGTEK> VIEW_REGTEK { get; set; }
        public DbSet<VIEW_REGTEK_DETAIL> VIEW_REGTEK_DETAIL { get; set; }
        public DbSet<VIEW_REGULASI_TEKNIS_SELECT> VIEW_REGULASI_TEKNIS_SELECT { get; set; }
        public DbSet<VIEW_REKAP_SNI_BY_ICS> VIEW_REKAP_SNI_BY_ICS { get; set; }
        public DbSet<VIEW_REKAP_SNI_BY_KOMTEK> VIEW_REKAP_SNI_BY_KOMTEK { get; set; }
        public DbSet<VIEW_REKAP_SNI_BY_SK_DETAIL> VIEW_REKAP_SNI_BY_SK_DETAIL { get; set; }
        public DbSet<VIEW_RSNI_PORTAL> VIEW_RSNI_PORTAL { get; set; }
        public DbSet<VIEW_SCOPE_SELECT> VIEW_SCOPE_SELECT { get; set; }
        public DbSet<VIEW_SK_PER_SNI> VIEW_SK_PER_SNI { get; set; }
        public DbSet<VIEW_SNI> VIEW_SNI { get; set; }
        public DbSet<VIEW_SNI_ACUAN_NORMATIF> VIEW_SNI_ACUAN_NORMATIF { get; set; }
        public DbSet<VIEW_SNI_ACUAN_NORMATIF_PORTAL> VIEW_SNI_ACUAN_NORMATIF_PORTAL { get; set; }
        public DbSet<VIEW_SNI_ADOPSI_PORTAL> VIEW_SNI_ADOPSI_PORTAL { get; set; }
        public DbSet<VIEW_SNI_FIVE_YEARS> VIEW_SNI_FIVE_YEARS { get; set; }
        public DbSet<VIEW_SNI_REVISI_PORTAL> VIEW_SNI_REVISI_PORTAL { get; set; }
        public DbSet<VIEW_SNI_SELECT> VIEW_SNI_SELECT { get; set; }
        public DbSet<VIEW_SNI_SK> VIEW_SNI_SK { get; set; }
        public DbSet<VIEW_SNI_WAJIB> VIEW_SNI_WAJIB { get; set; }
        public DbSet<VIEW_SUBKOMTEK> VIEW_SUBKOMTEK { get; set; }
        public DbSet<VIEW_T_KOMTEK> VIEW_T_KOMTEK { get; set; }
        public DbSet<VIEW_T_KOMTEK_ICS> VIEW_T_KOMTEK_ICS { get; set; }
        public DbSet<VIEW_TAS_DETAIL_ICS> VIEW_TAS_DETAIL_ICS { get; set; }
        public DbSet<VIEW_USERS> VIEW_USERS { get; set; }
        public DbSet<VIEW_USERS_PUBLIC> VIEW_USERS_PUBLIC { get; set; }
        public DbSet<VIEW_WILAYAH_KABUPATEN> VIEW_WILAYAH_KABUPATEN { get; set; }
        public DbSet<VIEW_WILAYAH_PROVINSI> VIEW_WILAYAH_PROVINSI { get; set; }
    }
}
