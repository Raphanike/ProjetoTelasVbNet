Imports System.Linq
Imports System.Runtime.InteropServices
Imports LDN_DADOS20
Imports LDN_REGRAS.Modelos
Imports Microsoft.Win32.SafeHandles

Public Class Tab012ADocumentosRegra


    Private db As New Tab012ADocumentosDB

    Public Property CodigoCliente As Integer
    Public Property TipoDocumento As Modelos.TipoDeDocumnento
    Public Property NomeDocumento As String
    Public Property Documento As Byte()
    Public Property Usuario As String
    Public Property DataInclusao As Date

    Public Sub Gravar(ByVal CodigoCliente As Integer,
                      ByVal TipoDocumento As Modelos.TipoDeDocumnento,
                      ByVal NomeDocumento As String,
                      ByVal Documento As Byte(),
                      ByVal Usuario As String,
                      ByVal DataInclusao As Date)
        db.Gravar(CodigoCliente, CType(TipoDocumento, Byte), NomeDocumento, Documento, Usuario, DataInclusao)
    End Sub

    Public Sub Deletar(ByVal CodigoCliente As Integer, ByVal NomeDocumento As String)
        db.Excluir(CodigoCliente, NomeDocumento)
    End Sub

    Public Sub selecionarUm(CodigoCliente As Integer, NomeDocumento As String)
        Dim DT As DataTable = db.Retornar(CodigoCliente)

        If DT.Rows.Count > 0 Then
            Dim dr As DataRow = DT.Rows(0)
            Me.CodigoCliente = CInt(dr("CodigoCliente"))
            Me.TipoDocumento = CType(CByte(dr("TipoDocumento")), Modelos.TipoDeDocumnento)
            Me.NomeDocumento = dr("NomeDocumento").ToString()
            Me.Documento = If(IsDBNull(dr("Documento")), Nothing, CType(dr("Documento"), Byte()))
            Me.Usuario = dr("Usuario").ToString()
            Me.DataInclusao = CDate(dr("DataInclusao"))
        End If
    End Sub

    Public Function selecionarTodos() As List(Of Tab012ADocumentosRegra)
        Dim lista As New List(Of Tab012ADocumentosRegra)()
        Dim dt As DataTable = db.Retornar()  ' Sem parâmetro, retorna todos os registros

        For Each dr As DataRow In dt.Rows
            Dim doc As New Tab012ADocumentosRegra() With {
            .CodigoCliente = dr.Field(Of Integer)("CodigoCliente"),
            .TipoDocumento = CType(dr.Field(Of Byte)("TipoDocumento"), Modelos.TipoDeDocumnento),
            .NomeDocumento = dr.Field(Of String)("NomeDocumento"),
            .Documento = If(dr.IsNull("Documento"), Nothing, dr.Field(Of Byte())("Documento")),
            .Usuario = dr.Field(Of String)("Usuario"),
            .DataInclusao = dr.Field(Of Date)("DataInclusao")
        }

            lista.Add(doc)
        Next

        Return lista
    End Function


End Class
