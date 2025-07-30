using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceAPI.models;

public partial class SINVOICED
{
    public int UPDTICK_0 { get; set; }
    [Key]
    [Column("ROWID")]
    public int ROWID { get; set; }
    [Column("NUM_0")]
    public string NUM_0 { get; set; } = null!;

    public int SIDLIN_0 { get; set; }

    public string CPY_0 { get; set; } = null!;

    public string SOHNUM_0 { get; set; } = null!;

    public int SOPLIN_0 { get; set; }

    public int SOQSEQ_0 { get; set; }

    public string SDHNUM_0 { get; set; } = null!;

    public int SDDLIN_0 { get; set; }

    public string CONNUM_0 { get; set; } = null!;

    public string SRENUM_0 { get; set; } = null!;

    public string SGHNUM_0 { get; set; } = null!;

    public string SIHORINUM_0 { get; set; } = null!;

    public int SIDORILIN_0 { get; set; }

    public string SRHNUM_0 { get; set; } = null!;

    public int SRDLIN_0 { get; set; }

    public int PIDLIN_0 { get; set; }

    public string BPCINV_0 { get; set; } = null!;

    public string ITMREF_0 { get; set; } = null!;

    public string ECCVALMAJ_0 { get; set; } = null!;

    public string ECCVALMIN_0 { get; set; } = null!;

    public string ITMDES1_0 { get; set; } = null!;

    public string ITMDES_0 { get; set; } = null!;

    public string VACITM_0 { get; set; } = null!;

    public string VACITM_1 { get; set; } = null!;

    public string VACITM_2 { get; set; } = null!;

    public string SSTCOD_0 { get; set; } = null!;

    public string REP1_0 { get; set; } = null!;

    public string REP2_0 { get; set; } = null!;

    public decimal REPRAT1_0 { get; set; }

    public decimal REPRAT2_0 { get; set; }

    public decimal REPBAS1_0 { get; set; }

    public decimal REPBAS2_0 { get; set; }

    public decimal REPAMT1_0 { get; set; }

    public decimal REPAMT2_0 { get; set; }

    public decimal REPCOE_0 { get; set; }

    public decimal GROPRI_0 { get; set; }

    public short PRIREN_0 { get; set; }

    public decimal NETPRI_0 { get; set; }

    public decimal NETPRINOT_0 { get; set; }

    public decimal NETPRIATI_0 { get; set; }

    public decimal PFM_0 { get; set; }

    public decimal CPRPRI_0 { get; set; }

    public decimal DISCRGVAL1_0 { get; set; }

    public decimal DISCRGVAL2_0 { get; set; }

    public decimal DISCRGVAL3_0 { get; set; }

    public decimal DISCRGVAL4_0 { get; set; }

    public decimal DISCRGVAL5_0 { get; set; }

    public decimal DISCRGVAL6_0 { get; set; }

    public decimal DISCRGVAL7_0 { get; set; }

    public decimal DISCRGVAL8_0 { get; set; }

    public decimal DISCRGVAL9_0 { get; set; }

    public short DISCRGREN1_0 { get; set; }

    public short DISCRGREN2_0 { get; set; }

    public short DISCRGREN3_0 { get; set; }

    public short DISCRGREN4_0 { get; set; }

    public short DISCRGREN5_0 { get; set; }

    public short DISCRGREN6_0 { get; set; }

    public short DISCRGREN7_0 { get; set; }

    public short DISCRGREN8_0 { get; set; }

    public short DISCRGREN9_0 { get; set; }

    public string VAT_0 { get; set; } = null!;

    public string VAT_1 { get; set; } = null!;

    public string VAT_2 { get; set; } = null!;

    public decimal AMTLIN_0 { get; set; }

    public decimal AMTNOTLIN_0 { get; set; }

    public decimal AMTDEPLIN_0 { get; set; }

    public decimal CLCAMT1_0 { get; set; }

    public decimal CLCAMT2_0 { get; set; }

    public decimal BASTAXLIN_0 { get; set; }

    public decimal BASTAXLIN_1 { get; set; }

    public decimal BASTAXLIN_2 { get; set; }

    public decimal BASTAXLIN_3 { get; set; }

    public decimal BASTAXLIN_4 { get; set; }

    public decimal BASTAXLIN_5 { get; set; }

    public decimal RATTAXLIN_0 { get; set; }

    public decimal AMTTAXLIN_0 { get; set; }

    public decimal AMTTAXLIN_1 { get; set; }

    public decimal AMTTAXLIN_2 { get; set; }

    public decimal AMTATILIN_0 { get; set; }

    public byte DSPLINFLG_0 { get; set; }

    public short DDTANUM_0 { get; set; }

    public short DDTANUM_1 { get; set; }

