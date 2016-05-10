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


Public Class conversionDirection : Inherits EntityProperty

End Class
Public Class participantStoichiometry : Inherits EntityProperty 

End Class
Public Class left : Inherits EntityProperty

End Class
Public Class right : Inherits EntityProperty

End Class
Public Class eCNumber : Inherits EntityProperty 

End Class

Public Class db : Inherits EntityProperty


End Class
Public Class id : Inherits EntityProperty


End Class

Public Class idVersion : Inherits EntityProperty

End Class

Public Class stoichiometricCoefficient : Inherits EntityProperty

End Class
Public Class physicalEntity : Inherits EntityProperty

End Class
Public Class componentStoichiometry : Inherits EntityProperty

End Class
Public Class organism : Inherits EntityProperty

End Class


Public Class featureLocation : Inherits EntityProperty

End Class

Public Class SequenceInterval : Inherits EntityProperty

End Class
Public Class sequenceIntervalBegin : Inherits EntityProperty

End Class
Public Class sequenceIntervalEnd : Inherits EntityProperty

End Class

Public Class SequenceSite : Inherits EntityProperty

End Class
Public Class sequencePosition : Inherits EntityProperty

End Class
Public Class positionStatus : Inherits EntityProperty

End Class