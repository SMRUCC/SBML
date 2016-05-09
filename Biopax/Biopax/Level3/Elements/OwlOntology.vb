Imports System.Xml.Serialization

Namespace MetaCyc.Biopax.Level3.Elements

    <XmlType("owl:Ontology")>
    Public Class owlOntology
        <XmlNamespaceDeclarations> Public Property rdfAbout As String
        <XmlNamespaceDeclarations> Public Property rdfsComment As String

        <XmlElement> Public Property owlImports As owlImportsF

        <XmlType("owl:imports")>
        Public Structure owlImportsF
            <XmlNamespaceDeclarations> Dim rdfResource As String
        End Structure
    End Class
End Namespace