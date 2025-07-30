using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InvoiceAPI.models;

public partial class SINVOICEV
{
    public int UPDTICK_0 { get; set; }
    [Key]
    public string NUM_0 { get; set; } = null!;

    public string CPY_0 { get; set; } = null!;

    public string SALFCY_0 { get; set; } = null!;

    public string STOFCY_0 { get; set; } = null!;

    public string BPCINV_0 { get; set; } = null!;

    public string BPCORD_0 { get; set; } = null!;

    public string BPCGRU_0 { get; set; } = null!;

    public string BPAADD_0 { get; set; } = null!;

    public string BPINAM_0 { get; set; } = null!;

    public string BPINAM_1 { get; set; } = null!;

    public string BPIEECNUM_0 { get; set; } = null!;

    public string CNINAM_0 { get; set; } = null!;

    public string BPDNAM_0 { get; set; } = null!;

    public string BPDNAM_1 { get; set; } = null!;

    public string BPDADDLIG_0 { get; set; } = null!;

    public string BPDADDLIG_1 { get; set; } = null!;

    public string BPDADDLIG_2 { get; set; } = null!;

    public string BPDPOSCOD_0 { get; set; } = null!;

    public string BPDCTY_0 { get; set; } = null!;

    public string BPDSAT_0 { get; set; } = null!;

    public string BPDCRY_0 { get; set; } = null!;

    public string BPDCRYNAM_0 { get; set; } = null!;

    public string CNDNAM_0 { get; set; } = null!;

    public string BPRPAY_0 { get; set; } = null!;

    public string BPRFCT_0 { get; set; } = null!;

    public string SIVTYP_0 { get; set; } = null!;

    public byte INVTYP_0 { get; set; }

    public byte SIHORI_0 { get; set; }

    public string SIHORINUM_0 { get; set; } = null!;

    public DateTime SIHORIDAT_0 { get; set; }

    public DateTime INVDAT_0 { get; set; }

    public string CUR_0 { get; set; } = null!;

    public byte INVSTA_0 { get; set; }

    public byte INVCNOSTA_0 { get; set; }

    public byte STOMVTFLG_0 { get; set; }

    public string INVREF_0 { get; set; } = null!;

    public string PJT_0 { get; set; } = null!;

    public byte PRITYP_0 { get; set; }

    public string REP_0 { get; set; } = null!;

    public string REP_1 { get; set; } = null!;

    public string CNOREN_0 { get; set; } = null!;

    public string DEP_0 { get; set; } = null!;

    public string LAN_0 { get; set; } = null!;

    public string TSCCOD_0 { get; set; } = null!;

    public string TSCCOD_1 { get; set; } = null!;

    public string TSCCOD_2 { get; set; } = null!;

    public string TSCCOD_3 { get; set; } = null!;

    public string TSCCOD_4 { get; set; } = null!;

    public string SIHTEX1_0 { get; set; } = null!;

    public string SIHTEX2_0 { get; set; } = null!;

    public byte BETFCY_0 { get; set; }

    public byte BETCPY_0 { get; set; }

    public string ORIFCY_0 { get; set; } = null!;

    public string PIHNUM_0 { get; set; } = null!;

    public byte DISCRGTYP_0 { get; set; }

    public byte DISCRGTYP_1 { get; set; }

    public byte DISCRGTYP_2 { get; set; }

    public byte DISCRGTYP_3 { get; set; }

    public byte DISCRGTYP_4 { get; set; }

    public byte DISCRGTYP_5 { get; set; }

    public byte DISCRGTYP_6 { get; set; }

    public byte DISCRGTYP_7 { get; set; }

    public byte DISCRGTYP_8 { get; set; }

    public short INVDTALIN_0 { get; set; }

    public short INVDTALIN_1 { get; set; }

    public short INVDTALIN_2 { get; set; }

    public short INVDTALIN_3 { get; set; }

    public short INVDTALIN_4 { get; set; }

    public short INVDTALIN_5 { get; set; }

    public short INVDTALIN_6 { get; set; }

    public short INVDTALIN_7 { get; set; }

