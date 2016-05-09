Imports System.Text

Namespace MetaCyc.Biopax.Level3

    Public Class File

        Public Owl As MetaCyc.Biopax.Level3.Elements.owlOntology

        Dim Path As String

        Public Overrides Function ToString() As String
            Return Path
        End Function

        Public Shared Function Read(Path As String) As MetaCyc.Biopax.Level3.File
            Dim File As StringBuilder = New StringBuilder(FileIO.FileSystem.ReadAllText(Path))
            Dim Xml As File
            Call File.Replace("xmlns", "XMLNS")
            Xml = File.ToString.CreateObjectFromXml(Of MetaCyc.Biopax.Level3.File)()
            Xml.Path = Path
            Return Xml
        End Function
    End Class
End Namespace