Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.DocumentFormat.RDF

Namespace Level3.Schema

    ''' <summary>
    ''' Absolute location as defined by the referenced sequence database record. E.g. an operon 
    ''' has a absolute region on the DNA molecule referenced by the UnificationXref.
    ''' </summary>
    Public Class FunctionalProperty : Inherits RDFEntity

        Public Property type As RDFProperty
        Public Property domain As domain

    End Class

    Public Class domain : Inherits RDFProperty
        Public Property [Class] As [Class]
    End Class

    Public Class [Class] : Inherits RDFEntity
        Public Property unionOf As unionOf
        ''' <summary>
        ''' rdfs:subClassOf
        ''' </summary>
        ''' <returns></returns>
        <XmlElement> Public Property subClassOf As subClassOf()
        ''' <summary>
        ''' owl:disjointWith
        ''' </summary>
        ''' <returns></returns>
        Public Property disjointWith As RDFProperty
    End Class

    Public Class subClassOf : Inherits RDFEntity
        Public Property Restriction As Restriction
    End Class

    Public Class Restriction : Inherits RDFEntity
        Public Property onProperty As RDFProperty
        Public Property allValuesFrom As RDFProperty

    End Class

    Public Class unionOf : Inherits RDFProperty
        <XmlElement> Public Property [Class] As RDFProperty()
    End Class

    Public Class InverseFunctionalProperty : Inherits RDFEntity
        <XmlElement> Public Property type As RDFProperty()
        Public Property domain As domain
        Public Property inverseOf As RDFProperty

    End Class
End Namespace