    public short INVDTALIN_8 { get; set; }

    public short LINNBR_0 { get; set; }

    public short INVDTA_0 { get; set; }

    public short INVDTA_1 { get; set; }

    public short INVDTA_2 { get; set; }

    public short INVDTA_3 { get; set; }

    public short INVDTA_4 { get; set; }

    public short INVDTA_5 { get; set; }

    public short INVDTA_6 { get; set; }

    public short INVDTA_7 { get; set; }

    public short INVDTA_8 { get; set; }

    public short INVDTA_9 { get; set; }

    public short INVDTA_10 { get; set; }

    public short INVDTA_11 { get; set; }

    public short INVDTA_12 { get; set; }

    public short INVDTA_13 { get; set; }

    public short INVDTA_14 { get; set; }

    public short INVDTA_15 { get; set; }

    public short INVDTA_16 { get; set; }

    public short INVDTA_17 { get; set; }

    public short INVDTA_18 { get; set; }

    public short INVDTA_19 { get; set; }

    public short INVDTA_20 { get; set; }

    public short INVDTA_21 { get; set; }

    public short INVDTA_22 { get; set; }

    public short INVDTA_23 { get; set; }

    public short INVDTA_24 { get; set; }

    public short INVDTA_25 { get; set; }

    public short INVDTA_26 { get; set; }

    public short INVDTA_27 { get; set; }

    public short INVDTA_28 { get; set; }

    public short INVDTA_29 { get; set; }

    public decimal INVDTAAMT_0 { get; set; }

    public decimal INVDTAAMT_1 { get; set; }

    public decimal INVDTAAMT_2 { get; set; }

    public decimal INVDTAAMT_3 { get; set; }

    public decimal INVDTAAMT_4 { get; set; }

    public decimal INVDTAAMT_5 { get; set; }

    public decimal INVDTAAMT_6 { get; set; }

    public decimal INVDTAAMT_7 { get; set; }

    public decimal INVDTAAMT_8 { get; set; }

    public decimal INVDTAAMT_9 { get; set; }

    public decimal INVDTAAMT_10 { get; set; }

    public decimal INVDTAAMT_11 { get; set; }

    public decimal INVDTAAMT_12 { get; set; }

    public decimal INVDTAAMT_13 { get; set; }

    public decimal INVDTAAMT_14 { get; set; }

    public decimal INVDTAAMT_15 { get; set; }

    public decimal INVDTAAMT_16 { get; set; }

    public decimal INVDTAAMT_17 { get; set; }

    public decimal INVDTAAMT_18 { get; set; }

    public decimal INVDTAAMT_19 { get; set; }

    public decimal INVDTAAMT_20 { get; set; }

    public decimal INVDTAAMT_21 { get; set; }

    public decimal INVDTAAMT_22 { get; set; }

    public decimal INVDTAAMT_23 { get; set; }

    public decimal INVDTAAMT_24 { get; set; }

    public decimal INVDTAAMT_25 { get; set; }

    public decimal INVDTAAMT_26 { get; set; }

    public decimal INVDTAAMT_27 { get; set; }

    public decimal INVDTAAMT_28 { get; set; }

    public decimal INVDTAAMT_29 { get; set; }

    public byte INVDTATYP_0 { get; set; }

    public byte INVDTATYP_1 { get; set; }

    public byte INVDTATYP_2 { get; set; }

    public byte INVDTATYP_3 { get; set; }

    public byte INVDTATYP_4 { get; set; }

    public byte INVDTATYP_5 { get; set; }

    public byte INVDTATYP_6 { get; set; }

    public byte INVDTATYP_7 { get; set; }

    public byte INVDTATYP_8 { get; set; }

    public byte INVDTATYP_9 { get; set; }

    public byte INVDTATYP_10 { get; set; }

    public byte INVDTATYP_11 { get; set; }

    public byte INVDTATYP_12 { get; set; }

    public byte INVDTATYP_13 { get; set; }

    public byte INVDTATYP_14 { get; set; }

    public byte INVDTATYP_15 { get; set; }

