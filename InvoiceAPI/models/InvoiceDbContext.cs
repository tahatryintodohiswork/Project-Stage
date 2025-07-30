using System;
using System.Collections.Generic;
using InvoiceAPI.models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceAPI.Data;

public partial class InvoiceDbContext : DbContext
{
    public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<SINVOICE> SINVOICEs { get; set; }
    public virtual DbSet<SINVOICED> SINVOICEDs { get; set; }
    public virtual DbSet<SINVOICEV> SINVOICEVs { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_BIN2");
        modelBuilder.Entity<SINVOICED>()
            .HasOne(d => d.Invoice)
            .WithMany(i => i.Details)
            .HasForeignKey(d => d.NUM_0)
            .HasPrincipalKey(i => i.NUM_0);
        modelBuilder.Entity<SINVOICE>(entity =>
        {
            entity.HasKey(e => e.ROWID)
                .HasName("SINVOICE_ROWID")
                .IsClustered(false);

            entity.ToTable("SINVOICE", "UAS", tb => tb.HasTrigger("SINVOICE_UPDTICK"));

            entity.HasIndex(e => e.NUM_0, "SINVOICE_SIH0").IsUnique();

            entity.HasIndex(e => new { e.BPR_0, e.BPRVCR_0 }, "SINVOICE_SIH1");

            entity.HasIndex(e => new { e.GTE_0, e.NUM_0 }, "SINVOICE_SIH2").IsUnique();

            entity.HasIndex(e => new { e.ACCDAT_0, e.BPR_0 }, "SINVOICE_SIH3");

            entity.HasIndex(e => new { e.BPRFCT_0, e.FCTVCR_0, e.FCTVCRFLG_0 }, "SINVOICE_SIH4");

            entity.HasIndex(e => new { e.CUR_0, e.BPR_0, e.NUM_0 }, "SINVOICE_SIH5").IsUnique();

            entity.HasIndex(e => new { e.STA_0, e.ORIMOD_0, e.INVTYP_0, e.NUM_0 }, "SINVOICE_SIH6");

            entity.HasIndex(e => new { e.CPY_0, e.EECNUMDEB_0, e.ACCDAT_0 }, "SINVOICE_SIH7");

            entity.HasIndex(e => new { e.RCRNUM_0, e.RCRDAT_0 }, "SINVOICE_SIH8");

            entity.HasIndex(e => e.ACCDAT_0, "SINVOICE_XSIH0");

            entity.Property(e => e.ROWID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)");
            entity.Property(e => e.ACCDAT_0).HasColumnType("datetime");
            entity.Property(e => e.AMTATIL_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTATI_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTNOTL_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTNOT_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAXUSA_0).HasColumnType("numeric(28, 8)");
            entity.Property(e => e.AMTTAX_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_1).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_2).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_3).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_4).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_5).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_6).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_7).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_8).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAX_9).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AUUID_0)
                .HasMaxLength(16)
                .IsFixedLength();
            entity.Property(e => e.BASDEP_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_1).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_2).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_3).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_4).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_5).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_6).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_7).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_8).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAX_9).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BELVCS_0).HasMaxLength(10);
            entity.Property(e => e.BILVCR_0).HasMaxLength(20);
            entity.Property(e => e.BPAADDLIG_0).HasMaxLength(50);
            entity.Property(e => e.BPAADDLIG_1).HasMaxLength(50);
            entity.Property(e => e.BPAADDLIG_2).HasMaxLength(50);
            entity.Property(e => e.BPAINV_0).HasMaxLength(5);
            entity.Property(e => e.BPAPAY_0).HasMaxLength(5);
            entity.Property(e => e.BPRDAT_0).HasColumnType("datetime");
            entity.Property(e => e.BPRFCT_0).HasMaxLength(15);
            entity.Property(e => e.BPRNAM_0).HasMaxLength(35);
            entity.Property(e => e.BPRNAM_1).HasMaxLength(35);
            entity.Property(e => e.BPRPAY_0).HasMaxLength(15);
            entity.Property(e => e.BPRSAC_0).HasMaxLength(12);
            entity.Property(e => e.BPRVCR_0).HasMaxLength(30);
            entity.Property(e => e.BPR_0).HasMaxLength(15);
            entity.Property(e => e.BPYADDLIG_0).HasMaxLength(50);
            entity.Property(e => e.BPYADDLIG_1).HasMaxLength(50);
            entity.Property(e => e.BPYADDLIG_2).HasMaxLength(50);
            entity.Property(e => e.BPYCRYNAM_0).HasMaxLength(40);
            entity.Property(e => e.BPYCRY_0).HasMaxLength(3);
            entity.Property(e => e.BPYCTY_0).HasMaxLength(40);
            entity.Property(e => e.BPYNAM_0).HasMaxLength(35);
            entity.Property(e => e.BPYNAM_1).HasMaxLength(35);
            entity.Property(e => e.BPYPOSCOD_0).HasMaxLength(10);
            entity.Property(e => e.BPYSAT_0).HasMaxLength(35);
            entity.Property(e => e.BUSPROTYP_0).HasMaxLength(10);
            entity.Property(e => e.BVRREFNUM_0).HasMaxLength(10);
            entity.Property(e => e.CAI_0).HasMaxLength(10);
            entity.Property(e => e.CCE_0).HasMaxLength(15);
            entity.Property(e => e.CCE_1).HasMaxLength(15);
            entity.Property(e => e.CCE_10).HasMaxLength(15);
            entity.Property(e => e.CCE_11).HasMaxLength(15);
            entity.Property(e => e.CCE_12).HasMaxLength(15);
            entity.Property(e => e.CCE_13).HasMaxLength(15);
            entity.Property(e => e.CCE_14).HasMaxLength(15);
            entity.Property(e => e.CCE_15).HasMaxLength(15);
            entity.Property(e => e.CCE_16).HasMaxLength(15);
            entity.Property(e => e.CCE_17).HasMaxLength(15);
            entity.Property(e => e.CCE_18).HasMaxLength(15);
            entity.Property(e => e.CCE_19).HasMaxLength(15);
            entity.Property(e => e.CCE_2).HasMaxLength(15);
            entity.Property(e => e.CCE_3).HasMaxLength(15);
            entity.Property(e => e.CCE_4).HasMaxLength(15);
            entity.Property(e => e.CCE_5).HasMaxLength(15);
            entity.Property(e => e.CCE_6).HasMaxLength(15);
            entity.Property(e => e.CCE_7).HasMaxLength(15);
            entity.Property(e => e.CCE_8).HasMaxLength(15);
            entity.Property(e => e.CCE_9).HasMaxLength(15);
            entity.Property(e => e.CPY_0).HasMaxLength(5);
            entity.Property(e => e.CREDATTIM_0).HasColumnType("datetime");
            entity.Property(e => e.CREDAT_0).HasColumnType("datetime");
            entity.Property(e => e.CREUSR_0).HasMaxLength(5);
            entity.Property(e => e.CRN_0).HasMaxLength(20);
            entity.Property(e => e.CRYNAM_0).HasMaxLength(40);
            entity.Property(e => e.CRY_0).HasMaxLength(3);
            entity.Property(e => e.CTY_0).HasMaxLength(40);
            entity.Property(e => e.CURLED_0).HasMaxLength(3);
            entity.Property(e => e.CURLED_1).HasMaxLength(3);
            entity.Property(e => e.CURLED_2).HasMaxLength(3);
            entity.Property(e => e.CURLED_3).HasMaxLength(3);
            entity.Property(e => e.CURLED_4).HasMaxLength(3);
            entity.Property(e => e.CURLED_5).HasMaxLength(3);
            entity.Property(e => e.CURLED_6).HasMaxLength(3);
            entity.Property(e => e.CURLED_7).HasMaxLength(3);
            entity.Property(e => e.CURLED_8).HasMaxLength(3);
            entity.Property(e => e.CURLED_9).HasMaxLength(3);
            entity.Property(e => e.CUR_0).HasMaxLength(3);
            entity.Property(e => e.DATVLYCAI_0).HasColumnType("datetime");
            entity.Property(e => e.DCLEECNUM_0).HasMaxLength(10);
            entity.Property(e => e.DEPRAT_0).HasColumnType("numeric(8, 3)");
            entity.Property(e => e.DEP_0).HasMaxLength(5);
            entity.Property(e => e.DES_0).HasMaxLength(70);
            entity.Property(e => e.DES_1).HasMaxLength(70);
            entity.Property(e => e.DES_2).HasMaxLength(70);
            entity.Property(e => e.DES_3).HasMaxLength(70);
            entity.Property(e => e.DES_4).HasMaxLength(70);
            entity.Property(e => e.DIE_0).HasMaxLength(3);
            entity.Property(e => e.DIE_1).HasMaxLength(3);
            entity.Property(e => e.DIE_10).HasMaxLength(3);
            entity.Property(e => e.DIE_11).HasMaxLength(3);
            entity.Property(e => e.DIE_12).HasMaxLength(3);
            entity.Property(e => e.DIE_13).HasMaxLength(3);
            entity.Property(e => e.DIE_14).HasMaxLength(3);
            entity.Property(e => e.DIE_15).HasMaxLength(3);
            entity.Property(e => e.DIE_16).HasMaxLength(3);
            entity.Property(e => e.DIE_17).HasMaxLength(3);
            entity.Property(e => e.DIE_18).HasMaxLength(3);
            entity.Property(e => e.DIE_19).HasMaxLength(3);
            entity.Property(e => e.DIE_2).HasMaxLength(3);
            entity.Property(e => e.DIE_3).HasMaxLength(3);
            entity.Property(e => e.DIE_4).HasMaxLength(3);
            entity.Property(e => e.DIE_5).HasMaxLength(3);
            entity.Property(e => e.DIE_6).HasMaxLength(3);
            entity.Property(e => e.DIE_7).HasMaxLength(3);
            entity.Property(e => e.DIE_8).HasMaxLength(3);
            entity.Property(e => e.DIE_9).HasMaxLength(3);
            entity.Property(e => e.ENDDATSVC_0).HasColumnType("datetime");
            entity.Property(e => e.EXEAMTTAX_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_1).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_2).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_3).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_4).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_5).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_6).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_7).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_8).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.EXEAMTTAX_9).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.FCTVCR_0).HasMaxLength(20);
            entity.Property(e => e.FCY_0).HasMaxLength(5);
            entity.Property(e => e.FLD40REN_0).HasMaxLength(10);
            entity.Property(e => e.FLD41REN_0).HasMaxLength(10);
            entity.Property(e => e.GTE_0).HasMaxLength(5);
            entity.Property(e => e.INVNUM_0).HasMaxLength(20);
            entity.Property(e => e.JOU_0).HasMaxLength(5);
            entity.Property(e => e.LASDATSVC_0).HasColumnType("datetime");
            entity.Property(e => e.LED_0).HasMaxLength(3);
            entity.Property(e => e.LED_1).HasMaxLength(3);
            entity.Property(e => e.LED_2).HasMaxLength(3);
            entity.Property(e => e.LED_3).HasMaxLength(3);
            entity.Property(e => e.LED_4).HasMaxLength(3);
            entity.Property(e => e.LED_5).HasMaxLength(3);
            entity.Property(e => e.LED_6).HasMaxLength(3);
            entity.Property(e => e.LED_7).HasMaxLength(3);
            entity.Property(e => e.LED_8).HasMaxLength(3);
            entity.Property(e => e.LED_9).HasMaxLength(3);
            entity.Property(e => e.NUM_0).HasMaxLength(20);
            entity.Property(e => e.ORIDOCNUM_0).HasMaxLength(10);
            entity.Property(e => e.PAYBAN_0).HasMaxLength(10);
            entity.Property(e => e.PERDEB_0).HasColumnType("datetime");
            entity.Property(e => e.PERFIN_0).HasColumnType("datetime");
            entity.Property(e => e.PJTH_0).HasMaxLength(10);
            entity.Property(e => e.POREXPDCL_0).HasMaxLength(10);
            entity.Property(e => e.POSCOD_0).HasMaxLength(10);
            entity.Property(e => e.PTE_0).HasMaxLength(15);
            entity.Property(e => e.RATDAT_0).HasColumnType("datetime");
            entity.Property(e => e.RATDIV_0).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_1).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_2).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_3).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_4).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_5).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_6).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_7).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_8).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATDIV_9).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_0).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_1).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_2).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_3).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_4).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_5).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_6).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_7).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_8).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RATMLT_9).HasColumnType("numeric(21, 10)");
            entity.Property(e => e.RCRDAT_0).HasColumnType("datetime");
            entity.Property(e => e.RCRNUM_0).HasMaxLength(20);
            entity.Property(e => e.SAT_0).HasMaxLength(35);
            entity.Property(e => e.SINUM_0).HasMaxLength(1);
            entity.Property(e => e.SIVTYP_0).HasMaxLength(5);
            entity.Property(e => e.SPADERNUM_0).HasMaxLength(10);
            entity.Property(e => e.SSTENTCOD_0).HasMaxLength(20);
            entity.Property(e => e.STRDATSVC_0).HasColumnType("datetime");
            entity.Property(e => e.STRDUDDAT_0).HasColumnType("datetime");
            entity.Property(e => e.TAX_0).HasMaxLength(5);
            entity.Property(e => e.TAX_1).HasMaxLength(5);
            entity.Property(e => e.TAX_2).HasMaxLength(5);
            entity.Property(e => e.TAX_3).HasMaxLength(5);
            entity.Property(e => e.TAX_4).HasMaxLength(5);
            entity.Property(e => e.TAX_5).HasMaxLength(5);
            entity.Property(e => e.TAX_6).HasMaxLength(5);
            entity.Property(e => e.TAX_7).HasMaxLength(5);
            entity.Property(e => e.TAX_8).HasMaxLength(5);
            entity.Property(e => e.TAX_9).HasMaxLength(5);
            entity.Property(e => e.THEAMTTAX_0).HasColumnType("numeric(28, 8)");
            entity.Property(e => e.TRSFAM_0).HasMaxLength(20);
            entity.Property(e => e.UMRNUM_0).HasMaxLength(35);
            entity.Property(e => e.UPDDATTIM_0).HasColumnType("datetime");
            entity.Property(e => e.UPDDAT_0).HasColumnType("datetime");
            entity.Property(e => e.UPDUSR_0).HasMaxLength(5);
            entity.Property(e => e.VAC_0).HasMaxLength(5);
            entity.Property(e => e.VATDAT_0).HasColumnType("datetime");
            entity.Property(e => e.WRHE_0).HasMaxLength(5);
        });

        modelBuilder.Entity<SINVOICED>(entity =>
        {
            entity.HasKey(e => e.ROWID)
                .HasName("SINVOICED_ROWID")
                .IsClustered(false);

            entity.ToTable("SINVOICED", "UAS", tb => tb.HasTrigger("SINVOICED_UPDTICK"));

            entity.HasIndex(e => new { e.NUM_0, e.SIDLIN_0 }, "SINVOICED_SID0").IsUnique();

            entity.HasIndex(e => new { e.BPCINV_0, e.SALFCY_0, e.NUM_0, e.SIDLIN_0 }, "SINVOICED_SID1").IsUnique();

            entity.HasIndex(e => new { e.SOHNUM_0, e.CREDAT_0, e.NUM_0 }, "SINVOICED_SID2");

            entity.HasIndex(e => new { e.SDHNUM_0, e.SDDLIN_0 }, "SINVOICED_SID3");

            entity.HasIndex(e => e.CONNUM_0, "SINVOICED_SID4");

            entity.HasIndex(e => e.SRHNUM_0, "SINVOICED_SID5");

            entity.Property(e => e.ROWID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AMTATILIN_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTDEPLIN_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTLIN_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTNOTLIN_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAXLIN_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAXLIN_1).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AMTTAXLIN_2).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.AUUID_0)
                .HasMaxLength(16)
                .IsFixedLength();
            entity.Property(e => e.BASTAXLIN_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAXLIN_1).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAXLIN_2).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAXLIN_3).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAXLIN_4).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BASTAXLIN_5).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.BPCINV_0).HasMaxLength(15);
            entity.Property(e => e.CLCAMT1_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.CLCAMT2_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.CONNUM_0).HasMaxLength(20);
            entity.Property(e => e.CPRPRI_0).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.CPY_0).HasMaxLength(5);
            entity.Property(e => e.CREDATTIM_0).HasColumnType("datetime");
            entity.Property(e => e.CREDAT_0).HasColumnType("datetime");
            entity.Property(e => e.CREUSR_0).HasMaxLength(5);
            entity.Property(e => e.DDTADEP_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTADEP_1).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTADEP_2).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTADEP_3).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTADEP_4).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTADEP_5).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTADEP_6).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTADEP_7).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTADEP_8).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_1).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_2).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_3).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_4).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_5).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_6).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_7).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DDTANOT_8).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.DISCRGVAL1_0).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.DISCRGVAL2_0).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.DISCRGVAL3_0).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.DISCRGVAL4_0).HasColumnType("numeric(28, 8)");
            entity.Property(e => e.DISCRGVAL5_0).HasColumnType("numeric(28, 8)");
            entity.Property(e => e.DISCRGVAL6_0).HasColumnType("numeric(28, 8)");
            entity.Property(e => e.DISCRGVAL7_0).HasColumnType("numeric(28, 8)");
            entity.Property(e => e.DISCRGVAL8_0).HasColumnType("numeric(28, 8)");
            entity.Property(e => e.DISCRGVAL9_0).HasColumnType("numeric(28, 8)");
            entity.Property(e => e.DSPLINVOL_0).HasColumnType("numeric(28, 13)");
            entity.Property(e => e.DSPLINWEI_0).HasColumnType("numeric(28, 13)");
            entity.Property(e => e.DSPVOU_0).HasMaxLength(3);
            entity.Property(e => e.DSPWEU_0).HasMaxLength(3);
            entity.Property(e => e.ECCVALMAJ_0).HasMaxLength(10);
            entity.Property(e => e.ECCVALMIN_0).HasMaxLength(10);
            entity.Property(e => e.ENDDAT_0).HasColumnType("datetime");
            entity.Property(e => e.GEOCOD_0).HasMaxLength(10);
            entity.Property(e => e.GROPRI_0).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.INSCTYFLG_0).HasMaxLength(10);
            entity.Property(e => e.INVDAT_0).HasColumnType("datetime");
            entity.Property(e => e.INVPRC_0).HasColumnType("numeric(12, 5)");
            entity.Property(e => e.ITMDES1_0).HasMaxLength(70);
            entity.Property(e => e.ITMDES_0).HasMaxLength(70);
            entity.Property(e => e.ITMREF_0).HasMaxLength(20);
            entity.Property(e => e.LOC_0).HasMaxLength(10);
            entity.Property(e => e.LOT_0).HasMaxLength(15);
            entity.Property(e => e.NETPRIATI_0).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.NETPRINOT_0).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.NETPRI_0).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.NEXINVDAT_0).HasColumnType("datetime");
            entity.Property(e => e.NUM_0).HasMaxLength(20);
            entity.Property(e => e.PFM_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.PITFLG_0).HasColumnType("numeric(28, 13)");
            entity.Property(e => e.PJT_0).HasMaxLength(40);
            entity.Property(e => e.PRIORD_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.QTYSTU_0).HasColumnType("numeric(28, 13)");
            entity.Property(e => e.QTY_0).HasColumnType("numeric(28, 13)");
            entity.Property(e => e.RATTAXLIN_0).HasColumnType("numeric(8, 3)");
            entity.Property(e => e.REP1_0).HasMaxLength(15);
            entity.Property(e => e.REP2_0).HasMaxLength(15);
            entity.Property(e => e.REPAMT1_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.REPAMT2_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.REPBAS1_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.REPBAS2_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.REPCOE_0).HasColumnType("numeric(6, 3)");
            entity.Property(e => e.REPRAT1_0).HasColumnType("numeric(8, 3)");
            entity.Property(e => e.REPRAT2_0).HasColumnType("numeric(8, 3)");
            entity.Property(e => e.SALFCY_0).HasMaxLength(5);
            entity.Property(e => e.SAUSTUCOE_0).HasColumnType("numeric(18, 7)");
            entity.Property(e => e.SAU_0).HasMaxLength(3);
            entity.Property(e => e.SDHNUM_0).HasMaxLength(20);
            entity.Property(e => e.SGHNUM_0).HasMaxLength(20);
            entity.Property(e => e.SIDPSONUM_0).HasMaxLength(10);
            entity.Property(e => e.SIDTEX_0).HasMaxLength(17);
            entity.Property(e => e.SIHORINUM_0).HasMaxLength(20);
            entity.Property(e => e.SOHNUM_0).HasMaxLength(20);
            entity.Property(e => e.SRENUM_0).HasMaxLength(20);
            entity.Property(e => e.SRHNUM_0).HasMaxLength(20);
            entity.Property(e => e.SSTCOD_0).HasMaxLength(20);
            entity.Property(e => e.STA_0).HasMaxLength(12);
            entity.Property(e => e.STOFCY_0).HasMaxLength(5);
            entity.Property(e => e.STRDAT_0).HasColumnType("datetime");
            entity.Property(e => e.STU_0).HasMaxLength(3);
            entity.Property(e => e.SVICNUM_0).HasMaxLength(20);
            entity.Property(e => e.TAXGEOFLG_0).HasMaxLength(10);
            entity.Property(e => e.TSICOD_0).HasMaxLength(20);
            entity.Property(e => e.TSICOD_1).HasMaxLength(20);
            entity.Property(e => e.TSICOD_2).HasMaxLength(20);
            entity.Property(e => e.TSICOD_3).HasMaxLength(20);
            entity.Property(e => e.TSICOD_4).HasMaxLength(20);
            entity.Property(e => e.UPDDATTIM_0).HasColumnType("datetime");
            entity.Property(e => e.UPDDAT_0).HasColumnType("datetime");
            entity.Property(e => e.UPDUSR_0).HasMaxLength(5);
            entity.Property(e => e.VACITM_0).HasMaxLength(5);
            entity.Property(e => e.VACITM_1).HasMaxLength(5);
            entity.Property(e => e.VACITM_2).HasMaxLength(5);
            entity.Property(e => e.VAT_0).HasMaxLength(5);
            entity.Property(e => e.VAT_1).HasMaxLength(5);
            entity.Property(e => e.VAT_2).HasMaxLength(5);
            entity.Property(e => e.VTC_0).HasMaxLength(1);
            entity.Property(e => e.VTS_0).HasMaxLength(1);
            entity.Property(e => e.WRH_0).HasMaxLength(5);
        });

        modelBuilder.Entity<SINVOICEV>(entity =>
        {
            entity.HasKey(e => e.ROWID)
                .HasName("SINVOICEV_ROWID")
                .IsClustered(false);

            entity.ToTable("SINVOICEV", "UAS", tb => tb.HasTrigger("SINVOICEV_UPDTICK"));

            entity.HasIndex(e => e.NUM_0, "SINVOICEV_SIV0").IsUnique();

            entity.HasIndex(e => new { e.SIHORI_0, e.SIHORINUM_0 }, "SINVOICEV_SIV1");

            entity.HasIndex(e => new { e.INVTYP_0, e.NUM_0 }, "SINVOICEV_SIV2").IsUnique();

            entity.HasIndex(e => new { e.INVDAT_0, e.NUM_0 }, "SINVOICEV_XSIV0");

            entity.Property(e => e.ROWID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)");
            entity.Property(e => e.ARVDAT_0).HasColumnType("datetime");
            entity.Property(e => e.AUUID_0)
                .HasMaxLength(16)
                .IsFixedLength();
            entity.Property(e => e.BPAADD_0).HasMaxLength(5);
            entity.Property(e => e.BPCGRU_0).HasMaxLength(15);
            entity.Property(e => e.BPCINV_0).HasMaxLength(15);
            entity.Property(e => e.BPCORD_0).HasMaxLength(15);
            entity.Property(e => e.BPDADDLIG_0).HasMaxLength(50);
            entity.Property(e => e.BPDADDLIG_1).HasMaxLength(50);
            entity.Property(e => e.BPDADDLIG_2).HasMaxLength(50);
            entity.Property(e => e.BPDCRYNAM_0).HasMaxLength(40);
            entity.Property(e => e.BPDCRY_0).HasMaxLength(3);
            entity.Property(e => e.BPDCTY_0).HasMaxLength(40);
            entity.Property(e => e.BPDNAM_0).HasMaxLength(35);
            entity.Property(e => e.BPDNAM_1).HasMaxLength(35);
            entity.Property(e => e.BPDPOSCOD_0).HasMaxLength(10);
            entity.Property(e => e.BPDSAT_0).HasMaxLength(35);
            entity.Property(e => e.BPIEECNUM_0).HasMaxLength(20);
            entity.Property(e => e.BPINAM_0).HasMaxLength(35);
            entity.Property(e => e.BPINAM_1).HasMaxLength(35);
            entity.Property(e => e.BPRFCT_0).HasMaxLength(15);
            entity.Property(e => e.BPRPAY_0).HasMaxLength(15);
            entity.Property(e => e.CMGNUM_0).HasMaxLength(20);
            entity.Property(e => e.CNDNAM_0).HasMaxLength(15);
            entity.Property(e => e.CNINAM_0).HasMaxLength(15);
            entity.Property(e => e.CNOREN_0).HasMaxLength(20);
            entity.Property(e => e.CPY_0).HasMaxLength(5);
            entity.Property(e => e.CREDATTIM_0).HasColumnType("datetime");
            entity.Property(e => e.CREDAT_0).HasColumnType("datetime");
            entity.Property(e => e.CREUSR_0).HasMaxLength(5);
            entity.Property(e => e.CUR_0).HasMaxLength(3);
            entity.Property(e => e.DEP_0).HasMaxLength(5);
            entity.Property(e => e.DPEDAT_0).HasColumnType("datetime");
            entity.Property(e => e.DSPTOTQTY_0).HasColumnType("numeric(22, 7)");
            entity.Property(e => e.DSPTOTVOL_0).HasColumnType("numeric(28, 13)");
            entity.Property(e => e.DSPTOTWEI_0).HasColumnType("numeric(28, 13)");
            entity.Property(e => e.DSPVOU_0).HasMaxLength(3);
            entity.Property(e => e.DSPWEU_0).HasMaxLength(3);
            entity.Property(e => e.EECICT_0).HasMaxLength(5);
            entity.Property(e => e.EECNATR_0).HasMaxLength(5);
            entity.Property(e => e.EECNAT_0).HasMaxLength(5);
            entity.Property(e => e.EECSCHR_0).HasMaxLength(5);
            entity.Property(e => e.EECSCH_0).HasMaxLength(5);
            entity.Property(e => e.ENTCOD_0).HasMaxLength(5);
            entity.Property(e => e.ETA_0).HasMaxLength(6);
            entity.Property(e => e.ETD_0).HasMaxLength(6);
            entity.Property(e => e.FFWADD_0).HasMaxLength(5);
            entity.Property(e => e.FFWNUM_0).HasMaxLength(15);
            entity.Property(e => e.GEOCOD_0).HasMaxLength(10);
            entity.Property(e => e.ICTCTY_0).HasMaxLength(40);
            entity.Property(e => e.INSATI_0).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.INSATI_1).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.INSATI_2).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.INSATI_3).HasColumnType("numeric(27, 13)");
            entity.Property(e => e.INSCTYFLG_0).HasMaxLength(10);
            entity.Property(e => e.INSORDNUM_0).HasMaxLength(20);
            entity.Property(e => e.INSORDNUM_1).HasMaxLength(20);
            entity.Property(e => e.INSORDNUM_2).HasMaxLength(20);
            entity.Property(e => e.INSORDNUM_3).HasMaxLength(20);
            entity.Property(e => e.INVDAT_0).HasColumnType("datetime");
            entity.Property(e => e.INVDTAAMT_0).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_1).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_10).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_11).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_12).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_13).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_14).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_15).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_16).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_17).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_18).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_19).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_2).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_20).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_21).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_22).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_23).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_24).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_25).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_26).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_27).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_28).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_29).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_3).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_4).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_5).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_6).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_7).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_8).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTAAMT_9).HasColumnType("numeric(20, 5)");
            entity.Property(e => e.INVDTADSP_0).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_1).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_10).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_11).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_12).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_13).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_14).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_15).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_16).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_17).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_18).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_19).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_2).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_20).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_21).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_22).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_23).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_24).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_25).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_26).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_27).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_28).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_29).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_3).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_4).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_5).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_6).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_7).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_8).HasMaxLength(10);
            entity.Property(e => e.INVDTADSP_9).HasMaxLength(10);
            entity.Property(e => e.INVREF_0).HasMaxLength(30);
            entity.Property(e => e.LAN_0).HasMaxLength(3);
            entity.Property(e => e.LICPLATE_0).HasMaxLength(10);
            entity.Property(e => e.NUM_0).HasMaxLength(20);
            entity.Property(e => e.OPGNUM_0).HasMaxLength(20);
            entity.Property(e => e.OPGTYP_0).HasMaxLength(3);
            entity.Property(e => e.ORIFCY_0).HasMaxLength(5);
            entity.Property(e => e.PAM_0).HasMaxLength(5);
            entity.Property(e => e.PAM_1).HasMaxLength(5);
            entity.Property(e => e.PAM_2).HasMaxLength(5);
            entity.Property(e => e.PAM_3).HasMaxLength(5);
            entity.Property(e => e.PIHNUM_0).HasMaxLength(20);
            entity.Property(e => e.PJT_0).HasMaxLength(40);
            entity.Property(e => e.PLISTC_0).HasMaxLength(10);
            entity.Property(e => e.REP_0).HasMaxLength(15);
            entity.Property(e => e.REP_1).HasMaxLength(15);
            entity.Property(e => e.SALFCY_0).HasMaxLength(5);
            entity.Property(e => e.SFISSTCOD_0).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_1).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_10).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_11).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_12).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_13).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_14).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_15).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_16).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_17).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_18).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_19).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_2).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_20).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_21).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_22).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_23).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_24).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_25).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_26).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_27).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_28).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_29).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_3).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_4).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_5).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_6).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_7).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_8).HasMaxLength(20);
            entity.Property(e => e.SFISSTCOD_9).HasMaxLength(20);
            entity.Property(e => e.SIHNUMEND_0).HasMaxLength(10);
            entity.Property(e => e.SIHORIDAT_0).HasColumnType("datetime");
            entity.Property(e => e.SIHORINUM_0).HasMaxLength(20);
            entity.Property(e => e.SIHTEX1_0).HasMaxLength(17);
            entity.Property(e => e.SIHTEX2_0).HasMaxLength(17);
            entity.Property(e => e.SIVTYP_0).HasMaxLength(5);
            entity.Property(e => e.SRGLOCDEF_0).HasMaxLength(10);
            entity.Property(e => e.STOFCY_0).HasMaxLength(5);
            entity.Property(e => e.TRLLICPLATE_0).HasMaxLength(10);
            entity.Property(e => e.TRSCOD_0).HasMaxLength(20);
            entity.Property(e => e.TSCCOD_0).HasMaxLength(20);
            entity.Property(e => e.TSCCOD_1).HasMaxLength(20);
            entity.Property(e => e.TSCCOD_2).HasMaxLength(20);
            entity.Property(e => e.TSCCOD_3).HasMaxLength(20);
            entity.Property(e => e.TSCCOD_4).HasMaxLength(20);
            entity.Property(e => e.UPDDATTIM_0).HasColumnType("datetime");
            entity.Property(e => e.UPDDAT_0).HasColumnType("datetime");
            entity.Property(e => e.UPDUSR_0).HasMaxLength(5);
            entity.Property(e => e.VTT_0).HasMaxLength(1);
            entity.Property(e => e.YDATDEP_0).HasColumnType("datetime");
            entity.Property(e => e.YDEPPAR_0).HasMaxLength(20);
            entity.Property(e => e.YLIBELLE_0).HasMaxLength(70);
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}