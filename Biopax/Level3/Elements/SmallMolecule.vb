Imports System.Xml.Serialization
Imports Biopax.EntityProperties
Imports Microsoft.VisualBasic.DocumentFormat.RDF

<XmlType("SmallMolecule")>
Public Class SmallMolecule : Inherits RDFEntity

    Public Property displayName As displayName

    <XmlElement("name")> Public Property names As name()
    Public Property cellularLocation As cellularLocation
    Public Property entityReference As entityReference
    Public Property comment As comment
    <XmlElement("xref")> Public Property xrefs As xref()
    Public Property dataSource As dataSource

End Class
