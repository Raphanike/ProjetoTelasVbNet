Imports System.Data.SqlClient

Public Class Tab012ADocumentosDB
    Inherits AcessarBanco20  ' sua classe base para conexão


    Public Sub Gravar(ByVal CodigoCliente As Integer,
                  ByVal TipoDocumento As Byte,   ' Alterado de String para Byte
                  ByVal NomeDocumento As String,
                  ByVal Documento As Byte(),
                  ByVal Usuario As String,
                  ByVal DataInclusao As Date)

        Dim COMANDO As String = "INSERT INTO TAB012A_Documentos " &
                            "VALUES (@CodigoCliente, @TipoDocumento, @NomeDocumento, @Documento, @Usuario, @DataInclusao)"

        Cmd = New SqlCommand(COMANDO, Cnx)
        Cmd.CommandType = CommandType.Text
        Cmd.CommandTimeout = Me.TempoDoTimeOut

        Cmd.Parameters.Add("@CodigoCliente", SqlDbType.Int).Value = CodigoCliente
        Cmd.Parameters.Add("@TipoDocumento", SqlDbType.TinyInt).Value = TipoDocumento
        Cmd.Parameters.Add("@NomeDocumento", SqlDbType.VarChar, 100).Value = NomeDocumento
        Cmd.Parameters.Add("@Documento", SqlDbType.VarBinary).Value = If(Documento IsNot Nothing, Documento, DBNull.Value)
        Cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30).Value = Usuario
        Cmd.Parameters.Add("@DataInclusao", SqlDbType.SmallDateTime).Value = DataInclusao


        Try
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
        Catch ex As Exception
            Me.TratamentoDeMensagem(ex, "Tab012ADocumentosDB", "Gravar")
        End Try
    End Sub


    Public Sub Excluir(ByVal CodigoCliente As Integer, ByVal NomeDocumento As String)
        Dim COMANDO As String = "DELETE FROM TAB012A_Documentos " &
                                "WHERE CodigoCliente = @CodigoCliente AND NomeDocumento = @NomeDocumento"

        Cmd = New SqlCommand(COMANDO, Cnx)
        Cmd.CommandType = CommandType.Text
        Cmd.CommandTimeout = Me.TempoDoTimeOut

        Cmd.Parameters.Add("@CodigoCliente", SqlDbType.Int).Value = CodigoCliente
        Cmd.Parameters.Add("@NomeDocumento", SqlDbType.VarChar, 100).Value = NomeDocumento

        Try
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
        Catch ex As Exception
            Me.TratamentoDeMensagem(ex, "Tab012ADocumentosDB", "Excluir")
        End Try
    End Sub


    Public Function Retornar(Optional ByVal CodigoCliente As Integer = 0) As DataTable
        Dim dt As New DataTable()
        Dim COMANDO As String = "SELECT CodigoCliente, TipoDocumento, NomeDocumento, Documento, Usuario, DataInclusao " &
                                "FROM TAB012A_Documentos"

        If CodigoCliente > 0 Then
            COMANDO &= " WHERE CodigoCliente = @CodigoCliente"
        End If

        Cmd = New SqlCommand(COMANDO, Cnx)
        Cmd.CommandType = CommandType.Text
        Cmd.CommandTimeout = Me.TempoDoTimeOut

        If CodigoCliente > 0 Then
            Cmd.Parameters.Add("@CodigoCliente", SqlDbType.Int).Value = CodigoCliente
        End If

        Try
            Dim da As New SqlDataAdapter(Cmd)
            da.Fill(dt)
        Catch ex As Exception
            Me.TratamentoDeMensagem(ex, "Tab012ADocumentosDB", "Retornar")
        End Try

        Return dt
    End Function

End Class
