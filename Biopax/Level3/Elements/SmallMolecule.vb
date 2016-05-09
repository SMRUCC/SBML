Imports System.Xml.Serialization
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

Public Class displayName : Inherits EntityProperty

End Class
Public Class name : Inherits EntityProperty

End Class
Public Class cellularLocation : Inherits EntityProperty

End Class
Public Class entityReference : Inherits EntityProperty

End Class
Public Class comment : Inherits EntityProperty
End Class
Public Class xref : Inherits EntityProperty

End Class
Public Class dataSource : Inherits EntityProperty

End Class
Public Class term : Inherits EntityProperty

End Class