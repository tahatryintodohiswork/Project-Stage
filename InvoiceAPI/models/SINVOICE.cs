using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceAPI.models;

public partial class SINVOICE
{
    public int UPDTICK_0 { get; set; }

    public string SIVTYP_0 { get; set; } = null!;

    public byte INVTYP_0 { get; set; }
    [Key]
    [Column("NUM_0")]
    public string NUM_0 { get; set; } = null!;

    public byte ORIMOD_0 { get; set; }

    public string BPR_0 { get; set; } = null!;

    public string BPRSAC_0 { get; set; } = null!;

    public string CPY_0 { get; set; } = null!;

    public string FCY_0 { get; set; } = null!;

    public string GTE_0 { get; set; } = null!;

    public string JOU_0 { get; set; } = null!;

    public DateTime ACCDAT_0 { get; set; }

    public int ACCNUM_0 { get; set; }

    public DateTime BPRDAT_0 { get; set; }

    public string BPRVCR_0 { get; set; } = null!;

    public string CUR_0 { get; set; } = null!;

    public byte CURTYP_0 { get; set; }

    public string LED_0 { get; set; } = null!;

    public string LED_1 { get; set; } = null!;

    public string LED_2 { get; set; } = null!;

    public string LED_3 { get; set; } = null!;

    public string LED_4 { get; set; } = null!;

    public string LED_5 { get; set; } = null!;

    public string LED_6 { get; set; } = null!;

    public string LED_7 { get; set; } = null!;

    public string LED_8 { get; set; } = null!;

    public string LED_9 { get; set; } = null!;

    public string CURLED_0 { get; set; } = null!;

    public string CURLED_1 { get; set; } = null!;

    public string CURLED_2 { get; set; } = null!;

    public string CURLED_3 { get; set; } = null!;

    public string CURLED_4 { get; set; } = null!;

    public string CURLED_5 { get; set; } = null!;

    public string CURLED_6 { get; set; } = null!;

    public string CURLED_7 { get; set; } = null!;

    public string CURLED_8 { get; set; } = null!;

    public string CURLED_9 { get; set; } = null!;

    public decimal RATMLT_0 { get; set; }

    public decimal RATMLT_1 { get; set; }

    public decimal RATMLT_2 { get; set; }

    public decimal RATMLT_3 { get; set; }

    public decimal RATMLT_4 { get; set; }

    public decimal RATMLT_5 { get; set; }

    public decimal RATMLT_6 { get; set; }

    public decimal RATMLT_7 { get; set; }

    public decimal RATMLT_8 { get; set; }

    public decimal RATMLT_9 { get; set; }

    public decimal RATDIV_0 { get; set; }

    public decimal RATDIV_1 { get; set; }

    public decimal RATDIV_2 { get; set; }

    public decimal RATDIV_3 { get; set; }

    public decimal RATDIV_4 { get; set; }

    public decimal RATDIV_5 { get; set; }

    public decimal RATDIV_6 { get; set; }

    public decimal RATDIV_7 { get; set; }

    public decimal RATDIV_8 { get; set; }

    public decimal RATDIV_9 { get; set; }

    public DateTime RATDAT_0 { get; set; }

    public string BPRPAY_0 { get; set; } = null!;

    public string BPAPAY_0 { get; set; } = null!;

    public string BPYNAM_0 { get; set; } = null!;

    public string BPYNAM_1 { get; set; } = null!;

    public string BPYADDLIG_0 { get; set; } = null!;

    public string BPYADDLIG_1 { get; set; } = null!;

    public string BPYADDLIG_2 { get; set; } = null!;

    public string BPYPOSCOD_0 { get; set; } = null!;

    public string BPYCTY_0 { get; set; } = null!;

    public string BPYSAT_0 { get; set; } = null!;

    public string BPYCRY_0 { get; set; } = null!;

    public string BPYCRYNAM_0 { get; set; } = null!;

    public string BPRFCT_0 { get; set; } = null!;

    public string FCTVCR_0 { get; set; } = null!;

    public short FCTVCRFLG_0 { get; set; }

    public int QTCACCNUM_0 { get; set; }

    public DateTime STRDUDDAT_0 { get; set; }

    public string PTE_0 { get; set; } = null!;

    public string DEP_0 { get; set; } = null!;

    public decimal DEPRAT_0 { get; set; }