    public byte INVDTATYP_16 { get; set; }

    public byte INVDTATYP_17 { get; set; }

    public byte INVDTATYP_18 { get; set; }

    public byte INVDTATYP_19 { get; set; }

    public byte INVDTATYP_20 { get; set; }

    public byte INVDTATYP_21 { get; set; }

    public byte INVDTATYP_22 { get; set; }

    public byte INVDTATYP_23 { get; set; }

    public byte INVDTATYP_24 { get; set; }

    public byte INVDTATYP_25 { get; set; }

    public byte INVDTATYP_26 { get; set; }

    public byte INVDTATYP_27 { get; set; }

    public byte INVDTATYP_28 { get; set; }

    public byte INVDTATYP_29 { get; set; }

    public string INVDTADSP_0 { get; set; } = null!;

    public string INVDTADSP_1 { get; set; } = null!;

    public string INVDTADSP_2 { get; set; } = null!;

    public string INVDTADSP_3 { get; set; } = null!;

    public string INVDTADSP_4 { get; set; } = null!;

    public string INVDTADSP_5 { get; set; } = null!;

    public string INVDTADSP_6 { get; set; } = null!;

    public string INVDTADSP_7 { get; set; } = null!;

    public string INVDTADSP_8 { get; set; } = null!;

    public string INVDTADSP_9 { get; set; } = null!;

    public string INVDTADSP_10 { get; set; } = null!;

    public string INVDTADSP_11 { get; set; } = null!;

    public string INVDTADSP_12 { get; set; } = null!;

    public string INVDTADSP_13 { get; set; } = null!;

    public string INVDTADSP_14 { get; set; } = null!;

    public string INVDTADSP_15 { get; set; } = null!;

    public string INVDTADSP_16 { get; set; } = null!;

    public string INVDTADSP_17 { get; set; } = null!;

    public string INVDTADSP_18 { get; set; } = null!;

    public string INVDTADSP_19 { get; set; } = null!;

    public string INVDTADSP_20 { get; set; } = null!;

    public string INVDTADSP_21 { get; set; } = null!;

    public string INVDTADSP_22 { get; set; } = null!;

    public string INVDTADSP_23 { get; set; } = null!;

    public string INVDTADSP_24 { get; set; } = null!;

    public string INVDTADSP_25 { get; set; } = null!;

    public string INVDTADSP_26 { get; set; } = null!;

    public string INVDTADSP_27 { get; set; } = null!;

    public string INVDTADSP_28 { get; set; } = null!;

    public string INVDTADSP_29 { get; set; } = null!;

    public string SFISSTCOD_0 { get; set; } = null!;

    public string SFISSTCOD_1 { get; set; } = null!;

    public string SFISSTCOD_2 { get; set; } = null!;

    public string SFISSTCOD_3 { get; set; } = null!;

    public string SFISSTCOD_4 { get; set; } = null!;

    public string SFISSTCOD_5 { get; set; } = null!;

    public string SFISSTCOD_6 { get; set; } = null!;

    public string SFISSTCOD_7 { get; set; } = null!;

    public string SFISSTCOD_8 { get; set; } = null!;

    public string SFISSTCOD_9 { get; set; } = null!;

    public string SFISSTCOD_10 { get; set; } = null!;

    public string SFISSTCOD_11 { get; set; } = null!;

    public string SFISSTCOD_12 { get; set; } = null!;

    public string SFISSTCOD_13 { get; set; } = null!;

    public string SFISSTCOD_14 { get; set; } = null!;

    public string SFISSTCOD_15 { get; set; } = null!;

    public string SFISSTCOD_16 { get; set; } = null!;

    public string SFISSTCOD_17 { get; set; } = null!;

    public string SFISSTCOD_18 { get; set; } = null!;

    public string SFISSTCOD_19 { get; set; } = null!;

    public string SFISSTCOD_20 { get; set; } = null!;

    public string SFISSTCOD_21 { get; set; } = null!;

    public string SFISSTCOD_22 { get; set; } = null!;

    public string SFISSTCOD_23 { get; set; } = null!;

