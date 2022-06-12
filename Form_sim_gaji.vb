Public Class Formsimgaji

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Formsimgaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim gaji, makan, lembur, alpa, jamker As Double

        jamker = (Me.Jk.Text * 15000)
        lembur = (Me.Jl.Text * 10000)
        alpa = (Me.Th.Text * 100000)

        gaji = (jamker + lembur - alpa)
        makan = Me.Jk.Text * 10000

        Me.Tg.Text = gaji
        Me.Um.Text = makan
    End Sub
End Class
