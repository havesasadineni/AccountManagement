﻿Public Class Warnings
    Shadows Sub Show()

        CheckBox1.Checked = Not cfgBool("HideWarningTime")
        CheckBox2.Checked = Not cfgBool("HideWarningCantchgpasswd")
        CheckBox3.Checked = Not cfgBool("HideDisabledFlagInfo")
        CheckBox4.Checked = Not cfgBool("HideUserWithNoGroupWarning")
        CheckBox5.Checked = Not cfgBool("SuppressExitWarning")

        ShowDialog()

        If DialogResult = Windows.Forms.DialogResult.OK Then
            If Config.SetVal("HideWarningTime", Convert.ToInt32(Not CheckBox1.Checked), Handle) = False Then Return
            If Config.SetVal("HideWarningCantchgpasswd", Convert.ToInt32(Not CheckBox2.Checked), Handle) = False Then Return
            If Config.SetVal("HideDisabledFlagInfo", Convert.ToInt32(Not CheckBox3.Checked), Handle) = False Then Return
            If Config.SetVal("HideUserWithNoGroupWarning", Convert.ToInt32(Not CheckBox4.Checked), Handle) = False Then Return
            If Config.SetVal("SuppressExitWarning", Convert.ToInt32(Not CheckBox5.Checked), Handle) = False Then Return
        End If
        Dispose()
    End Sub
End Class