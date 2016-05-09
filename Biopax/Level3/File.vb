Imports System.Text
Imports System.Xml.Serialization
Imports Biopax.MetaCyc.Biopax.Level3.Elements

Namespace MetaCyc.Biopax.Level3

    ''' <summary>
    ''' Biopax RDF xml file.
    ''' </summary>
    Public Class File

        Public Property Owl As owlOntology
        <XmlElement("SmallMolecule")> Public Property SmallMolecules As SmallMolecule()

        Public Shared Function LoadDoc(path As String) As File
            Return path.LoadXml(Of File)(preprocess:=AddressOf __cleanXML)
        End Function

        Private Shared Function __cleanXML(doc As String) As String
            Dim sb As New StringBuilder(doc)

            Call sb.Replace("<bp:", "<")
            Call sb.Replace("<owl:", "<")
            Call sb.Replace("</bp:", "</")
            Call sb.Replace("</owl:", "</")

            Return sb.ToString
        End Function
    End Class
End Namespace