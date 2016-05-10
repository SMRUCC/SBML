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

Public Class CellularLocationVocabulary : Inherits RDFEntity
    Public Property term As term
    <XmlElement> Public Property xref As xref()
End Class


Public Class SmallMoleculeReference : Inherits RDFEntity
    <XmlElement> Public Property name As name()
    <XmlElement> Public Property xref As xref()
End Class
Public Class UnificationXref : Inherits RDFEntity
    Public Property db As db
    Public Property id As id
    Public Property comment As comment
    Public Property idVersion As idVersion
End Class
Public Class Provenance : Inherits RDFEntity
    Public Property name As name
    Public Property comment As comment
End Class


Public Class Complex : Inherits RDFEntity
    Public Property displayName As displayName
    Public Property cellularLocation As cellularLocation
    Public Property componentStoichiometry As componentStoichiometry
    <XmlElement> Public Property component As comment()
    <XmlElement> Public Property xref As xref()
    Public Property dataSource As dataSource
End Class