    public string SFISSTCOD_24 { get; set; } = null!;

    public string SFISSTCOD_25 { get; set; } = null!;

    public string SFISSTCOD_26 { get; set; } = null!;

    public string SFISSTCOD_27 { get; set; } = null!;

    public string SFISSTCOD_28 { get; set; } = null!;

    public string SFISSTCOD_29 { get; set; } = null!;

    public string PAM_0 { get; set; } = null!;

    public string PAM_1 { get; set; } = null!;

    public string PAM_2 { get; set; } = null!;

    public string PAM_3 { get; set; } = null!;

    public decimal INSATI_0 { get; set; }

    public decimal INSATI_1 { get; set; }

    public decimal INSATI_2 { get; set; }

    public decimal INSATI_3 { get; set; }

    public string INSORDNUM_0 { get; set; } = null!;

    public string INSORDNUM_1 { get; set; } = null!;

    public string INSORDNUM_2 { get; set; } = null!;

    public string INSORDNUM_3 { get; set; } = null!;

    public short INSLIN_0 { get; set; }

    public short INSLIN_1 { get; set; }

    public short INSLIN_2 { get; set; }

    public short INSLIN_3 { get; set; }

    public short COPNBR_0 { get; set; }

    public short COPNBE_0 { get; set; }

    public string TRSCOD_0 { get; set; } = null!;

    public string ENTCOD_0 { get; set; } = null!;

    public string SRGLOCDEF_0 { get; set; } = null!;

    public string EECNAT_0 { get; set; } = null!;

    public string EECNATR_0 { get; set; } = null!;

    public string EECSCH_0 { get; set; } = null!;

    public string EECSCHR_0 { get; set; } = null!;

    public byte EECLOC_0 { get; set; }

    public byte EECTRN_0 { get; set; }

    public string EECICT_0 { get; set; } = null!;

    public string ICTCTY_0 { get; set; } = null!;

    public string FFWNUM_0 { get; set; } = null!;

    public string FFWADD_0 { get; set; } = null!;

    public string GEOCOD_0 { get; set; } = null!;

    public string INSCTYFLG_0 { get; set; } = null!;

    public string VTT_0 { get; set; } = null!;

    public int EXPNUM_0 { get; set; }

    public string CMGNUM_0 { get; set; } = null!;

    public string OPGNUM_0 { get; set; } = null!;

    public string OPGTYP_0 { get; set; } = null!;

    public string PLISTC_0 { get; set; } = null!;

    public decimal DSPTOTQTY_0 { get; set; }

    public decimal DSPTOTWEI_0 { get; set; }

    public decimal DSPTOTVOL_0 { get; set; }

    public string DSPWEU_0 { get; set; } = null!;

    public string DSPVOU_0 { get; set; } = null!;

    public byte STARPT_0 { get; set; }

    public string CREUSR_0 { get; set; } = null!;

    public DateTime CREDAT_0 { get; set; }

    public string UPDUSR_0 { get; set; } = null!;

    public DateTime UPDDAT_0 { get; set; }

    public byte ADRVAL_0 { get; set; }

    public DateTime CREDATTIM_0 { get; set; }

    public DateTime UPDDATTIM_0 { get; set; }

    public byte[] AUUID_0 { get; set; } = null!;

    public DateTime DPEDAT_0 { get; set; }

    public DateTime ARVDAT_0 { get; set; }

    public string ETD_0 { get; set; } = null!;

    public string ETA_0 { get; set; } = null!;

    public string LICPLATE_0 { get; set; } = null!;

    public string TRLLICPLATE_0 { get; set; } = null!;

    public byte SIHORITYP_0 { get; set; }

    public string SIHNUMEND_0 { get; set; } = null!;

    public short SIHCFMFLG_0 { get; set; }

    public DateTime YDATDEP_0 { get; set; }

    public string YDEPPAR_0 { get; set; } = null!;

    public string YLIBELLE_0 { get; set; } = null!;

    public byte YVALDEP_0 { get; set; }

    public int ROWID { get; set; }
}
