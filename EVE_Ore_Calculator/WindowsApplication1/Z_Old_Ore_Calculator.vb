﻿Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class OreCalculator
    Dim Mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub Veldspar_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Veldspar_IPU.Leave
        Calc_Veldspar_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Veldspar_Units_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Veldspar_Units.Leave
        Calc_Veldspar_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Concendtrated_Veldspar_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Concentrated_Veldspar_IPU.Leave
        Calc_Concentrated_Veldspar_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Concendtrated_Veldspar_Units_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Concentrated_Veldspar_Units.Leave
        Calc_Concentrated_Veldspar_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Dense_Veldspar_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dense_Veldspar_IPU.Leave
        Calc_Dense_Veldspar_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Dense_Veldspar_Units_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dense_Veldspar_Units.Leave
        Calc_Dense_Veldspar_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Scordtie_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scordite_IPU.Leave
        Calc_Scordite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Scordite_Units_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scordite_Units.Leave
        Calc_Scordite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Condensed_Scordite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Condensed_Scordite_IPU.Leave
        Calc_Condensed_Scordite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Condensed_Scordite_Units_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Condensed_Scordite_Units.Leave
        Calc_Condensed_Scordite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Massive_Scordtie_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Massive_Scordite_IPU.Leave
        Calc_Massive_Scordite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Massive_Scordite_Units_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Massive_Scordite_Units.Leave
        Calc_Massive_Scordite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pyroxeres_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pyroxeres_IPU.Leave
        Calc_Pyroxeres_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pyroxeres_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pyroxeres_Units.Leave
        Calc_Pyroxeres_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Solid_Pyroxeres_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Solid_Pyroxeres_IPU.Leave
        Calc_Solid_Pyroxeres_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Solid_Pyroxeres_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Solid_Pyroxeres_Units.Leave
        Calc_Solid_Pyroxeres_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Viscous_Pyroxeres_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viscous_Pyroxeres_IPU.Leave
        Calc_Viscous_Pyroxeres_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Viscous_Pyroxeres_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viscous_Pyroxeres_Units.Leave
        Calc_Viscous_Pyroxeres_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Plagioclase_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Plagioclase_IPU.Leave
        Calc_Plagioclase_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Plagioclase_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Plagioclase_Units.Leave
        Calc_Plagioclase_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Azure_Plagioclase_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Azure_Plagioclase_IPU.Leave
        Calc_Azure_Plagioclase_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Azure_Plagioclase_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Azure_Plagioclase_Units.Leave
        Calc_Azure_Plagioclase_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Rich_Plagioclase_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rich_Plagioclase_IPU.Leave
        Calc_Rich_Plagioclase_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Rich_Plagioclase_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rich_Plagioclase_Units.Leave
        Calc_Rich_Plagioclase_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Omber_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Omber_IPU.Leave
        Calc_Omber_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Omber_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Omber_Units.Leave
        Calc_Omber_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Silvery_Omber_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Silvery_Omber_IPU.Leave
        Calc_Silvery_Omber_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Silvery_Omber_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Silvery_Omber_Units.Leave
        Calc_Silvery_Omber_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Golden_Omber_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Golden_Omber_IPU.Leave
        Calc_Golden_Omber_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Golden_Omber_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Golden_Omber_Units.Leave
        Calc_Golden_Omber_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Kernite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kernite_IPU.Leave
        Calc_Kernite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Kernite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kernite_Units.Leave
        Calc_Kernite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Luminous_Kernite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Luminous_Kernite_IPU.Leave
        Calc_Luminous_Kernite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Luminous_Kernite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Luminous_Kernite_Units.Leave
        Calc_Luminous_Kernite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Fiery_Kernite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fiery_Kernite_IPU.Leave
        Calc_Fiery_Kernite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Fiery_Kernite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fiery_Kernite_Units.Leave
        Calc_Fiery_Kernite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Jaspet_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jaspet_IPU.Leave
        Calc_Jaspet_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Jaspet_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jaspet_Units.Leave
        Calc_Jaspet_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pure_Jaspet_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pure_Jaspet_IPU.Leave
        Calc_Pure_Jaspet_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pure_Jaspet_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pure_Jaspet_Units.Leave
        Calc_Pure_Jaspet_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pristine_Jaspet_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pristine_Jaspet_IPU.Leave
        Calc_Jaspet_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pristine_Jaspet_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pristine_Jaspet_Units.Leave
        Calc_Pristine_Jaspet_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Hemorphite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hemorphite_IPU.Leave
        Calc_Hemorphite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Hemorphite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hemorphite_Units.Leave
        Calc_Hemorphite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Vivid_Hemorphite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vivid_Hemorphite_IPU.Leave
        Calc_Vivid_Hemorphite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Vivid_Hemorphite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vivid_Hemorphite_Units.Leave
        Calc_Vivid_Hemorphite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Radiant_Hemorphite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiant_Hemorphite_IPU.Leave
        Calc_Radiant_Hemorphite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Radiant_Hemorphite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiant_Hemorphite_Units.Leave
        Calc_Radiant_Hemorphite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Hedbergite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hedbergite_IPU.Leave
        Calc_Hedbergite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Hedbergite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hedbergite_Units.Leave
        Calc_Hedbergite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Vitric_Hedbergite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vitric_Hedbergite_IPU.Leave
        Calc_Vitric_Hedbergite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Vitric_Hedbergite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vitric_Hedbergite_Units.Leave
        Calc_Vitric_Hedbergite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Glazed_Hedbergite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Glazed_Hedbergite_IPU.Leave
        Calc_Glazed_Hedbergite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Glazed_Hedbergite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Glazed_Hedbergite_Units.Leave
        Calc_Glazed_Hedbergite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Gneiss_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gneiss_IPU.Leave
        Calc_Gneiss_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Gneiss_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gneiss_Units.Leave
        Calc_Gneiss_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Iridescent_Gneiss_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Iridescent_Gneiss_IPU.Leave
        Calc_Iridescent_Gneiss_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Iridescent_Gneiss_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Iridescent_Gneiss_Units.Leave
        Calc_Iridescent_Gneiss_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pristamtic_Gneiss_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prismatic_Gneiss_IPU.Leave
        Calc_Prismatic_Gneiss_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Prismatic_Gneiss_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prismatic_Gneiss_Units.Leave
        Calc_Prismatic_Gneiss_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Dark_Ochre_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dark_Ochre_IPU.Leave
        Calc_Dark_Ochre_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Dark_Ochre_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dark_Ochre_Units.Leave
        Calc_Dark_Ochre_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Onyx_Ochre_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Onyx_Ochre_IPU.Leave
        Calc_Onyx_Ochre_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Onyx_Ochre_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Onyx_Ochre_Units.Leave
        Calc_Onyx_Ochre_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Obsidian_Ochre_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Obsidian_Ochre_IPU.Leave
        Calc_Obsidian_Ochre_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Obsidian_Ochre_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Obsidian_Ochre_Units.Leave
        Calc_Obsidian_Ochre_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Crokite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crokite_IPU.Leave
        Calc_Crokite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Crokite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crokite_Units.Leave
        Calc_Crokite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Sharp_Crokite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sharp_Crokite_IPU.Leave
        Calc_Sharp_Crokite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Sharp_Crokite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sharp_Crokite_Units.Leave
        Calc_Sharp_Crokite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Crystalline_Crokite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crystalline_Crokite_IPU.Leave
        Calc_Crystalline_Crokite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Crystalline_Crokite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crystalline_Crokite_Units.Leave
        Calc_Crystalline_Crokite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Spodumain_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spodumain_IPU.Leave
        Calc_Spodumain_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Spodumain_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spodumain_Units.Leave
        Calc_Spodumain_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Bright_Spodumain_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bright_Spodumain_IPU.Leave
        Calc_Bright_Spodumain_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Bright_Spodumain_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bright_Spodumain_Units.Leave
        Calc_Bright_Spodumain_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Gleaming_Spodumain_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gleaming_Spodumain_IPU.Leave
        Calc_Gleaming_Spodumain_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Gleaming_Spodumain_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gleaming_Spodumain_Units.Leave
        Calc_Gleaming_Spodumain_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Bistot_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bistot_IPU.Leave
        Calc_Bistot_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Bistot_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bistot_Units.Leave
        Calc_Bistot_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Triclinic_Bistot_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Triclinic_Bistot_IPU.Leave
        Calc_Triclinic_Bistot_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Triclinic_Bistot_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Triclinic_Bistot_Units.Leave
        Calc_Triclinic_Bistot_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Monoclinic_Bistot_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monoclinic_Bistot_IPU.Leave
        Calc_Monoclinic_Bistot_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Monoclinic_Bistot_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monoclinic_Bistot_Units.Leave
        Calc_Monoclinic_Bistot_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Arkonor_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Arkonor_IPU.Leave
        Calc_Arkonor_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Arkonor_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Arkonor_Units.Leave
        Calc_Arkonor_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Crimson_Arkonor_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crimson_Arkonor_IPU.Leave
        Calc_Crimson_Arkonor_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Crimson_Arkonor_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crimson_Arkonor_Units.Leave
        Calc_Crimson_Arkonor_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Prime_Arkonor_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prime_Arkonor_IPU.Leave
        Calc_Prime_Arkonor_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Prime_Arkonor_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prime_Arkonor_Units.Leave
        Calc_Prime_Arkonor_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Mercoxit_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mercoxit_IPU.Leave
        Calc_Mercoxit_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Mercoxit_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mercoxit_Units.Leave
        Calc_Mercoxit_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Magma_Mercoxit_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Magma_Mercoxit_IPU.Leave
        Calc_Magma_Mercoxit_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Magma_Mercoxit_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Magma_Mercoxit_Units.Leave
        Calc_Magma_Mercoxit_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Vitreous_Mercoxit_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vitreous_Mercoxit_IPU.Leave
        Calc_Vitreous_Mercoxit_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Vitreous_Mercoxit_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vitreous_Mercoxit_Units.Leave
        Calc_Vitreous_Mercoxit_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Tritanium_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tritanium_IPU.Leave
        Calc_Tritanium_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Tritainium_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tritanium_Units.Leave
        Calc_Tritanium_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pyerite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pyerite_IPU.Leave
        Calc_Pyerite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pyerite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pyerite_Units.Leave
        Calc_Pyerite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Mexallon_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mexallon_IPU.Leave
        Calc_Mexallon_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Mexallon_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mexallon_Units.Leave
        Calc_Mexallon_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Isogen_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Isogen_IPU.Leave
        Calc_Isogen_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Isogen_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Isogen_Units.Leave
        Calc_Isogen_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Nocxium_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nocxium_IPU.Leave
        Calc_Nocxium_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Nocxium_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nocxium_Units.Leave
        Calc_Nocxium_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Zydrine_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zydrine_IPU.Leave
        Calc_Zydrine_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Zydrine_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zydrine_Units.Leave
        Calc_Zydrine_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Megacyte_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Megacyte_IPU.Leave
        Calc_Megacyte_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Megacyte_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Megacyte_Units.Leave
        Calc_Megacyte_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Morphite_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Morphite_IPU.Leave
        Calc_Morphite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Morphite_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Morphite_Units.Leave
        Calc_Morphite_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub White_Glaze_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles White_Glaze_IPU.Leave
        Calc_White_Glaze_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub White_Glaze_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles White_Glaze_Units.Leave
        Calc_White_Glaze_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pristine_White_Glaze_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pristine_White_Glaze_IPU.Leave
        Calc_Pristine_White_Glaze_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Pristine_White_Glaze_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pristine_White_Glaze_Units.Leave
        Calc_Pristine_White_Glaze_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Glacial_Mass_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Glacial_Mass_IPU.Leave
        Calc_Glacial_Mass_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Glacial_Mass_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Glacial_Mass_Units.Leave
        Calc_Glacial_Mass_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Smooth_Glacial_Mass_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Smooth_Glacial_Mass_IPU.Leave
        Calc_Smooth_Glacial_Mass_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Smooth_Glacial_Mass_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Smooth_Glacial_Mass_Units.Leave
        Calc_Smooth_Glacial_Mass_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Blue_Ice_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue_Ice_IPU.Leave
        Calc_Blue_Ice_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Blue_Ice_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue_Ice_Units.Leave
        Calc_Blue_Ice_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Thick_Blue_Ice_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Thick_Blue_Ice_IPU.Leave
        Calc_Thick_Blue_Ice_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Thick_Blue_Ice_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Thick_Blue_Ice_Units.Leave
        Calc_Thick_Blue_Ice_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Clear_Icicle_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Icicle_IPU.Leave
        Calc_Clear_Icicle_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Clear_Icicle_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Icicle_Units.Leave
        Calc_Clear_Icicle_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Enriched_Clear_Icicle_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enriched_Clear_Icicle_IPU.Leave
        Calc_Enriched_Clear_Icicle_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Enriched_Clear_Icicle_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enriched_Clear_Icicle_Units.Leave
        Calc_Enriched_Clear_Icicle_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Glare_Crust_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Glare_Crust_IPU.Leave
        Calc_Glare_Crust_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Glare_Crust_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Glare_Crust_Units.Leave
        Calc_Glare_Crust_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Dark_Glitter_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dark_Glitter_IPU.Leave
        Calc_Dark_Glitter_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Dark_Glitter_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dark_Glitter_Units.Leave
        Calc_Dark_Glitter_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Gelidus_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gelidus_IPU.Leave
        Calc_Gelidus_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Gelidus_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gelidus_Units.Leave
        Calc_Gelidus_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Krystallos_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Krystallos_IPU.Leave
        Calc_Krystallos_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Krystallos_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Krystallos_Units.Leave
        Calc_Krystallos_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Heavy_Water_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Heavy_Water_IPU.Leave
        Calc_Heavy_Water_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Heavy_Water_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Heavy_Water_Units.Leave
        Calc_Heavy_Water_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Helium_Isotopes_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Helium_Isotopes_IPU.Leave
        Calc_Helium_Isotopes_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Helium_Isotopes_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Helium_Isotopes_Units.Leave
        Calc_Helium_Isotopes_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Hydrogen_Isotopes_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hydrogen_Isotopes_IPU.Leave
        Calc_Hydrogen_Isotopes_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Hydrogen_Isotopes_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hydrogen_Isotopes_Units.Leave
        Calc_Hydrogen_Isotopes_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Liquid_Ozone_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Liquid_Ozone_IPU.Leave
        Calc_Liquid_Ozone_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Liquid_Ozone_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Liquid_Ozone_Units.Leave
        Calc_Liquid_Ozone_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Nitrogen_Isotopes_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nitrogen_Isotopes_IPU.Leave
        Calc_Nitrogen_Isotopes_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Nitrogen_Isotopes_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nitrogen_Isotopes_Units.Leave
        Calc_Nitrogen_Isotopes_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Oxygen_Isotopes_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Oxygen_Isotopes_IPU.Leave
        Calc_Oxygen_Isotopes_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Oxygen_Isotopes_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Oxygen_Isotopes_Units.Leave
        Calc_Oxygen_Isotopes_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Strontium_Clathrates_IPU_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Strontium_Clathrates_IPU.Leave
        Calc_Strontium_Clathrates_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub
    Private Sub Strontium_Clathrates_Unit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Strontium_Clathrates_Units.Leave
        Calc_Strontium_Clathrates_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub

    Private Sub Calc_Veldspar_ISK()
        If (Veldspar_IPU.Text.Trim().Length = 0 Or Veldspar_Units.Text.Trim().Length = 0) Then
            Veldspar_Total.Text = "0"
        Else
            Veldspar_Total.Text = Convert.ToDecimal(Veldspar_IPU.Text) * Convert.ToDecimal(Veldspar_Units.Text)
        End If
    End Sub
    Private Sub Calc_Concentrated_Veldspar_ISK()
        If (Concentrated_Veldspar_IPU.Text.Trim().Length = 0 Or Concentrated_Veldspar_Units.Text.Trim().Length = 0) Then
            Concentrated_Veldspar_Total.Text = "0"
        Else
            Concentrated_Veldspar_Total.Text = Convert.ToDecimal(Concentrated_Veldspar_IPU.Text) * Convert.ToDecimal(Concentrated_Veldspar_Units.Text)
        End If
    End Sub
    Private Sub Calc_Dense_Veldspar_ISK()
        If (Dense_Veldspar_IPU.Text.Trim().Length = 0 Or Dense_Veldspar_Units.Text.Trim().Length = 0) Then
            Dense_Veldspar_Total.Text = "0"
        Else
            Dense_Veldspar_Total.Text = Convert.ToDecimal(Dense_Veldspar_IPU.Text) * Convert.ToDecimal(Dense_Veldspar_Units.Text)
        End If
    End Sub
    Private Sub Calc_Scordite_ISK()
        If (Scordite_IPU.Text.Trim().Length = 0 Or Scordite_Units.Text.Trim().Length = 0) Then
            Scordite_Total.Text = "0"
        Else
            Scordite_Total.Text = Convert.ToDecimal(Scordite_IPU.Text) * Convert.ToDecimal(Scordite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Condensed_Scordite_ISK()
        If (Condensed_Scordite_IPU.Text.Trim().Length = 0 Or Condensed_Scordite_Units.Text.Trim().Length = 0) Then
            Condensed_Scordite_Total.Text = "0"
        Else
            Condensed_Scordite_Total.Text = Convert.ToDecimal(Condensed_Scordite_IPU.Text) * Convert.ToDecimal(Condensed_Scordite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Massive_Scordite_ISK()
        If (Massive_Scordite_IPU.Text.Trim().Length = 0 Or Massive_Scordite_Units.Text.Trim().Length = 0) Then
            Massive_Scordite_Total.Text = "0"
        Else
            Massive_Scordite_Total.Text = Convert.ToDecimal(Massive_Scordite_IPU.Text) * Convert.ToDecimal(Massive_Scordite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Pyroxeres_ISK()
        If (Pyroxeres_IPU.Text.Trim().Length = 0 Or Pyroxeres_Units.Text.Trim().Length = 0) Then
            Pyroxeres_Total.Text = "0"
        Else
            Pyroxeres_Total.Text = Convert.ToDecimal(Pyroxeres_IPU.Text) * Convert.ToDecimal(Pyroxeres_Units.Text)
        End If
    End Sub
    Private Sub Calc_Solid_Pyroxeres_ISK()
        If (Solid_Pyroxeres_IPU.Text.Trim().Length = 0 Or Solid_Pyroxeres_Units.Text.Trim().Length = 0) Then
            Solid_Pyroxeres_Total.Text = "0"
        Else
            Solid_Pyroxeres_Total.Text = Convert.ToDecimal(Solid_Pyroxeres_IPU.Text) * Convert.ToDecimal(Solid_Pyroxeres_Units.Text)
        End If
    End Sub
    Private Sub Calc_Viscous_Pyroxeres_ISK()
        If (Viscous_Pyroxeres_IPU.Text.Trim().Length = 0 Or Viscous_Pyroxeres_Units.Text.Trim().Length = 0) Then
            Viscous_Pyroxeres_Total.Text = "0"
        Else
            Viscous_Pyroxeres_Total.Text = Convert.ToDecimal(Viscous_Pyroxeres_IPU.Text) * Convert.ToDecimal(Viscous_Pyroxeres_Units.Text)
        End If
    End Sub
    Private Sub Calc_Plagioclase_ISK()
        If (Plagioclase_IPU.Text.Trim().Length = 0 Or Plagioclase_Units.Text.Trim().Length = 0) Then
            Plagioclase_Total.Text = "0"
        Else
            Plagioclase_Total.Text = Convert.ToDecimal(Plagioclase_IPU.Text) * Convert.ToDecimal(Plagioclase_Units.Text)
        End If
    End Sub
    Private Sub Calc_Azure_Plagioclase_ISK()
        If (Azure_Plagioclase_IPU.Text.Trim().Length = 0 Or Azure_Plagioclase_Units.Text.Trim().Length = 0) Then
            Azure_Plagioclase_Total.Text = "0"
        Else
            Azure_Plagioclase_Total.Text = Convert.ToDecimal(Azure_Plagioclase_IPU.Text) * Convert.ToDecimal(Azure_Plagioclase_Units.Text)
        End If
    End Sub
    Private Sub Calc_Rich_Plagioclase_ISK()
        If (Rich_Plagioclase_IPU.Text.Trim().Length = 0 Or Rich_Plagioclase_Units.Text.Trim().Length = 0) Then
            Rich_Plagioclase_Total.Text = "0"
        Else
            Rich_Plagioclase_Total.Text = Convert.ToDecimal(Rich_Plagioclase_IPU.Text) * Convert.ToDecimal(Rich_Plagioclase_Units.Text)
        End If
    End Sub
    Private Sub Calc_Omber_ISK()
        If (Omber_IPU.Text.Trim().Length = 0 Or Omber_Units.Text.Trim().Length = 0) Then
            Omber_Total.Text = "0"
        Else
            Omber_Total.Text = Convert.ToDecimal(Omber_IPU.Text) * Convert.ToDecimal(Omber_Units.Text)
        End If
    End Sub
    Private Sub Calc_Silvery_Omber_ISK()
        If (Silvery_Omber_IPU.Text.Trim().Length = 0 Or Silvery_Omber_Units.Text.Trim().Length = 0) Then
            Silvery_Omber_Total.Text = "0"
        Else
            Silvery_Omber_Total.Text = Convert.ToDecimal(Silvery_Omber_IPU.Text) * Convert.ToDecimal(Silvery_Omber_Units.Text)
        End If
    End Sub
    Private Sub Calc_Golden_Omber_ISK()
        If (Golden_Omber_IPU.Text.Trim().Length = 0 Or Golden_Omber_Units.Text.Trim().Length = 0) Then
            Golden_Omber_Total.Text = "0"
        Else
            Golden_Omber_Total.Text = Convert.ToDecimal(Golden_Omber_IPU.Text) * Convert.ToDecimal(Golden_Omber_Units.Text)
        End If
    End Sub
    Private Sub Calc_Kernite_ISK()
        If (Kernite_IPU.Text.Trim().Length = 0 Or Kernite_Units.Text.Trim().Length = 0) Then
            Kernite_Total.Text = "0"
        Else
            Kernite_Total.Text = Convert.ToDecimal(Kernite_IPU.Text) * Convert.ToDecimal(Kernite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Luminous_Kernite_ISK()
        If (Luminous_Kernite_IPU.Text.Trim().Length = 0 Or Luminous_Kernite_Units.Text.Trim().Length = 0) Then
            Luminous_Kernite_Total.Text = "0"
        Else
            Luminous_Kernite_Total.Text = Convert.ToDecimal(Luminous_Kernite_IPU.Text) * Convert.ToDecimal(Luminous_Kernite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Fiery_Kernite_ISK()
        If (Fiery_Kernite_IPU.Text.Trim().Length = 0 Or Fiery_Kernite_Units.Text.Trim().Length = 0) Then
            Fiery_Kernite_Total.Text = "0"
        Else
            Fiery_Kernite_Total.Text = Convert.ToDecimal(Fiery_Kernite_IPU.Text) * Convert.ToDecimal(Fiery_Kernite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Jaspet_ISK()
        If (Jaspet_IPU.Text.Trim().Length = 0 Or Jaspet_Units.Text.Trim().Length = 0) Then
            Jaspet_Total.Text = "0"
        Else
            Jaspet_Total.Text = Convert.ToDecimal(Jaspet_IPU.Text) * Convert.ToDecimal(Jaspet_Units.Text)
        End If
    End Sub
    Private Sub Calc_Pure_Jaspet_ISK()
        If (Pure_Jaspet_IPU.Text.Trim().Length = 0 Or Pure_Jaspet_Units.Text.Trim().Length = 0) Then
            Pure_Jaspet_Total.Text = "0"
        Else
            Pure_Jaspet_Total.Text = Convert.ToDecimal(Pure_Jaspet_IPU.Text) * Convert.ToDecimal(Pure_Jaspet_Units.Text)
        End If
    End Sub
    Private Sub Calc_Pristine_Jaspet_ISK()
        If (Pristine_Jaspet_IPU.Text.Trim().Length = 0 Or Pristine_Jaspet_Units.Text.Trim().Length = 0) Then
            Pristine_Jaspet_Total.Text = "0"
        Else
            Pristine_Jaspet_Total.Text = Convert.ToDecimal(Pristine_Jaspet_IPU.Text) * Convert.ToDecimal(Pristine_Jaspet_Units.Text)
        End If
    End Sub
    Private Sub Calc_Hemorphite_ISK()
        If (Hemorphite_IPU.Text.Trim().Length = 0 Or Hemorphite_Units.Text.Trim().Length = 0) Then
            Hemorphite_Total.Text = "0"
        Else
            Hemorphite_Total.Text = Convert.ToDecimal(Hemorphite_IPU.Text) * Convert.ToDecimal(Hemorphite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Vivid_Hemorphite_ISK()
        If (Vivid_Hemorphite_IPU.Text.Trim().Length = 0 Or Vivid_Hemorphite_Units.Text.Trim().Length = 0) Then
            Vivid_Hemorphite_Total.Text = "0"
        Else
            Vivid_Hemorphite_Total.Text = Convert.ToDecimal(Vivid_Hemorphite_IPU.Text) * Convert.ToDecimal(Vivid_Hemorphite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Radiant_Hemorphite_ISK()
        If (Radiant_Hemorphite_IPU.Text.Trim().Length = 0 Or Radiant_Hemorphite_Units.Text.Trim().Length = 0) Then
            Radiant_Hemorphite_Total.Text = "0"
        Else
            Radiant_Hemorphite_Total.Text = Convert.ToDecimal(Radiant_Hemorphite_IPU.Text) * Convert.ToDecimal(Radiant_Hemorphite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Hedbergite_ISK()
        If (Hedbergite_IPU.Text.Trim().Length = 0 Or Hedbergite_Units.Text.Trim().Length = 0) Then
            Hedbergite_Total.Text = "0"
        Else
            Hedbergite_Total.Text = Convert.ToDecimal(Hedbergite_IPU.Text) * Convert.ToDecimal(Hedbergite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Vitric_Hedbergite_ISK()
        If (Vitric_Hedbergite_IPU.Text.Trim().Length = 0 Or Vitric_Hedbergite_Units.Text.Trim().Length = 0) Then
            Vitric_Hedbergite_Total.Text = "0"
        Else
            Vitric_Hedbergite_Total.Text = Convert.ToDecimal(Vitric_Hedbergite_IPU.Text) * Convert.ToDecimal(Vitric_Hedbergite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Glazed_Hedbergite_ISK()
        If (Glazed_Hedbergite_IPU.Text.Trim().Length = 0 Or Glazed_Hedbergite_Units.Text.Trim().Length = 0) Then
            Glazed_Hedbergite_Total.Text = "0"
        Else
            Glazed_Hedbergite_Total.Text = Convert.ToDecimal(Glazed_Hedbergite_IPU.Text) * Convert.ToDecimal(Glazed_Hedbergite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Gneiss_ISK()
        If (Gneiss_IPU.Text.Trim().Length = 0 Or Gneiss_Units.Text.Trim().Length = 0) Then
            Gneiss_Total.Text = "0"
        Else
            Gneiss_Total.Text = Convert.ToDecimal(Gneiss_IPU.Text) * Convert.ToDecimal(Gneiss_Units.Text)
        End If
    End Sub
    Private Sub Calc_Iridescent_Gneiss_ISK()
        If (Iridescent_Gneiss_IPU.Text.Trim().Length = 0 Or Iridescent_Gneiss_Units.Text.Trim().Length = 0) Then
            Iridescent_Gneiss_Total.Text = "0"
        Else
            Iridescent_Gneiss_Total.Text = Convert.ToDecimal(Iridescent_Gneiss_IPU.Text) * Convert.ToDecimal(Iridescent_Gneiss_Units.Text)
        End If
    End Sub
    Private Sub Calc_Prismatic_Gneiss_ISK()
        If (Prismatic_Gneiss_IPU.Text.Trim().Length = 0 Or Prismatic_Gneiss_Units.Text.Trim().Length = 0) Then
            Prismatic_Gneiss_Total.Text = "0"
        Else
            Prismatic_Gneiss_Total.Text = Convert.ToDecimal(Prismatic_Gneiss_IPU.Text) * Convert.ToDecimal(Prismatic_Gneiss_Units.Text)
        End If
    End Sub
    Private Sub Calc_Dark_Ochre_ISK()
        If (Dark_Ochre_IPU.Text.Trim().Length = 0 Or Dark_Ochre_Units.Text.Trim().Length = 0) Then
            Dark_Ochre_Total.Text = "0"
        Else
            Dark_Ochre_Total.Text = Convert.ToDecimal(Dark_Ochre_IPU.Text) * Convert.ToDecimal(Dark_Ochre_Units.Text)
        End If
    End Sub
    Private Sub Calc_Onyx_Ochre_ISK()
        If (Onyx_Ochre_IPU.Text.Trim().Length = 0 Or Onyx_Ochre_Units.Text.Trim().Length = 0) Then
            Onyx_Ochre_Total.Text = "0"
        Else
            Onyx_Ochre_Total.Text = Convert.ToDecimal(Onyx_Ochre_IPU.Text) * Convert.ToDecimal(Onyx_Ochre_Units.Text)
        End If
    End Sub
    Private Sub Calc_Obsidian_Ochre_ISK()
        If (Obsidian_Ochre_IPU.Text.Trim().Length = 0 Or Obsidian_Ochre_Units.Text.Trim().Length = 0) Then
            Obsidian_Ochre_Total.Text = "0"
        Else
            Obsidian_Ochre_Total.Text = Convert.ToDecimal(Obsidian_Ochre_IPU.Text) * Convert.ToDecimal(Obsidian_Ochre_Units.Text)
        End If
    End Sub
    Private Sub Calc_Crokite_ISK()
        If (Crokite_IPU.Text.Trim().Length = 0 Or Crokite_Units.Text.Trim().Length = 0) Then
            Crokite_Total.Text = "0"
        Else
            Crokite_Total.Text = Convert.ToDecimal(Crokite_IPU.Text) * Convert.ToDecimal(Crokite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Sharp_Crokite_ISK()
        If (Sharp_Crokite_IPU.Text.Trim().Length = 0 Or Sharp_Crokite_Units.Text.Trim().Length = 0) Then
            Sharp_Crokite_Total.Text = "0"
        Else
            Sharp_Crokite_Total.Text = Convert.ToDecimal(Sharp_Crokite_IPU.Text) * Convert.ToDecimal(Sharp_Crokite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Crystalline_Crokite_ISK()
        If (Crystalline_Crokite_IPU.Text.Trim().Length = 0 Or Crystalline_Crokite_Units.Text.Trim().Length = 0) Then
            Crystalline_Crokite_Total.Text = "0"
        Else
            Crystalline_Crokite_Total.Text = Convert.ToDecimal(Crystalline_Crokite_IPU.Text) * Convert.ToDecimal(Crystalline_Crokite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Spodumain_ISK()
        If (Spodumain_IPU.Text.Trim().Length = 0 Or Spodumain_Units.Text.Trim().Length = 0) Then
            Spodumain_Total.Text = "0"
        Else
            Spodumain_Total.Text = Convert.ToDecimal(Spodumain_IPU.Text) * Convert.ToDecimal(Spodumain_Units.Text)
        End If
    End Sub
    Private Sub Calc_Bright_Spodumain_ISK()
        If (Bright_Spodumain_IPU.Text.Trim().Length = 0 Or Bright_Spodumain_Units.Text.Trim().Length = 0) Then
            Bright_Spodumain_Total.Text = "0"
        Else
            Bright_Spodumain_Total.Text = Convert.ToDecimal(Bright_Spodumain_IPU.Text) * Convert.ToDecimal(Bright_Spodumain_Units.Text)
        End If
    End Sub
    Private Sub Calc_Gleaming_Spodumain_ISK()
        If (Gleaming_Spodumain_IPU.Text.Trim().Length = 0 Or Gleaming_Spodumain_Units.Text.Trim().Length = 0) Then
            Gleaming_Spodumain_Total.Text = "0"
        Else
            Gleaming_Spodumain_Total.Text = Convert.ToDecimal(Gleaming_Spodumain_IPU.Text) * Convert.ToDecimal(Gleaming_Spodumain_Units.Text)
        End If
    End Sub
    Private Sub Calc_Bistot_ISK()
        If (Bistot_IPU.Text.Trim().Length = 0 Or Bistot_Units.Text.Trim().Length = 0) Then
            Bistot_Total.Text = "0"
        Else
            Bistot_Total.Text = Convert.ToDecimal(Bistot_IPU.Text) * Convert.ToDecimal(Bistot_Units.Text)
        End If
    End Sub
    Private Sub Calc_Triclinic_Bistot_ISK()
        If (Triclinic_Bistot_IPU.Text.Trim().Length = 0 Or Triclinic_Bistot_Units.Text.Trim().Length = 0) Then
            Triclinic_Bistot_Total.Text = "0"
        Else
            Triclinic_Bistot_Total.Text = Convert.ToDecimal(Triclinic_Bistot_IPU.Text) * Convert.ToDecimal(Triclinic_Bistot_Units.Text)
        End If
    End Sub
    Private Sub Calc_Monoclinic_Bistot_ISK()
        If (Monoclinic_Bistot_IPU.Text.Trim().Length = 0 Or Monoclinic_Bistot_Units.Text.Trim().Length = 0) Then
            Monoclinic_Bistot_Total.Text = "0"
        Else
            Monoclinic_Bistot_Total.Text = Convert.ToDecimal(Monoclinic_Bistot_IPU.Text) * Convert.ToDecimal(Monoclinic_Bistot_Units.Text)
        End If
    End Sub
    Private Sub Calc_Arkonor_ISK()
        If (Arkonor_IPU.Text.Trim().Length = 0 Or Arkonor_Units.Text.Trim().Length = 0) Then
            Arkonor_Total.Text = "0"
        Else
            Arkonor_Total.Text = Convert.ToDecimal(Arkonor_IPU.Text) * Convert.ToDecimal(Arkonor_Units.Text)
        End If
    End Sub
    Private Sub Calc_Crimson_Arkonor_ISK()
        If (Crimson_Arkonor_IPU.Text.Trim().Length = 0 Or Crimson_Arkonor_Units.Text.Trim().Length = 0) Then
            Crimson_Arkonor_Total.Text = "0"
        Else
            Crimson_Arkonor_Total.Text = Convert.ToDecimal(Crimson_Arkonor_IPU.Text) * Convert.ToDecimal(Crimson_Arkonor_Units.Text)
        End If
    End Sub
    Private Sub Calc_Prime_Arkonor_ISK()
        If (Prime_Arkonor_IPU.Text.Trim().Length = 0 Or Prime_Arkonor_Units.Text.Trim().Length = 0) Then
            Prime_Arkonor_Total.Text = "0"
        Else
            Prime_Arkonor_Total.Text = Convert.ToDecimal(Prime_Arkonor_IPU.Text) * Convert.ToDecimal(Prime_Arkonor_Units.Text)
        End If
    End Sub
    Private Sub Calc_Mercoxit_ISK()
        If (Mercoxit_IPU.Text.Trim().Length = 0 Or Mercoxit_Units.Text.Trim().Length = 0) Then
            Mercoxit_Total.Text = "0"
        Else
            Mercoxit_Total.Text = Convert.ToDecimal(Mercoxit_IPU.Text) * Convert.ToDecimal(Mercoxit_Units.Text)
        End If
    End Sub
    Private Sub Calc_Magma_Mercoxit_ISK()
        If (Magma_Mercoxit_IPU.Text.Trim().Length = 0 Or Magma_Mercoxit_Units.Text.Trim().Length = 0) Then
            Magma_Mercoxit_Total.Text = "0"
        Else
            Magma_Mercoxit_Total.Text = Convert.ToDecimal(Magma_Mercoxit_IPU.Text) * Convert.ToDecimal(Magma_Mercoxit_Units.Text)
        End If
    End Sub
    Private Sub Calc_Vitreous_Mercoxit_ISK()
        If (Vitreous_Mercoxit_IPU.Text.Trim().Length = 0 Or Vitreous_Mercoxit_Units.Text.Trim().Length = 0) Then
            Vitreous_Mercoxit_Total.Text = "0"
        Else
            Vitreous_Mercoxit_Total.Text = Convert.ToDecimal(Vitreous_Mercoxit_IPU.Text) * Convert.ToDecimal(Vitreous_Mercoxit_Units.Text)
        End If
    End Sub
    Private Sub Calc_Tritanium_ISK()
        If (Tritanium_IPU.Text.Trim().Length = 0 Or Tritanium_Units.Text.Trim().Length = 0) Then
            Tritanium_Total.Text = "0"
        Else
            Tritanium_Total.Text = Convert.ToDecimal(Tritanium_IPU.Text) * Convert.ToDecimal(Tritanium_Units.Text)
        End If
    End Sub
    Private Sub Calc_Pyerite_ISK()
        If (Pyerite_IPU.Text.Trim().Length = 0 Or Pyerite_Units.Text.Trim().Length = 0) Then
            Pyerite_Total.Text = "0"
        Else
            Pyerite_Total.Text = Convert.ToDecimal(Pyerite_IPU.Text) * Convert.ToDecimal(Pyerite_Units.Text)
        End If
    End Sub
    Private Sub Calc_Mexallon_ISK()
        If (Mexallon_IPU.Text.Trim().Length = 0 Or Mexallon_Units.Text.Trim().Length = 0) Then
            Mexallon_Total.Text = "0"
        Else
            Mexallon_Total.Text = Convert.ToDecimal(Mexallon_IPU.Text) * Convert.ToDecimal(Mexallon_Units.Text)
        End If
    End Sub
    Private Sub Calc_Isogen_ISK()
        If (Isogen_IPU.Text.Trim().Length = 0 Or Isogen_Units.Text.Trim().Length = 0) Then
            Isogen_Total.Text = "0"
        Else
            Isogen_Total.Text = Convert.ToDecimal(Isogen_IPU.Text) * Convert.ToDecimal(Isogen_Units.Text)
        End If
    End Sub
    Private Sub Calc_Nocxium_ISK()
        If (Nocxium_IPU.Text.Trim().Length = 0 Or Nocxium_Units.Text.Trim().Length = 0) Then
            Nocxium_Total.Text = "0"
        Else
            Nocxium_Total.Text = Convert.ToDecimal(Nocxium_IPU.Text) * Convert.ToDecimal(Nocxium_Units.Text)
        End If
    End Sub
    Private Sub Calc_Zydrine_ISK()
        If (Zydrine_IPU.Text.Trim().Length = 0 Or Zydrine_Units.Text.Trim().Length = 0) Then
            Zydrine_Total.Text = "0"
        Else
            Zydrine_Total.Text = Convert.ToDecimal(Zydrine_IPU.Text) * Convert.ToDecimal(Zydrine_Units.Text)
        End If
    End Sub
    Private Sub Calc_Megacyte_ISK()
        If (Megacyte_IPU.Text.Trim().Length = 0 Or Megacyte_Units.Text.Trim().Length = 0) Then
            Megacyte_Total.Text = "0"
        Else
            Megacyte_Total.Text = Convert.ToDecimal(Megacyte_IPU.Text) * Convert.ToDecimal(Megacyte_Units.Text)
        End If
    End Sub
    Private Sub Calc_Morphite_ISK()
        If (Morphite_IPU.Text.Trim().Length = 0 Or Morphite_Units.Text.Trim().Length = 0) Then
            Morphite_Total.Text = "0"
        Else
            Morphite_Total.Text = Convert.ToDecimal(Morphite_IPU.Text) * Convert.ToDecimal(Morphite_Units.Text)
        End If
    End Sub
    Private Sub Calc_White_Glaze_ISK()
        If (White_Glaze_IPU.Text.Trim().Length = 0 Or White_Glaze_Units.Text.Trim().Length = 0) Then
            White_Glaze_Total.Text = "0"
        Else
            White_Glaze_Total.Text = Convert.ToDecimal(White_Glaze_IPU.Text) * Convert.ToDecimal(White_Glaze_Units.Text)
        End If
    End Sub
    Private Sub Calc_Pristine_White_Glaze_ISK()
        If (Pristine_White_Glaze_IPU.Text.Trim().Length = 0 Or Pristine_White_Glaze_Units.Text.Trim().Length = 0) Then
            Pristine_White_Glaze_Total.Text = "0"
        Else
            Pristine_White_Glaze_Total.Text = Convert.ToDecimal(Pristine_White_Glaze_IPU.Text) * Convert.ToDecimal(Pristine_White_Glaze_Units.Text)
        End If
    End Sub
    Private Sub Calc_Glacial_Mass_ISK()
        If (Glacial_Mass_IPU.Text.Trim().Length = 0 Or Glacial_Mass_Units.Text.Trim().Length = 0) Then
            Glacial_Mass_Total.Text = "0"
        Else
            Glacial_Mass_Total.Text = Convert.ToDecimal(Glacial_Mass_IPU.Text) * Convert.ToDecimal(Glacial_Mass_Units.Text)
        End If
    End Sub
    Private Sub Calc_Smooth_Glacial_Mass_ISK()
        If (Smooth_Glacial_Mass_IPU.Text.Trim().Length = 0 Or Smooth_Glacial_Mass_Units.Text.Trim().Length = 0) Then
            Smooth_Glacial_Mass_Total.Text = "0"
        Else
            Smooth_Glacial_Mass_Total.Text = Convert.ToDecimal(Smooth_Glacial_Mass_IPU.Text) * Convert.ToDecimal(Smooth_Glacial_Mass_Units.Text)
        End If
    End Sub
    Private Sub Calc_Blue_Ice_ISK()
        If (Blue_Ice_IPU.Text.Trim().Length = 0 Or Blue_Ice_Units.Text.Trim().Length = 0) Then
            Blue_Ice_Total.Text = "0"
        Else
            Blue_Ice_Total.Text = Convert.ToDecimal(Blue_Ice_IPU.Text) * Convert.ToDecimal(Blue_Ice_Units.Text)
        End If
    End Sub
    Private Sub Calc_Thick_Blue_Ice_ISK()
        If (Thick_Blue_Ice_IPU.Text.Trim().Length = 0 Or Thick_Blue_Ice_Units.Text.Trim().Length = 0) Then
            Thick_Blue_Ice_Total.Text = "0"
        Else
            Thick_Blue_Ice_Total.Text = Convert.ToDecimal(Thick_Blue_Ice_IPU.Text) * Convert.ToDecimal(Thick_Blue_Ice_Units.Text)
        End If
    End Sub
    Private Sub Calc_Clear_Icicle_ISK()
        If (Clear_Icicle_IPU.Text.Trim().Length = 0 Or Clear_Icicle_Units.Text.Trim().Length = 0) Then
            Clear_Icicle_Total.Text = "0"
        Else
            Clear_Icicle_Total.Text = Convert.ToDecimal(Clear_Icicle_IPU.Text) * Convert.ToDecimal(Clear_Icicle_Units.Text)
        End If
    End Sub
    Private Sub Calc_Enriched_Clear_Icicle_ISK()
        If (Enriched_Clear_Icicle_IPU.Text.Trim().Length = 0 Or Enriched_Clear_Icicle_Units.Text.Trim().Length = 0) Then
            Enriched_Clear_Icicle_Total.Text = "0"
        Else
            Enriched_Clear_Icicle_Total.Text = Convert.ToDecimal(Enriched_Clear_Icicle_IPU.Text) * Convert.ToDecimal(Enriched_Clear_Icicle_Units.Text)
        End If
    End Sub
    Private Sub Calc_Glare_Crust_ISK()
        If (Glare_Crust_IPU.Text.Trim().Length = 0 Or Glare_Crust_Units.Text.Trim().Length = 0) Then
            Glare_Crust_Total.Text = "0"
        Else
            Glare_Crust_Total.Text = Convert.ToDecimal(Glare_Crust_IPU.Text) * Convert.ToDecimal(Glare_Crust_Units.Text)
        End If
    End Sub
    Private Sub Calc_Dark_Glitter_ISK()
        If (Dark_Glitter_IPU.Text.Trim().Length = 0 Or Dark_Glitter_Units.Text.Trim().Length = 0) Then
            Dark_Glitter_Total.Text = "0"
        Else
            Dark_Glitter_Total.Text = Convert.ToDecimal(Dark_Glitter_IPU.Text) * Convert.ToDecimal(Dark_Glitter_Units.Text)
        End If
    End Sub
    Private Sub Calc_Gelidus_ISK()
        If (Gelidus_IPU.Text.Trim().Length = 0 Or Gelidus_Units.Text.Trim().Length = 0) Then
            Gelidus_Total.Text = "0"
        Else
            Gelidus_Total.Text = Convert.ToDecimal(Gelidus_IPU.Text) * Convert.ToDecimal(Gelidus_Units.Text)
        End If
    End Sub
    Private Sub Calc_Krystallos_ISK()
        If (Krystallos_IPU.Text.Trim().Length = 0 Or Krystallos_Units.Text.Trim().Length = 0) Then
            Krystallos_Total.Text = "0"
        Else
            Krystallos_Total.Text = Convert.ToDecimal(Krystallos_IPU.Text) * Convert.ToDecimal(Krystallos_Units.Text)
        End If
    End Sub
    Private Sub Calc_Helium_Isotopes_ISK()
        If (Helium_Isotopes_IPU.Text.Trim().Length = 0 Or Helium_Isotopes_Units.Text.Trim().Length = 0) Then
            Helium_Isotopes_Total.Text = "0"
        Else
            Helium_Isotopes_Total.Text = Convert.ToDecimal(Helium_Isotopes_IPU.Text) * Convert.ToDecimal(Helium_Isotopes_Units.Text)
        End If
    End Sub
    Private Sub Calc_Hydrogen_Isotopes_ISK()
        If (Hydrogen_Isotopes_IPU.Text.Trim().Length = 0 Or Hydrogen_Isotopes_Units.Text.Trim().Length = 0) Then
            Hydrogen_Isotopes_Total.Text = "0"
        Else
            Hydrogen_Isotopes_Total.Text = Convert.ToDecimal(Hydrogen_Isotopes_IPU.Text) * Convert.ToDecimal(Hydrogen_Isotopes_Units.Text)
        End If
    End Sub
    Private Sub Calc_Nitrogen_Isotopes_ISK()
        If (Nitrogen_Isotopes_IPU.Text.Trim().Length = 0 Or Nitrogen_Isotopes_Units.Text.Trim().Length = 0) Then
            Nitrogen_Isotopes_Total.Text = "0"
        Else
            Nitrogen_Isotopes_Total.Text = Convert.ToDecimal(Nitrogen_Isotopes_IPU.Text) * Convert.ToDecimal(Nitrogen_Isotopes_Units.Text)
        End If
    End Sub
    Private Sub Calc_Oxygen_Isotopes_ISK()
        If (Oxygen_Isotopes_IPU.Text.Trim().Length = 0 Or Oxygen_Isotopes_Units.Text.Trim().Length = 0) Then
            Oxygen_Isotopes_Total.Text = "0"
        Else
            Oxygen_Isotopes_Total.Text = Convert.ToDecimal(Oxygen_Isotopes_IPU.Text) * Convert.ToDecimal(Oxygen_Isotopes_Units.Text)
        End If
    End Sub
    Private Sub Calc_Heavy_Water_ISK()
        If (Heavy_Water_IPU.Text.Trim().Length = 0 Or Heavy_Water_Units.Text.Trim().Length = 0) Then
            Heavy_Water_Total.Text = "0"
        Else
            Heavy_Water_Total.Text = Convert.ToDecimal(Heavy_Water_IPU.Text) * Convert.ToDecimal(Heavy_Water_Units.Text)
        End If
    End Sub
    Private Sub Calc_Liquid_Ozone_ISK()
        If (Liquid_Ozone_IPU.Text.Trim().Length = 0 Or Liquid_Ozone_Units.Text.Trim().Length = 0) Then
            Liquid_Ozone_Total.Text = "0"
        Else
            Liquid_Ozone_Total.Text = Convert.ToDecimal(Liquid_Ozone_IPU.Text) * Convert.ToDecimal(Liquid_Ozone_Units.Text)
        End If
    End Sub
    Private Sub Calc_Strontium_Clathrates_ISK()
        If (Strontium_Clathrates_IPU.Text.Trim().Length = 0 Or Strontium_Clathrates_Units.Text.Trim().Length = 0) Then
            Strontium_Clathrates_Total.Text = "0"
        Else
            Strontium_Clathrates_Total.Text = Convert.ToDecimal(Strontium_Clathrates_IPU.Text) * Convert.ToDecimal(Strontium_Clathrates_Units.Text)
        End If
    End Sub

    Private Sub Calc_Total_ISK()
        Total_ISK_Made.Text = Convert.ToDecimal(Veldspar_Total.Text) + Convert.ToDecimal(Concentrated_Veldspar_Total.Text) + Convert.ToDecimal(Dense_Veldspar_Total.Text) +
            Convert.ToDecimal(Scordite_Total.Text) + Convert.ToDecimal(Condensed_Scordite_Total.Text) + Convert.ToDecimal(Massive_Scordite_Total.Text) +
            Convert.ToDecimal(Pyroxeres_Total.Text) + Convert.ToDecimal(Solid_Pyroxeres_Total.Text) + Convert.ToDecimal(Viscous_Pyroxeres_Total.Text) +
            Convert.ToDecimal(Plagioclase_Total.Text) + Convert.ToDecimal(Azure_Plagioclase_Total.Text) + Convert.ToDecimal(Rich_Plagioclase_Total.Text) +
            Convert.ToDecimal(Omber_Total.Text) + Convert.ToDecimal(Silvery_Omber_Total.Text) + Convert.ToDecimal(Golden_Omber_Total.Text) +
            Convert.ToDecimal(Kernite_Total.Text) + Convert.ToDecimal(Luminous_Kernite_Total.Text) + Convert.ToDecimal(Fiery_Kernite_Total.Text) +
            Convert.ToDecimal(Jaspet_Total.Text) + Convert.ToDecimal(Pure_Jaspet_Total.Text) + Convert.ToDecimal(Pristine_Jaspet_Total.Text) +
            Convert.ToDecimal(Hemorphite_Total.Text) + Convert.ToDecimal(Vivid_Hemorphite_Total.Text) + Convert.ToDecimal(Radiant_Hemorphite_Total.Text) +
            Convert.ToDecimal(Hedbergite_Total.Text) + Convert.ToDecimal(Vitric_Hedbergite_Total.Text) + Convert.ToDecimal(Glazed_Hedbergite_Total.Text) +
            Convert.ToDecimal(Gneiss_Total.Text) + Convert.ToDecimal(Iridescent_Gneiss_Total.Text) + Convert.ToDecimal(Prismatic_Gneiss_Total.Text) +
            Convert.ToDecimal(Dark_Ochre_Total.Text) + Convert.ToDecimal(Onyx_Ochre_Total.Text) + Convert.ToDecimal(Obsidian_Ochre_Total.Text) +
            Convert.ToDecimal(Crokite_Total.Text) + Convert.ToDecimal(Sharp_Crokite_Total.Text) + Convert.ToDecimal(Crystalline_Crokite_Total.Text) +
            Convert.ToDecimal(Spodumain_Total.Text) + Convert.ToDecimal(Bright_Spodumain_Total.Text) + Convert.ToDecimal(Gleaming_Spodumain_Total.Text) +
            Convert.ToDecimal(Bistot_Total.Text) + Convert.ToDecimal(Triclinic_Bistot_Total.Text) + Convert.ToDecimal(Monoclinic_Bistot_Total.Text) +
            Convert.ToDecimal(Arkonor_Total.Text) + Convert.ToDecimal(Crimson_Arkonor_Total.Text) + Convert.ToDecimal(Prime_Arkonor_Total.Text) +
            Convert.ToDecimal(Mercoxit_Total.Text) + Convert.ToDecimal(Magma_Mercoxit_Total.Text) + Convert.ToDecimal(Vitreous_Mercoxit_Total.Text) +
            Convert.ToDecimal(Tritanium_Total.Text) + Convert.ToDecimal(Pyerite_Total.Text) + Convert.ToDecimal(Mexallon_Total.Text) +
            Convert.ToDecimal(Isogen_Total.Text) + Convert.ToDecimal(Nocxium_Total.Text) + (Zydrine_Total.Text) + Convert.ToDecimal(Megacyte_Total.Text) +
            Convert.ToDecimal(Morphite_Total.Text) + Convert.ToDecimal(White_Glaze_Total.Text) + Convert.ToDecimal(Pristine_White_Glaze_Total.Text) +
            Convert.ToDecimal(Glacial_Mass_Total.Text) + Convert.ToDecimal(Glacial_Mass_Total.Text) + Convert.ToDecimal(Smooth_Glacial_Mass_Total.Text) +
            Convert.ToDecimal(Blue_Ice_Total.Text) + Convert.ToDecimal(Thick_Blue_Ice_Total.Text) + Convert.ToDecimal(Clear_Icicle_Total.Text) +
            Convert.ToDecimal(Enriched_Clear_Icicle_Total.Text) + Convert.ToDecimal(Glare_Crust_Total.Text) + Convert.ToDecimal(Dark_Glitter_Total.Text) +
            Convert.ToDecimal(Gelidus_Total.Text) + Convert.ToDecimal(Krystallos_Total.Text) + Convert.ToDecimal(Helium_Isotopes_Total.Text) +
            Convert.ToDecimal(Hydrogen_Isotopes_Total.Text) + Convert.ToDecimal(Nitrogen_Isotopes_Total.Text) + Convert.ToDecimal(Oxygen_Isotopes_Total.Text) +
            Convert.ToDecimal(Heavy_Water_Total.Text) + Convert.ToDecimal(Liquid_Ozone_Total.Text) + Convert.ToDecimal(Strontium_Clathrates_Total.Text)
    End Sub

    Private Sub Calc_Total_M3()
        Total_M3_Made.Text =
            Convert.ToDecimal(Veldspar_Total.Text * 0.1) + Convert.ToDecimal(Concentrated_Veldspar_Total.Text * 0.1) + Convert.ToDecimal(Dense_Veldspar_Total.Text * 0.1) +
            Convert.ToDecimal(Scordite_Total.Text * 0.15) + Convert.ToDecimal(Condensed_Scordite_Total.Text * 0.15) + Convert.ToDecimal(Massive_Scordite_Total.Text * 0.15) +
            Convert.ToDecimal(Pyroxeres_Total.Text * 0.3) + Convert.ToDecimal(Solid_Pyroxeres_Total.Text * 0.3) + Convert.ToDecimal(Viscous_Pyroxeres_Total.Text * 0.3) +
            Convert.ToDecimal(Plagioclase_Total.Text * 0.35) + Convert.ToDecimal(Azure_Plagioclase_Total.Text * 0.35) + Convert.ToDecimal(Rich_Plagioclase_Total.Text * 0.35) +
            Convert.ToDecimal(Omber_Total.Text * 0.6) + Convert.ToDecimal(Silvery_Omber_Total.Text * 0.6) + Convert.ToDecimal(Golden_Omber_Total.Text * 0.6) +
            Convert.ToDecimal(Kernite_Total.Text * 1.2) + Convert.ToDecimal(Luminous_Kernite_Total.Text * 1.2) + Convert.ToDecimal(Fiery_Kernite_Total.Text * 1.2) +
            Convert.ToDecimal(Jaspet_Total.Text * 2) + Convert.ToDecimal(Pure_Jaspet_Total.Text * 2) + Convert.ToDecimal(Pristine_Jaspet_Total.Text * 2) +
            Convert.ToDecimal(Hemorphite_Total.Text * 3) + Convert.ToDecimal(Vivid_Hemorphite_Total.Text * 3) + Convert.ToDecimal(Radiant_Hemorphite_Total.Text * 3) +
            Convert.ToDecimal(Hedbergite_Total.Text * 3) + Convert.ToDecimal(Vitric_Hedbergite_Total.Text * 3) + Convert.ToDecimal(Glazed_Hedbergite_Total.Text * 3) +
            Convert.ToDecimal(Gneiss_Total.Text * 5) + Convert.ToDecimal(Iridescent_Gneiss_Total.Text * 5) + Convert.ToDecimal(Prismatic_Gneiss_Total.Text * 5) +
            Convert.ToDecimal(Dark_Ochre_Total.Text * 8) + Convert.ToDecimal(Onyx_Ochre_Total.Text * 8) + Convert.ToDecimal(Obsidian_Ochre_Total.Text * 8) +
            Convert.ToDecimal(Crokite_Total.Text * 16) + Convert.ToDecimal(Sharp_Crokite_Total.Text * 16) + Convert.ToDecimal(Crystalline_Crokite_Total.Text * 16) +
            Convert.ToDecimal(Spodumain_Total.Text * 16) + Convert.ToDecimal(Bright_Spodumain_Total.Text * 16) + Convert.ToDecimal(Gleaming_Spodumain_Total.Text * 16) +
            Convert.ToDecimal(Bistot_Total.Text * 16) + Convert.ToDecimal(Triclinic_Bistot_Total.Text * 16) + Convert.ToDecimal(Monoclinic_Bistot_Total.Text * 16) +
            Convert.ToDecimal(Arkonor_Total.Text * 16) + Convert.ToDecimal(Crimson_Arkonor_Total.Text * 16) + Convert.ToDecimal(Prime_Arkonor_Total.Text * 16) +
            Convert.ToDecimal(Mercoxit_Total.Text * 40) + Convert.ToDecimal(Magma_Mercoxit_Total.Text * 40) + Convert.ToDecimal(Vitreous_Mercoxit_Total.Text * 40) +
            Convert.ToDecimal(Tritanium_Total.Text * 0.01) + Convert.ToDecimal(Pyerite_Total.Text * 0.01) + Convert.ToDecimal(Mexallon_Total.Text * 0.01) +
            Convert.ToDecimal(Isogen_Total.Text * 0.01) + Convert.ToDecimal(Nocxium_Total.Text * 0.01) + (Zydrine_Total.Text * 0.01) + Convert.ToDecimal(Megacyte_Total.Text * 0.01) +
            Convert.ToDecimal(Morphite_Total.Text * 0.01) + Convert.ToDecimal(White_Glaze_Total.Text * 1000) + Convert.ToDecimal(Pristine_White_Glaze_Total.Text * 1000) +
            Convert.ToDecimal(Glacial_Mass_Total.Text * 1000) + Convert.ToDecimal(Glacial_Mass_Total.Text * 1000) + Convert.ToDecimal(Smooth_Glacial_Mass_Total.Text * 1000) +
            Convert.ToDecimal(Blue_Ice_Total.Text * 1000) + Convert.ToDecimal(Thick_Blue_Ice_Total.Text * 1000) + Convert.ToDecimal(Clear_Icicle_Total.Text * 1000) +
            Convert.ToDecimal(Enriched_Clear_Icicle_Total.Text * 1000) + Convert.ToDecimal(Glare_Crust_Total.Text * 1000) + Convert.ToDecimal(Dark_Glitter_Total.Text * 1000) +
            Convert.ToDecimal(Gelidus_Total.Text * 1000) + Convert.ToDecimal(Krystallos_Total.Text * 1000) + Convert.ToDecimal(Helium_Isotopes_Total.Text * 0.1) +
            Convert.ToDecimal(Hydrogen_Isotopes_Total.Text * 0.1) + Convert.ToDecimal(Nitrogen_Isotopes_Total.Text * 0.1) + Convert.ToDecimal(Oxygen_Isotopes_Total.Text * 0.1) +
            Convert.ToDecimal(Heavy_Water_Total.Text * 0.4) + Convert.ToDecimal(Liquid_Ozone_Total.Text * 0.4) + Convert.ToDecimal(Strontium_Clathrates_Total.Text * 3)

    End Sub

    Private Sub Calc_Clear_All()
        Veldspar_Units.Text = "0"
        Concentrated_Veldspar_Units.Text = "0"
        Dense_Veldspar_Units.Text = "0"
        Scordite_Units.Text = "0"
        Condensed_Scordite_Units.Text = "0"
        Massive_Scordite_Units.Text = "0"
        Pyroxeres_Units.Text = "0"
        Solid_Pyroxeres_Units.Text = "0"
        Viscous_Pyroxeres_Units.Text = "0"
        Plagioclase_Units.Text = "0"
        Azure_Plagioclase_Units.Text = "0"
        Rich_Plagioclase_Units.Text = "0"
        Omber_Units.Text = "0"
        Silvery_Omber_Units.Text = "0"
        Golden_Omber_Units.Text = "0"
        Kernite_Units.Text = "0"
        Luminous_Kernite_Units.Text = "0"
        Fiery_Kernite_Units.Text = "0"
        Jaspet_Units.Text = "0"
        Pure_Jaspet_Units.Text = "0"
        Pristine_Jaspet_Units.Text = "0"
        Hemorphite_Units.Text = "0"
        Vivid_Hemorphite_Units.Text = "0"
        Radiant_Hemorphite_Units.Text = "0"
        Hedbergite_Units.Text = "0"
        Vitric_Hedbergite_Units.Text = "0"
        Glazed_Hedbergite_Units.Text = "0"
        Gneiss_Units.Text = "0"
        Iridescent_Gneiss_Units.Text = "0"
        Prismatic_Gneiss_Units.Text = "0"
        Dark_Ochre_Units.Text = "0"
        Onyx_Ochre_Units.Text = "0"
        Obsidian_Ochre_Units.Text = "0"
        Crokite_Units.Text = "0"
        Sharp_Crokite_Units.Text = "0"
        Crystalline_Crokite_Units.Text = "0"
        Spodumain_Units.Text = "0"
        Bright_Spodumain_Units.Text = "0"
        Gleaming_Spodumain_Units.Text = "0"
        Bistot_Units.Text = "0"
        Triclinic_Bistot_Units.Text = "0"
        Monoclinic_Bistot_Units.Text = "0"
        Arkonor_Units.Text = "0"
        Crimson_Arkonor_Units.Text = "0"
        Prime_Arkonor_Units.Text = "0"
        Mercoxit_Units.Text = "0"
        Magma_Mercoxit_Units.Text = "0"
        Vitreous_Mercoxit_Units.Text = "0"
        Tritanium_Units.Text = "0"
        Pyerite_Units.Text = "0"
        Mexallon_Units.Text = "0"
        Isogen_Units.Text = "0"
        Nocxium_Units.Text = "0"
        Zydrine_Units.Text = "0"
        Megacyte_Units.Text = "0"
        Morphite_Units.Text = "0"
        White_Glaze_Units.Text = "0"
        Pristine_White_Glaze_Units.Text = "0"
        Glacial_Mass_Units.Text = "0"
        Smooth_Glacial_Mass_Units.Text = "0"
        Blue_Ice_Units.Text = "0"
        Thick_Blue_Ice_Units.Text = "0"
        Clear_Icicle_Units.Text = "0"
        Enriched_Clear_Icicle_Units.Text = "0"
        Glare_Crust_Units.Text = "0"
        Dark_Glitter_Units.Text = "0"
        Gelidus_Units.Text = "0"
        Krystallos_Units.Text = "0"
        Helium_Isotopes_Units.Text = "0"
        Hydrogen_Isotopes_Units.Text = "0"
        Nitrogen_Isotopes_Units.Text = "0"
        Oxygen_Isotopes_Units.Text = "0"
        Heavy_Water_Units.Text = "0"
        Liquid_Ozone_Units.Text = "0"
        Strontium_Clathrates_Units.Text = "0"
    End Sub

    Private Sub Clear_All_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_All_Button.Click
        Calc_Clear_All()
        Calc_Veldspar_ISK()
        Calc_Concentrated_Veldspar_ISK()
        Calc_Dense_Veldspar_ISK()
        Calc_Scordite_ISK()
        Calc_Condensed_Scordite_ISK()
        Calc_Massive_Scordite_ISK()
        Calc_Pyroxeres_ISK()
        Calc_Solid_Pyroxeres_ISK()
        Calc_Viscous_Pyroxeres_ISK()
        Calc_Plagioclase_ISK()
        Calc_Azure_Plagioclase_ISK()
        Calc_Rich_Plagioclase_ISK()
        Calc_Omber_ISK()
        Calc_Silvery_Omber_ISK()
        Calc_Golden_Omber_ISK()
        Calc_Kernite_ISK()
        Calc_Luminous_Kernite_ISK()
        Calc_Fiery_Kernite_ISK()
        Calc_Jaspet_ISK()
        Calc_Pure_Jaspet_ISK()
        Calc_Pristine_Jaspet_ISK()
        Calc_Hemorphite_ISK()
        Calc_Vivid_Hemorphite_ISK()
        Calc_Radiant_Hemorphite_ISK()
        Calc_Hedbergite_ISK()
        Calc_Vitric_Hedbergite_ISK()
        Calc_Glazed_Hedbergite_ISK()
        Calc_Gneiss_ISK()
        Calc_Iridescent_Gneiss_ISK()
        Calc_Prismatic_Gneiss_ISK()
        Calc_Dark_Ochre_ISK()
        Calc_Onyx_Ochre_ISK()
        Calc_Obsidian_Ochre_ISK()
        Calc_Crokite_ISK()
        Calc_Sharp_Crokite_ISK()
        Calc_Crystalline_Crokite_ISK()
        Calc_Spodumain_ISK()
        Calc_Bright_Spodumain_ISK()
        Calc_Gleaming_Spodumain_ISK()
        Calc_Bistot_ISK()
        Calc_Triclinic_Bistot_ISK()
        Calc_Monoclinic_Bistot_ISK()
        Calc_Arkonor_ISK()
        Calc_Crimson_Arkonor_ISK()
        Calc_Prime_Arkonor_ISK()
        Calc_Mercoxit_ISK()
        Calc_Magma_Mercoxit_ISK()
        Calc_Vitreous_Mercoxit_ISK()
        Calc_Tritanium_ISK()
        Calc_Pyerite_ISK()
        Calc_Mexallon_ISK()
        Calc_Isogen_ISK()
        Calc_Nocxium_ISK()
        Calc_Zydrine_ISK()
        Calc_Megacyte_ISK()
        Calc_Morphite_ISK()
        Calc_White_Glaze_ISK()
        Calc_Pristine_White_Glaze_ISK()
        Calc_Glacial_Mass_ISK()
        Calc_Smooth_Glacial_Mass_ISK()
        Calc_Blue_Ice_ISK()
        Calc_Thick_Blue_Ice_ISK()
        Calc_Clear_Icicle_ISK()
        Calc_Enriched_Clear_Icicle_ISK()
        Calc_Glare_Crust_ISK()
        Calc_Dark_Glitter_ISK()
        Calc_Gelidus_ISK()
        Calc_Krystallos_ISK()
        Calc_Helium_Isotopes_ISK()
        Calc_Hydrogen_Isotopes_ISK()
        Calc_Nitrogen_Isotopes_ISK()
        Calc_Oxygen_Isotopes_ISK()
        Calc_Heavy_Water_ISK()
        Calc_Liquid_Ozone_ISK()
        Calc_Strontium_Clathrates_ISK()
        Calc_Total_ISK()
        Calc_Total_M3()
    End Sub

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mysqlconn = New MySqlConnection()
        Mysqlconn.ConnectionString = "server=yhi.is-a-guru.com;Uid=YHI;Pwd=miningore;database=YHI"

        Try

            Mysqlconn.Open()
            cmd = New MySqlCommand()
            cmd.Connection = Mysqlconn

            Dim sqlStripCmd As New MySqlCommand("ore_price_population", Mysqlconn)
            sqlStripCmd.CommandType = CommandType.StoredProcedure

            Dim getDetailsDA = New MySqlDataAdapter
            Dim getDetailsDS As New DataSet

            getDetailsDA.SelectCommand = sqlStripCmd
            getDetailsDA.Fill(getDetailsDS, "getDetails")
            Veldspar_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Veldspar").ToString
            Concentrated_Veldspar_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Concentrated_Veldspar").ToString
            Dense_Veldspar_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Dense_Veldspar").ToString
            Scordite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Scordite").ToString
            Condensed_Scordite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Condensed_Scordite").ToString
            Massive_Scordite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Massive_Scordite").ToString
            Pyroxeres_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Pyroxeres").ToString
            Solid_Pyroxeres_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Solid_Pyroxeres").ToString
            Viscous_Pyroxeres_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Viscous_Pyroxeres").ToString
            Plagioclase_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Plagioclase").ToString
            Azure_Plagioclase_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Azure_Plagioclase").ToString
            Rich_Plagioclase_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Rich_Plagioclase").ToString
            Omber_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Omber").ToString
            Silvery_Omber_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Silvery_Omber").ToString
            Golden_Omber_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Golden_Omber").ToString
            Kernite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Kernite").ToString
            Luminous_Kernite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Luminous_Kernite").ToString
            Fiery_Kernite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Fiery_Kernite").ToString
            Jaspet_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Jaspet").ToString
            Pure_Jaspet_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Pure_Jaspet").ToString
            Pristine_Jaspet_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Pristine_Jaspet").ToString
            Hemorphite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Hemorphite").ToString
            Vivid_Hemorphite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Vivid_Hemorphite").ToString
            Radiant_Hemorphite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Radiant_Hemorphite").ToString
            Hedbergite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Hedbergite").ToString
            Vitric_Hedbergite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Vitric_Hedbergite").ToString
            Glazed_Hedbergite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Glazed_Hedbergite").ToString
            Gneiss_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Gneiss").ToString
            Iridescent_Gneiss_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Iridescent_Gneiss").ToString
            Prismatic_Gneiss_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Prismatic_Gneiss").ToString
            Dark_Ochre_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Dark_Ochre").ToString
            Onyx_Ochre_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Onyx_Ochre").ToString
            Obsidian_Ochre_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Obsidian_Ochre").ToString
            Crokite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Crokite").ToString
            Sharp_Crokite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Sharp_Crokite").ToString
            Crystalline_Crokite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Crystalline_Crokite").ToString
            Spodumain_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Spodumain").ToString
            Bright_Spodumain_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Bright_Spodumain").ToString
            Gleaming_Spodumain_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Gleaming_Spodumain").ToString
            Bistot_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Bistot").ToString
            Triclinic_Bistot_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Triclinic_Bistot").ToString
            Monoclinic_Bistot_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Monoclinic_Bistot").ToString
            Arkonor_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Arkonor").ToString
            Crimson_Arkonor_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Crimson_Arkonor").ToString
            Prime_Arkonor_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Prime_Arkonor").ToString
            Mercoxit_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Mercoxit").ToString
            Magma_Mercoxit_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Magma_Mercoxit").ToString
            Vitreous_Mercoxit_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Vitreous_Mercoxit").ToString
            White_Glaze_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("White_Glaze").ToString
            Pristine_White_Glaze_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Pristine_White_Glaze").ToString
            Glacial_Mass_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Glacial_Mass").ToString
            Smooth_Glacial_Mass_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Smooth_Glacial_Mass").ToString
            Blue_Ice_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Blue_Ice").ToString
            Thick_Blue_Ice_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Thick_Blue_Ice").ToString
            Clear_Icicle_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Clear_Icicle").ToString
            Enriched_Clear_Icicle_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Enriched_Clear_Icicle").ToString
            Glare_Crust_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Glare_Crust").ToString
            Dark_Glitter_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Dark_Glitter").ToString
            Gelidus_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Gelidus").ToString
            Krystallos_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Krystallos").ToString
            Tritanium_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Tritanium").ToString
            Pyerite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Pyerite").ToString
            Mexallon_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Mexallon").ToString
            Isogen_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Isogen").ToString
            Nocxium_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Nocxium").ToString
            Zydrine_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Zydrine").ToString
            Megacyte_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Megacyte").ToString
            Morphite_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Morphite").ToString
            Heavy_Water_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Heavy_Water").ToString
            Helium_Isotopes_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Helium_Isotopes").ToString
            Hydrogen_Isotopes_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Hydrogen_Isotopes").ToString
            Liquid_Ozone_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Liquid_Ozone").ToString
            Nitrogen_Isotopes_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Nitrogen_Isotopes").ToString
            Oxygen_Isotopes_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Oxygen_Isotopes").ToString
            Strontium_Clathrates_IPU.Text = getDetailsDS.Tables(0).Rows(0).Item("Strontium_Clathrates").ToString

        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

End Class