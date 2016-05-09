Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.DocumentFormat.RDF
Imports Microsoft.VisualBasic.Serialization

Namespace MetaCyc.Biopax.Level3.Elements

    <XmlType("owl_Ontology")>
    Public Class owlOntology
        <XmlNamespaceDeclarations> Public Property rdfAbout As String
        <XmlNamespaceDeclarations> Public Property rdfsComment As String

        <XmlElement> Public Property owlImports As owlImports

    End Class

    ''' <summary>
    ''' owl:imports
    ''' </summary>
    <XmlType("imports")> Public Class owlImports : Inherits EntityProperty

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace