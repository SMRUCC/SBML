Imports System.Text
Imports System.Xml.Serialization
Imports Biopax.MetaCyc.Biopax.Level3.Elements
Imports Microsoft.VisualBasic.DocumentFormat.RDF.DocumentElements

Namespace MetaCyc.Biopax.Level3

    ''' <summary>
    ''' Biopax RDF xml file.
    ''' &lt;rdf:RDF xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" xmlns:bp="http://www.biopax.org/release/biopax-level3.owl#" xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" xmlns:owl="http://www.w3.org/2002/07/owl#" xmlns:xsd="http://www.w3.org/2001/XMLSchema#" xml:base="http://www.reactome.org/biopax/56/159879#">
    ''' </summary>
    Public Class File : Inherits RDF

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