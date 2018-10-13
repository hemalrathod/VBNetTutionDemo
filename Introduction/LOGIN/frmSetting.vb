Imports Introduction.DS
Imports Introduction.DSTableAdapters

Public Class frmSetting
    Dim _uname As String = String.Empty
    Dim _USERTYPE As Integer = 0
    Dim udt As USERSDataTable
    Dim ur As USERSRow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(uname As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _uname = uname
    End Sub
    Public Sub New(USERTYPE As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _USERTYPE = USERTYPE
    End Sub
    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _uname <> "" Then
            GetData(_uname)
        Else
            If _USERTYPE = 0 Then
                GetData(JUNCTION.USERNAME)
            Else
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uda As New USERSTableAdapter
        Try
            If _uname <> "" Or _USERTYPE = 0 Then
                ur.FIRSTNAME = Me.TextBox1.Text
                ur.LASTNAME = Me.TextBox2.Text
                ur.EMAIL = Me.TextBox3.Text
                ur.MOBILE = Me.TextBox4.Text
                ur.BIRTHDATE = CDate(Me.MaskedTextBox1.Text)
                ur.PASSWORD = Me.TextBox7.Text
                uda.Update(udt)
            Else
                If _USERTYPE = 1 Then
                    uda.Insert(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text, Me.TextBox4.Text, CDate(Me.MaskedTextBox1.Text), Me.TextBox6.Text, Me.TextBox7.Text)
                End If
            End If

            MsgBox("User saved")
            frmGrid.RefreshGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetData(arg As String)
        Dim uda As New USERSTableAdapter
        udt = uda.GetDataBy(arg)
        ur = udt.Item(0)
        Me.TextBox1.Text = ur.FIRSTNAME
        Me.TextBox2.Text = ur.LASTNAME
        Me.TextBox3.Text = ur.EMAIL
        Me.TextBox4.Text = ur.MOBILE
        Me.MaskedTextBox1.Text = ur.BIRTHDATE
        Me.TextBox6.Text = ur.USERNAME
        Me.TextBox7.Text = ur.PASSWORD
        Me.TextBox6.ReadOnly = True
    End Sub
End Class