    public string VAC_0 { get; set; } = null!;

    public string SSTENTCOD_0 { get; set; } = null!;

    public byte DIRINVFLG_0 { get; set; }

    public short EECNUMDEB_0 { get; set; }

    public byte STA_0 { get; set; }

    public string DES_0 { get; set; } = null!;

    public string DES_1 { get; set; } = null!;

    public string DES_2 { get; set; } = null!;

    public string DES_3 { get; set; } = null!;

    public string DES_4 { get; set; } = null!;

    public string INVNUM_0 { get; set; } = null!;

    public short SNS_0 { get; set; }

    public decimal AMTATI_0 { get; set; }

    public decimal AMTNOT_0 { get; set; }

    public decimal AMTNOTL_0 { get; set; }

    public decimal AMTATIL_0 { get; set; }

    public DateTime VATDAT_0 { get; set; }

    public short NBRTAX_0 { get; set; }

    public string TAX_0 { get; set; } = null!;

    public string TAX_1 { get; set; } = null!;

    public string TAX_2 { get; set; } = null!;

    public string TAX_3 { get; set; } = null!;

    public string TAX_4 { get; set; } = null!;

    public string TAX_5 { get; set; } = null!;

    public string TAX_6 { get; set; } = null!;

    public string TAX_7 { get; set; } = null!;

    public string TAX_8 { get; set; } = null!;

    public string TAX_9 { get; set; } = null!;

    public decimal BASTAX_0 { get; set; }

    public decimal BASTAX_1 { get; set; }

    public decimal BASTAX_2 { get; set; }

    public decimal BASTAX_3 { get; set; }

    public decimal BASTAX_4 { get; set; }

    public decimal BASTAX_5 { get; set; }

    public decimal BASTAX_6 { get; set; }

    public decimal BASTAX_7 { get; set; }

    public decimal BASTAX_8 { get; set; }

    public decimal BASTAX_9 { get; set; }

    public decimal AMTTAX_0 { get; set; }

    public decimal AMTTAX_1 { get; set; }

    public decimal AMTTAX_2 { get; set; }

    public decimal AMTTAX_3 { get; set; }

    public decimal AMTTAX_4 { get; set; }

    public decimal AMTTAX_5 { get; set; }

    public decimal AMTTAX_6 { get; set; }

    public decimal AMTTAX_7 { get; set; }

    public decimal AMTTAX_8 { get; set; }

    public decimal AMTTAX_9 { get; set; }

    public decimal THEAMTTAX_0 { get; set; }

    public decimal EXEAMTTAX_0 { get; set; }

    public decimal EXEAMTTAX_1 { get; set; }

    public decimal EXEAMTTAX_2 { get; set; }

    public decimal EXEAMTTAX_3 { get; set; }

    public decimal EXEAMTTAX_4 { get; set; }

    public decimal EXEAMTTAX_5 { get; set; }

    public decimal EXEAMTTAX_6 { get; set; }

    public decimal EXEAMTTAX_7 { get; set; }

    public decimal EXEAMTTAX_8 { get; set; }

    public decimal EXEAMTTAX_9 { get; set; }

    public string DIE_0 { get; set; } = null!;

    public string DIE_1 { get; set; } = null!;

    public string DIE_2 { get; set; } = null!;

    public string DIE_3 { get; set; } = null!;

    public string DIE_4 { get; set; } = null!;

    public string DIE_5 { get; set; } = null!;

    public string DIE_6 { get; set; } = null!;

    public string DIE_7 { get; set; } = null!;

    public string DIE_8 { get; set; } = null!;

    public string DIE_9 { get; set; } = null!;

    public string DIE_10 { get; set; } = null!;

    public string DIE_11 { get; set; } = null!;

    public string DIE_12 { get; set; } = null!;

    public string DIE_13 { get; set; } = null!;

    public string DIE_14 { get; set; } = null!;

    public string DIE_15 { get; set; } = null!;

    public string DIE_16 { get; set; } = null!;

    public string DIE_17 { get; set; } = null!;

    public string DIE_18 { get; set; } = null!;

    public string DIE_19 { get; set; } = null!;

    public string CCE_0 { get; set; } = null!;

    public string CCE_1 { get; set; } = null!;

    public string CCE_2 { get; set; } = null!;

    public string CCE_3 { get; set; } = null!;

