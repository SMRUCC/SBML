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


Public Class BiochemicalReaction : Inherits RDFEntity
    Public Property conversionDirection As conversionDirection
    <XmlElement> Public Property left As left()
    <XmlElement> Public Property right As right()
    Public Property eCNumber As eCNumber
    Public Property displayName As displayName
    <XmlElement> Public Property xref As xref()
    Public Property comment As comment
    Public Property dataSource As dataSource
End Class