    public short DDTANUM_2 { get; set; }

    public short DDTANUM_3 { get; set; }

    public short DDTANUM_4 { get; set; }

    public short DDTANUM_5 { get; set; }

    public short DDTANUM_6 { get; set; }

    public short DDTANUM_7 { get; set; }

    public short DDTANUM_8 { get; set; }

    public decimal DDTANOT_0 { get; set; }

    public decimal DDTANOT_1 { get; set; }

    public decimal DDTANOT_2 { get; set; }

    public decimal DDTANOT_3 { get; set; }

    public decimal DDTANOT_4 { get; set; }

    public decimal DDTANOT_5 { get; set; }

    public decimal DDTANOT_6 { get; set; }

    public decimal DDTANOT_7 { get; set; }

    public decimal DDTANOT_8 { get; set; }

    public decimal DDTADEP_0 { get; set; }

    public decimal DDTADEP_1 { get; set; }

    public decimal DDTADEP_2 { get; set; }

    public decimal DDTADEP_3 { get; set; }

    public decimal DDTADEP_4 { get; set; }

    public decimal DDTADEP_5 { get; set; }

    public decimal DDTADEP_6 { get; set; }

    public decimal DDTADEP_7 { get; set; }

    public decimal DDTADEP_8 { get; set; }

    public decimal QTY_0 { get; set; }

    public decimal QTYSTU_0 { get; set; }

    public string SAU_0 { get; set; } = null!;

    public string STU_0 { get; set; } = null!;

    public decimal SAUSTUCOE_0 { get; set; }

    public string STOFCY_0 { get; set; } = null!;

    public byte STOMGTCOD_0 { get; set; }

    public string LOT_0 { get; set; } = null!;

    public string STA_0 { get; set; } = null!;

    public string LOC_0 { get; set; } = null!;

    public decimal PRIORD_0 { get; set; }

    public byte ALLTYP_0 { get; set; }

    public string SALFCY_0 { get; set; } = null!;

    public DateTime INVDAT_0 { get; set; }

    public string TSICOD_0 { get; set; } = null!;

    public string TSICOD_1 { get; set; } = null!;

    public string TSICOD_2 { get; set; } = null!;

    public string TSICOD_3 { get; set; } = null!;

    public string TSICOD_4 { get; set; } = null!;

    public byte LINTYP_0 { get; set; }

    public byte FOCFLG_0 { get; set; }

    public int ORILIN_0 { get; set; }

    public string SIDTEX_0 { get; set; } = null!;

    public byte LINEECFLG_0 { get; set; }

    public byte EECFLOPHY_0 { get; set; }

    public string GEOCOD_0 { get; set; } = null!;

    public string INSCTYFLG_0 { get; set; } = null!;

    public string VTS_0 { get; set; } = null!;

    public string VTC_0 { get; set; } = null!;

    public string TAXGEOFLG_0 { get; set; } = null!;

    public short TAXFLG_0 { get; set; }

    public short TAXREGFLG_0 { get; set; }

    public byte INVPRNBOM_0 { get; set; }

    public DateTime STRDAT_0 { get; set; }

    public DateTime ENDDAT_0 { get; set; }

    public short PERNBR_0 { get; set; }

    public byte PERTYP_0 { get; set; }

    public decimal PITFLG_0 { get; set; }

    public decimal DSPLINWEI_0 { get; set; }

    public decimal DSPLINVOL_0 { get; set; }

    public string DSPWEU_0 { get; set; } = null!;

    public string DSPVOU_0 { get; set; } = null!;

    public string WRH_0 { get; set; } = null!;

    public string PJT_0 { get; set; } = null!;

    public int EXPNUM_0 { get; set; }

    public int IMPNUMLIG_0 { get; set; }

    public string CREUSR_0 { get; set; } = null!;

    public DateTime CREDAT_0 { get; set; }

    public string UPDUSR_0 { get; set; } = null!;

    public DateTime UPDDAT_0 { get; set; }

    public DateTime CREDATTIM_0 { get; set; }

    public DateTime UPDDATTIM_0 { get; set; }

    public byte[] AUUID_0 { get; set; } = null!;

    public byte SIDORI_0 { get; set; }

    public decimal INVPRC_0 { get; set; }

    public int VCRINVCNDLIN_0 { get; set; }

    public byte VCRINVCNDTYP_0 { get; set; }

    public string SIDPSONUM_0 { get; set; } = null!;

    public short SIDSEQNUM_0 { get; set; }

    public byte INVCNDUPD_0 { get; set; }

    public DateTime NEXINVDAT_0 { get; set; }

    public string SVICNUM_0 { get; set; } = null!;
    [ForeignKey("NUM_0")]
    public SINVOICE Invoice { get; set; }
}