    public string CCE_4 { get; set; } = null!;

    public string CCE_5 { get; set; } = null!;

    public string CCE_6 { get; set; } = null!;

    public string CCE_7 { get; set; } = null!;

    public string CCE_8 { get; set; } = null!;

    public string CCE_9 { get; set; } = null!;

    public string CCE_10 { get; set; } = null!;

    public string CCE_11 { get; set; } = null!;

    public string CCE_12 { get; set; } = null!;

    public string CCE_13 { get; set; } = null!;

    public string CCE_14 { get; set; } = null!;

    public string CCE_15 { get; set; } = null!;

    public string CCE_16 { get; set; } = null!;

    public string CCE_17 { get; set; } = null!;

    public string CCE_18 { get; set; } = null!;

    public string CCE_19 { get; set; } = null!;

    public string BPAINV_0 { get; set; } = null!;

    public string BPRNAM_0 { get; set; } = null!;

    public string BPRNAM_1 { get; set; } = null!;

    public string BPAADDLIG_0 { get; set; } = null!;

    public string BPAADDLIG_1 { get; set; } = null!;

    public string BPAADDLIG_2 { get; set; } = null!;

    public string POSCOD_0 { get; set; } = null!;

    public string CTY_0 { get; set; } = null!;

    public string SAT_0 { get; set; } = null!;

    public string CRY_0 { get; set; } = null!;

    public string CRYNAM_0 { get; set; } = null!;

    public string BILVCR_0 { get; set; } = null!;

    public string TRSFAM_0 { get; set; } = null!;

    public short FIY_0 { get; set; }

    public short PER_0 { get; set; }

    public DateTime STRDATSVC_0 { get; set; }

    public DateTime ENDDATSVC_0 { get; set; }

    public DateTime LASDATSVC_0 { get; set; }

    public decimal AMTTAXUSA_0 { get; set; }

    public string CAI_0 { get; set; } = null!;

    public DateTime DATVLYCAI_0 { get; set; }

    public string WRHE_0 { get; set; } = null!;

    public int EXPNUM_0 { get; set; }

    public string SINUM_0 { get; set; } = null!;

    public byte STARPT_0 { get; set; }

    public short ISEXTDOC_0 { get; set; }

    public DateTime CREDAT_0 { get; set; }

    public string CREUSR_0 { get; set; } = null!;

    public DateTime UPDDAT_0 { get; set; }

    public string UPDUSR_0 { get; set; } = null!;

    public decimal BASDEP_0 { get; set; }

    public DateTime CREDATTIM_0 { get; set; }

    public DateTime UPDDATTIM_0 { get; set; }

    public byte[] AUUID_0 { get; set; } = null!;

    public string BELVCS_0 { get; set; } = null!;

    public byte ADRVAL_0 { get; set; }

    public byte SALPRITYP_0 { get; set; }

    public string DCLEECNUM_0 { get; set; } = null!;

    public string POREXPDCL_0 { get; set; } = null!;

    public string UMRNUM_0 { get; set; } = null!;

    public string RCRNUM_0 { get; set; } = null!;

    public DateTime RCRDAT_0 { get; set; }

    public short NBRCPY_0 { get; set; }

    public short CSHVAT_0 { get; set; }

    public string SPADERNUM_0 { get; set; } = null!;

    public string FLD40REN_0 { get; set; } = null!;

    public string FLD41REN_0 { get; set; } = null!;

    public string ORIDOCNUM_0 { get; set; } = null!;

    public DateTime PERDEB_0 { get; set; }

    public DateTime PERFIN_0 { get; set; }

    public string BVRREFNUM_0 { get; set; } = null!;

    public string PAYBAN_0 { get; set; } = null!;

    public short REVCANSTA_0 { get; set; }

    public string PJTH_0 { get; set; } = null!;

    public short METCOR_0 { get; set; }

    public string CRN_0 { get; set; } = null!;

    public short INVTYPSPA_0 { get; set; }

    public string BUSPROTYP_0 { get; set; } = null!;

    public short ISSBYREC_0 { get; set; }

    public short ISSBYRECG_0 { get; set; }

    public short ISSAUTGEN_0 { get; set; }

    public int ROWID { get; set; }
    public ICollection<SINVOICED> Details { get; set; } = new List<SINVOICED>();
}
