Public Class AirConNotify
    Const TEST As Integer = 0
    Const DAYSTART As Integer = 6
#Region "UI関連"

    ' テストボタン
    Private Sub TestBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TestBtn.LinkClicked
        ExeNotify(TEST)
    End Sub

    ' リセットボタン
    Private Sub ResetBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ResetBtn.LinkClicked
        Reset()
    End Sub

    ' 謝辞ボタン
    Private Sub ThanksBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ThanksBtn.LinkClicked
        MsgBox("プログラムアイコン: http://icon-rainbow.com 様")
    End Sub

    ' 終了ボタン
    Private Sub ExitBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ExitBtn.LinkClicked
        Me.Close()
    End Sub

    ' 一時停止ボタン
    Private Sub NotifyTgb_CheckedChanged(sender As Object, e As EventArgs) Handles NotifyTgb.CheckedChanged
        If NotifyTgb.Checked = True Then
            NotifyTgb.Text = "通知を一時停止"
        Else
            Dim Res As MsgBoxResult = MsgBox("次の " + CType(DAYSTART, String) + " 時まで通知を無効にしますか?", vbYesNo)
            If Res = vbNo Then
                NotifyTgb.Checked = True
                Exit Sub
            End If
            NotifyTgb.Text = "通知を有効にする"
        End If
    End Sub

    ' 最小化ボタン
    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        Me.ShowInTaskbar = False
        Me.Visible = False
    End Sub

    ' タスクトレイアイコン関連
    Private Sub TaskTrayNi_DoubleClick(sender As Object, e As EventArgs) Handles TaskTrayNi.DoubleClick
        Me.ShowInTaskbar = True
        Me.Visible = True
    End Sub

#End Region

#Region "プログラム"

    ' 時刻の監視
    Private Sub TimeKeeperTm_Tick(sender As Object, e As EventArgs) Handles TimeKeeperTm.Tick
        Dim dtNow As DateTime = DateTime.Now
        Dim iHour As Integer = dtNow.Hour
        Dim iMinute As Integer = dtNow.Minute

        ' 通知が有効で、設定した時間の設定した分だったら通知を実行
        If NotifyTgb.Checked And
            iMinute = MinuteNud.Value And CheckState(iHour) Then
            ExeNotify(iHour)
        End If

        ' 通知が無効で、1日の始まりの時刻だったら通知を再有効化
        If NotifyTgb.Checked = False And
                iMinute = MinuteNud.Value And CheckState(DAYSTART) Then
            NotifyTgb.Checked = True
        End If
    End Sub

    ' 通知を実行する
    Private Sub ExeNotify(t As Integer)
        TaskTrayNi.ShowBalloonTip(10)
    End Sub

    ' 指定した時刻にチェックが入っているか調べる
    Private Function CheckState(t As Integer)
        For Each item As Control In TimeGBox.Controls
            If CType(CType(item, CheckBox).Name.Substring(1, 2), Integer) = t Then Return True
        Next
        Return False
    End Function

    ' 初期設定にリセットする
    Private Sub Reset()
        Dim Res As MsgBoxResult = MsgBox("リセットしますか?", vbYesNo)
        If Res = vbNo Then Exit Sub

        For Each item As Control In TimeGBox.Controls
            If item.GetType() = GetType(CheckBox) Then
                CType(item, CheckBox).Checked = False
            End If
        Next

        H00Cb.Checked = True
        H02Cb.Checked = True
        H04Cb.Checked = True
        H06Cb.Checked = True
        H21Cb.Checked = True
        H22Cb.Checked = True
        H23Cb.Checked = True
    End Sub

#End Region
End Class
